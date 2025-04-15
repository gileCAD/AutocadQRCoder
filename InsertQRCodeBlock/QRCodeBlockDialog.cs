using AutocadQRCoder;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
    }
}
