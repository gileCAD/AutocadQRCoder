using AutocadQRCoder;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using AcadColor = Autodesk.AutoCAD.Colors.Color;
using AcadWindows = Autodesk.AutoCAD.Windows;

namespace InsertQRCodeBlock
{
    public partial class QRCodeBlockDialog : Form
    {
        public string PlainText => textBoxPlainText.Text;

        public ECCLevel ECCLevel => (ECCLevel)comboBoxEccLevel.SelectedItem;

        public bool ForceUtf8 => checkBoxUtf8.Checked;

        public bool ForceUtf8Bom => checkBoxUtf8Bom.Checked;

        public EciMode EciMode => (EciMode)comboBoxECI.SelectedItem;

        public int RequestVerion =>
            (string)comboBoxRequestVersion.SelectedItem == "Auto" ? -1 : 
            int.Parse((string)comboBoxRequestVersion.SelectedItem);

        public string BlockName => textBoxBlockName.Text;

        public string Layer => (string)comboBoxLayer.SelectedItem;

        public double BlockScale => numericBoxScale.Value;

        public bool AddAttribute => checkBoxAttribute.Checked;

        public AcadColor BackgroundColor { get; private set; } = AcadColor.FromRgb(255, 255, 255);

        public AcadColor ForegroundColor { get; private set; } = AcadColor.FromRgb(0, 0, 0);

        public QRCodeBlockDialog(List<string> layers, string layer)
        {
            InitializeComponent();
            comboBoxEccLevel.DataSource = Enum.GetValues(typeof(ECCLevel));
            comboBoxEccLevel.SelectedItem = ECCLevel.Default;
            comboBoxECI.DataSource = Enum.GetValues(typeof(EciMode));
            comboBoxECI.SelectedItem = EciMode.Default;
            comboBoxRequestVersion.SelectedItem = "Auto";
            comboBoxLayer.DataSource = layers;
            comboBoxLayer.SelectedItem = layer;
        }

        private void ButtonBackground_Click(object sender, EventArgs e)
        {
            SetColor(true);
        }

        private void buttonForeground_Click(object sender, EventArgs e)
        {
            SetColor(false);
        }

        private void SetColor(bool isBackground)
        {
            var colorDialog = new AcadWindows.ColorDialog()
            {
                Color = isBackground ? BackgroundColor : ForegroundColor,
                IncludeByBlockByLayer = false
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                AcadColor color = colorDialog.Color;
                if (isBackground)
                {
                    pictureBoxBackground.BackColor = color.ColorValue;
                    BackgroundColor = color;
                }
                else
                {
                    pictureBoxForeground.BackColor = color.ColorValue;
                    ForegroundColor = color;
                }
            }
        }
    }
}
