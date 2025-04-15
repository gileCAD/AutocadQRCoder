using AutocadQRCoder;

using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

using System.Collections.Generic;
using System.Windows.Forms;

using AcAp = Autodesk.AutoCAD.ApplicationServices.Application;
using AcCoreAp = Autodesk.AutoCAD.ApplicationServices.Core.Application;

[assembly: CommandClass(typeof(InsertQRCodeBlock.Commands))]

namespace InsertQRCodeBlock
{
    public class Commands
    {
        [CommandMethod("QRCODEINSERT")]
        public static void QRCodeInsert()
        {
            var doc = AcCoreAp.DocumentManager.MdiActiveDocument;
            var db = doc.Database;
            var ed = doc.Editor;
            var layers = GetLayers(db, out string clayer);
            using (var dialog = new QRCodeBlockDialog(layers, clayer))
            {
                var dialogResult = AcAp.ShowModalDialog(dialog);
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        using (var tr = db.TransactionManager.StartTransaction())
                        {
                            var blockTable = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                            if (blockTable.Has(dialog.BlockName))
                            {
                                ed.WriteMessage($"\nError: a block named '{dialog.BlockName}' already exists.");
                                return;
                            }
                            var coder = new BlockQRCoder(
                                dialog.PlainText,
                                dialog.ECCLevel,
                                dialog.ForceUtf8 | dialog.ForceUtf8Bom,
                                dialog.ForceUtf8Bom,
                                dialog.EciMode,
                                dialog.RequestVerion);
                            var btrId = coder.CreateBlock(db, dialog.BlockName, dialog.AddAttribute);
                            using (var br = new BlockReference(Point3d.Origin, btrId)
                            {
                                Layer = dialog.Layer,
                                ScaleFactors = new Scale3d(dialog.BlockScale)
                            })
                            {
                                br.TransformBy(ed.CurrentUserCoordinateSystem);
                                var jig = new QRCodeBlockJig(br, "\nSpecify insertion point: ");
                                var result = ed.Drag(jig);
                                if (result.Status == PromptStatus.OK)
                                {
                                    var currentSpace = (BlockTableRecord)tr.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);
                                    currentSpace.AppendEntity(br);
                                    tr.AddNewlyCreatedDBObject(br, true);
                                }
                            }
                            tr.Commit();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        ed.WriteMessage($"\nError: {ex.Message}\n{ex.StackTrace}");
                    }
                }
            }
        }

        private static List<string> GetLayers(Database db, out string clayer)
        {
            var layers = new List<string>();
            clayer = default;
            using (var tr = new OpenCloseTransaction())
            {
                var layerTable = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForRead);
                foreach (ObjectId id in layerTable)
                {
                    var layer = (LayerTableRecord)tr.GetObject(id, OpenMode.ForRead);
                    layers.Add(layer.Name);
                    if (id == db.Clayer)
                        clayer = layer.Name;
                }
            }
            return layers;
        }

        class QRCodeBlockJig : EntityJig
        {
            Point3d dragPoint;
            readonly BlockReference br;
            readonly string message;

            public QRCodeBlockJig(BlockReference br, string message) : base(br)
            {
                this.br = br;
                this.message = message;
            }

            protected override SamplerStatus Sampler(JigPrompts prompts)
            {
                var result = prompts.AcquirePoint(message);
                if (result.Value.IsEqualTo(dragPoint))
                    return SamplerStatus.NoChange;
                dragPoint = result.Value;
                return SamplerStatus.OK;
            }

            protected override bool Update()
            {
                br.Position = dragPoint;
                return true;
            }
        }
    }
}
