namespace InsertQRCodeBlock
{
    partial class QRCodeBlockDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTextToEncode = new System.Windows.Forms.Label();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.comboBoxEccLevel = new System.Windows.Forms.ComboBox();
            this.labelEccLevel = new System.Windows.Forms.Label();
            this.checkBoxUtf8 = new System.Windows.Forms.CheckBox();
            this.checkBoxUtf8Bom = new System.Windows.Forms.CheckBox();
            this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
            this.comboBoxRequestVersion = new System.Windows.Forms.ComboBox();
            this.labelRequestVersion = new System.Windows.Forms.Label();
            this.comboBoxECI = new System.Windows.Forms.ComboBox();
            this.labelECI = new System.Windows.Forms.Label();
            this.groupBoxBlock = new System.Windows.Forms.GroupBox();
            this.numericBoxScale = new InsertQRCodeBlock.NumericBox();
            this.checkBoxAttribute = new System.Windows.Forms.CheckBox();
            this.labelScale = new System.Windows.Forms.Label();
            this.labelLayer = new System.Windows.Forms.Label();
            this.comboBoxLayer = new System.Windows.Forms.ComboBox();
            this.textBoxBlockName = new System.Windows.Forms.TextBox();
            this.labelBlockName = new System.Windows.Forms.Label();
            this.groupBoxEncoding.SuspendLayout();
            this.groupBoxBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(140, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(239, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelTextToEncode
            // 
            this.labelTextToEncode.AutoSize = true;
            this.labelTextToEncode.Location = new System.Drawing.Point(13, 13);
            this.labelTextToEncode.Name = "labelTextToEncode";
            this.labelTextToEncode.Size = new System.Drawing.Size(103, 13);
            this.labelTextToEncode.TabIndex = 2;
            this.labelTextToEncode.Text = "Text to be encoded:";
            // 
            // textBoxPlainText
            // 
            this.textBoxPlainText.AcceptsReturn = true;
            this.textBoxPlainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlainText.Location = new System.Drawing.Point(13, 32);
            this.textBoxPlainText.Multiline = true;
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(429, 40);
            this.textBoxPlainText.TabIndex = 0;
            // 
            // comboBoxEccLevel
            // 
            this.comboBoxEccLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEccLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEccLevel.FormattingEnabled = true;
            this.comboBoxEccLevel.Location = new System.Drawing.Point(200, 19);
            this.comboBoxEccLevel.Name = "comboBoxEccLevel";
            this.comboBoxEccLevel.Size = new System.Drawing.Size(69, 21);
            this.comboBoxEccLevel.TabIndex = 4;
            // 
            // labelEccLevel
            // 
            this.labelEccLevel.AutoSize = true;
            this.labelEccLevel.Location = new System.Drawing.Point(6, 22);
            this.labelEccLevel.Name = "labelEccLevel";
            this.labelEccLevel.Size = new System.Drawing.Size(155, 13);
            this.labelEccLevel.TabIndex = 5;
            this.labelEccLevel.Text = "Error Control Code Level (ECC):";
            // 
            // checkBoxUtf8
            // 
            this.checkBoxUtf8.AutoSize = true;
            this.checkBoxUtf8.Location = new System.Drawing.Point(9, 48);
            this.checkBoxUtf8.Name = "checkBoxUtf8";
            this.checkBoxUtf8.Size = new System.Drawing.Size(86, 17);
            this.checkBoxUtf8.TabIndex = 6;
            this.checkBoxUtf8.Text = "Force UTF 8";
            this.checkBoxUtf8.UseVisualStyleBackColor = true;
            // 
            // checkBoxUtf8Bom
            // 
            this.checkBoxUtf8Bom.AutoSize = true;
            this.checkBoxUtf8Bom.Location = new System.Drawing.Point(129, 48);
            this.checkBoxUtf8Bom.Name = "checkBoxUtf8Bom";
            this.checkBoxUtf8Bom.Size = new System.Drawing.Size(113, 17);
            this.checkBoxUtf8Bom.TabIndex = 7;
            this.checkBoxUtf8Bom.Text = "Force UTF 8 BOM";
            this.checkBoxUtf8Bom.UseVisualStyleBackColor = true;
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxEncoding.Controls.Add(this.comboBoxRequestVersion);
            this.groupBoxEncoding.Controls.Add(this.labelRequestVersion);
            this.groupBoxEncoding.Controls.Add(this.comboBoxECI);
            this.groupBoxEncoding.Controls.Add(this.labelECI);
            this.groupBoxEncoding.Controls.Add(this.labelEccLevel);
            this.groupBoxEncoding.Controls.Add(this.checkBoxUtf8Bom);
            this.groupBoxEncoding.Controls.Add(this.comboBoxEccLevel);
            this.groupBoxEncoding.Controls.Add(this.checkBoxUtf8);
            this.groupBoxEncoding.Location = new System.Drawing.Point(12, 81);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(275, 133);
            this.groupBoxEncoding.TabIndex = 8;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "Encoding parameters";
            // 
            // comboBoxRequestVersion
            // 
            this.comboBoxRequestVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRequestVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRequestVersion.FormattingEnabled = true;
            this.comboBoxRequestVersion.Items.AddRange(new object[] {
            "Auto",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboBoxRequestVersion.Location = new System.Drawing.Point(200, 103);
            this.comboBoxRequestVersion.Name = "comboBoxRequestVersion";
            this.comboBoxRequestVersion.Size = new System.Drawing.Size(69, 21);
            this.comboBoxRequestVersion.TabIndex = 11;
            // 
            // labelRequestVersion
            // 
            this.labelRequestVersion.AutoSize = true;
            this.labelRequestVersion.Location = new System.Drawing.Point(6, 106);
            this.labelRequestVersion.Name = "labelRequestVersion";
            this.labelRequestVersion.Size = new System.Drawing.Size(87, 13);
            this.labelRequestVersion.TabIndex = 10;
            this.labelRequestVersion.Text = "Request version:";
            // 
            // comboBoxECI
            // 
            this.comboBoxECI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxECI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxECI.FormattingEnabled = true;
            this.comboBoxECI.Location = new System.Drawing.Point(200, 76);
            this.comboBoxECI.Name = "comboBoxECI";
            this.comboBoxECI.Size = new System.Drawing.Size(69, 21);
            this.comboBoxECI.TabIndex = 9;
            // 
            // labelECI
            // 
            this.labelECI.AutoSize = true;
            this.labelECI.Location = new System.Drawing.Point(6, 79);
            this.labelECI.Name = "labelECI";
            this.labelECI.Size = new System.Drawing.Size(188, 13);
            this.labelECI.TabIndex = 8;
            this.labelECI.Text = "Extended Channel Interpretation (ECI):";
            // 
            // groupBoxBlock
            // 
            this.groupBoxBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBlock.Controls.Add(this.numericBoxScale);
            this.groupBoxBlock.Controls.Add(this.checkBoxAttribute);
            this.groupBoxBlock.Controls.Add(this.labelScale);
            this.groupBoxBlock.Controls.Add(this.labelLayer);
            this.groupBoxBlock.Controls.Add(this.comboBoxLayer);
            this.groupBoxBlock.Controls.Add(this.textBoxBlockName);
            this.groupBoxBlock.Controls.Add(this.labelBlockName);
            this.groupBoxBlock.Location = new System.Drawing.Point(293, 81);
            this.groupBoxBlock.Name = "groupBoxBlock";
            this.groupBoxBlock.Size = new System.Drawing.Size(149, 133);
            this.groupBoxBlock.TabIndex = 9;
            this.groupBoxBlock.TabStop = false;
            this.groupBoxBlock.Text = "Block";
            // 
            // numericBoxScale
            // 
            this.numericBoxScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericBoxScale.DecimalPlaces = 0;
            this.numericBoxScale.ErrorMsg = "Incorrect number";
            this.numericBoxScale.Location = new System.Drawing.Point(75, 76);
            this.numericBoxScale.Maximum = 1.7976931348623157E+308D;
            this.numericBoxScale.Minimum = 1E-16D;
            this.numericBoxScale.Name = "numericBoxScale";
            this.numericBoxScale.Size = new System.Drawing.Size(68, 20);
            this.numericBoxScale.TabIndex = 7;
            this.numericBoxScale.Text = "1";
            this.numericBoxScale.Value = 1D;
            // 
            // checkBoxAttribute
            // 
            this.checkBoxAttribute.AutoSize = true;
            this.checkBoxAttribute.Checked = true;
            this.checkBoxAttribute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAttribute.Location = new System.Drawing.Point(6, 105);
            this.checkBoxAttribute.Name = "checkBoxAttribute";
            this.checkBoxAttribute.Size = new System.Drawing.Size(130, 17);
            this.checkBoxAttribute.TabIndex = 6;
            this.checkBoxAttribute.Text = "Add constant attribute";
            this.checkBoxAttribute.UseVisualStyleBackColor = true;
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(6, 79);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(68, 13);
            this.labelScale.TabIndex = 5;
            this.labelScale.Text = "Global scale:";
            // 
            // labelLayer
            // 
            this.labelLayer.AutoSize = true;
            this.labelLayer.Location = new System.Drawing.Point(6, 49);
            this.labelLayer.Name = "labelLayer";
            this.labelLayer.Size = new System.Drawing.Size(36, 13);
            this.labelLayer.TabIndex = 3;
            this.labelLayer.Text = "Layer:";
            // 
            // comboBoxLayer
            // 
            this.comboBoxLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLayer.FormattingEnabled = true;
            this.comboBoxLayer.Location = new System.Drawing.Point(48, 46);
            this.comboBoxLayer.Name = "comboBoxLayer";
            this.comboBoxLayer.Size = new System.Drawing.Size(95, 21);
            this.comboBoxLayer.TabIndex = 2;
            // 
            // textBoxBlockName
            // 
            this.textBoxBlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBlockName.Location = new System.Drawing.Point(48, 20);
            this.textBoxBlockName.Name = "textBoxBlockName";
            this.textBoxBlockName.Size = new System.Drawing.Size(95, 20);
            this.textBoxBlockName.TabIndex = 1;
            this.textBoxBlockName.Text = "*U";
            // 
            // labelBlockName
            // 
            this.labelBlockName.AutoSize = true;
            this.labelBlockName.Location = new System.Drawing.Point(6, 23);
            this.labelBlockName.Name = "labelBlockName";
            this.labelBlockName.Size = new System.Drawing.Size(38, 13);
            this.labelBlockName.TabIndex = 0;
            this.labelBlockName.Text = "Name:";
            // 
            // QRCodeBlockDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.groupBoxBlock);
            this.Controls.Add(this.groupBoxEncoding);
            this.Controls.Add(this.textBoxPlainText);
            this.Controls.Add(this.labelTextToEncode);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 280);
            this.Name = "QRCodeBlockDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QR Code Block";
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.groupBoxBlock.ResumeLayout(false);
            this.groupBoxBlock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTextToEncode;
        private System.Windows.Forms.TextBox textBoxPlainText;
        private System.Windows.Forms.ComboBox comboBoxEccLevel;
        private System.Windows.Forms.Label labelEccLevel;
        private System.Windows.Forms.CheckBox checkBoxUtf8;
        private System.Windows.Forms.CheckBox checkBoxUtf8Bom;
        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.Label labelECI;
        private System.Windows.Forms.ComboBox comboBoxRequestVersion;
        private System.Windows.Forms.Label labelRequestVersion;
        private System.Windows.Forms.ComboBox comboBoxECI;
        private System.Windows.Forms.GroupBox groupBoxBlock;
        private System.Windows.Forms.TextBox textBoxBlockName;
        private System.Windows.Forms.Label labelBlockName;
        private System.Windows.Forms.Label labelLayer;
        private System.Windows.Forms.ComboBox comboBoxLayer;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.CheckBox checkBoxAttribute;
        private NumericBox numericBoxScale;
    }
}