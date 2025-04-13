using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Colors;
using QRCoder;
using System.Collections.Generic;
using System.Collections;

namespace AutocadQRCoder
{
    /// <summary>
    /// Error correction code (ECC) level (same as QRCoder.QRCodeGenerator.ECCLevel).
    /// </summary>
    public enum ECCLevel
    {
        Default = -1,
        L,
        M,
        Q,
        H
    }

    /// <summary>
    /// Extended Channel Interpretation (ECI) mode (same as QRCoder.QRCodeGenerator.EciMode).
    /// </summary>
    public enum EciMode
    {
        Default = 0,
        Iso8859_1 = 3,
        Iso8859_2 = 4,
        Utf8 = 26
    }

    /// <summary>
    /// Provides methods to create AutoCAD entities (Hatch or Block) representing a QRCode.
    /// Uses QRCOder library (https://github.com/codebude/QRCoder/wiki).
    /// </summary>
    public class BlockQRCoder
    {
        private readonly List<BitArray> matrix;
        private readonly string plainText;
        private readonly int size;

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        public Color BackgroundColor { get; set; } = Color.FromRgb(255, 255, 255);

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        public Color ForegroundColor { get; set; } = Color.FromRgb(0, 0, 0);

        /// <summary>
        /// Creates a new intance of BlockQRCoder (same parameters as QRCodeGenerator.CreateQrCode method).
        /// </summary>
        /// <param name="plainText">Text which shall be encoded in the QR Code.</param>
        /// <param name="eccLevel">Error correction code level. Either L (7%), M (15%), Q (25%) or H (30%).</param>
        /// <param name="forceUtf8">If true, forces text encoding in UTF-8.</param>
        /// <param name="utf8BOM">If true, sets ByteOrderMark (BOM) when BlockQRCoder uses UTF-8 for text-encoding</param>
        /// <param name="eciMode">Fixed ECI mode.</param>
        /// <param name="requestedVersion">Fixed QR code version.</param>
        public BlockQRCoder(
            string plainText,
            ECCLevel eccLevel = ECCLevel.Default,
            bool forceUtf8 = false,
            bool utf8BOM = false,
            EciMode eciMode = EciMode.Default,
            int requestedVersion = -1)
        {
            this.plainText = plainText;
            var ecc = (QRCodeGenerator.ECCLevel)eccLevel;
            var eci = (QRCodeGenerator.EciMode)eciMode;
            using (var qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(plainText, ecc, forceUtf8, utf8BOM, eci, requestedVersion))
            {
                matrix = qrCodeData.ModuleMatrix;
                size = matrix.Count;
            }
        }

        /// <summary>
        /// Creates a new block definition.
        /// </summary>
        /// <param name="db">Database to which the block belongs.</param>
        /// <param name="blockName">Name of the block (creates an anonymous block if null).</param>
        /// <param name="plainTextAsAttribute">If true, adds a constant attribute (plain text).</param>
        /// <returns>The objectId of the block definition.</returns>
        /// <exception cref="System.ArgumentException">Thrown if the database already contain a block with the same name.</exception>
        public ObjectId CreateBlock(Database db, string blockName = null, bool plainTextAsAttribute = false)
        {
            ObjectId blockId;
            using (var tr = new OpenCloseTransaction())
            {
                if (string.IsNullOrEmpty(blockName))
                    blockName = "*U";
                var blockTable = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);

                if (blockTable.Has(blockName))
                    throw new System.ArgumentException($"{blockName} already exists", nameof(blockName));

                var btr = new BlockTableRecord
                {
                    Name = blockName
                };
                tr.GetObject(db.BlockTableId, OpenMode.ForWrite);
                blockId = blockTable.Add(btr);
                tr.AddNewlyCreatedDBObject(btr, true);

                var solid = GetBackgroundSolid();
                btr.AppendEntity(solid);
                tr.AddNewlyCreatedDBObject(solid, true);

                var hatch = GetHatch();
                btr.AppendEntity(hatch);
                tr.AddNewlyCreatedDBObject(hatch, true);

                if (plainTextAsAttribute)
                {
                    var attDef = new AttributeDefinition(Point3d.Origin, plainText, "TEXT", "", db.Textstyle)
                    {
                        Constant = true,
                        Height = 2.5,
                        Justify = AttachmentPoint.BaseCenter,
                        AlignmentPoint = new Point3d(size / 2.0, -5.0, 0.0)
                    };
                    btr.AppendEntity(attDef);
                    tr.AddNewlyCreatedDBObject(attDef, true);
                }

                tr.Commit();
            }
            return blockId;
        }

        /// <summary>
        /// Gets a Solid figuring the QR Code background.
        /// </summary>
        /// <returns>the newly created Solid.</returns>
        public Solid GetBackgroundSolid() =>
            new Solid(
                    new Point3d(0.0, 0.0, 0.0),
                    new Point3d(size, 0.0, 0.0),
                    new Point3d(0.0, size, 0.0),
                    new Point3d(size, size, 0.0))
            { Color = BackgroundColor };

        /// <summary>
        /// Gets a Hatch figuring the QR Code.
        /// </summary>
        /// <returns>The newly created Hatch.</returns>
        public Hatch GetHatch()
        {
            var hatch = new Hatch();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i][j])
                    {
                        HatchLoop loop = new HatchLoop(HatchLoopTypes.Polyline);

                        double x = i;
                        double y = size - j;

                        loop.Polyline.Add(new BulgeVertex(new Point2d(x, y), 0.0));
                        loop.Polyline.Add(new BulgeVertex(new Point2d(x + 1.0, y), 0.0));
                        loop.Polyline.Add(new BulgeVertex(new Point2d(x + 1.0, y - 1.0), 0.0));
                        loop.Polyline.Add(new BulgeVertex(new Point2d(x, y - 1.0), 0.0));
                        loop.Polyline.Add(new BulgeVertex(new Point2d(x, y), 0.0));

                        hatch.AppendLoop(loop);
                    }
                }
            }
            hatch.SetHatchPattern(HatchPatternType.PreDefined, "SOLID");
            hatch.Color = ForegroundColor;
            hatch.EvaluateHatch(true);
            return hatch;
        }
    }
}
