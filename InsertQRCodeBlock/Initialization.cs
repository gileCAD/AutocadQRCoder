using Autodesk.AutoCAD.Runtime;

using System;

using AcCoreAp = Autodesk.AutoCAD.ApplicationServices.Core.Application;

[assembly: ExtensionApplication(typeof(InsertQRCodeBlock.Initialization))]

namespace InsertQRCodeBlock
{
    internal class Initialization : IExtensionApplication
    {
        public void Initialize()
        {
            AcCoreAp.Idle += OnIdle;
        }

        private void OnIdle(object sender, EventArgs e)
        {
            var doc = AcCoreAp.DocumentManager.MdiActiveDocument;
            if (doc != null)
            {
                AcCoreAp.Idle -= OnIdle;
                try
                {
                    doc.Editor.WriteMessage("\nInsertQRCodeBlock loaded.\n");
                }
                catch (System.Exception ex)
                {
                    doc.Editor.WriteMessage($"\nError: {ex.Message}\n");
                }
            }
        }

        public void Terminate()
        { }
    }
}
