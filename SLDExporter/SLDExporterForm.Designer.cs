namespace SLDExporter
{
    partial class SLDExporterForm
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
            this.groupBoxPublishSLD = new System.Windows.Forms.GroupBox();
            this.buttonGSpublishSLD = new System.Windows.Forms.Button();
            this.labelGSlayers = new System.Windows.Forms.Label();
            this.comboBoxGSlayers = new System.Windows.Forms.ComboBox();
            this.buttonGSconnect = new System.Windows.Forms.Button();
            this.labelGSpassword = new System.Windows.Forms.Label();
            this.labelGSusername = new System.Windows.Forms.Label();
            this.textBoxGSpassword = new System.Windows.Forms.TextBox();
            this.textBoxGSusername = new System.Windows.Forms.TextBox();
            this.groupBoxExportSLD = new System.Windows.Forms.GroupBox();
            this.labelResultValueField = new System.Windows.Forms.Label();
            this.labelResultLabelStatus = new System.Windows.Forms.Label();
            this.labelResultLayerName = new System.Windows.Forms.Label();
            this.labelResultFRendererType = new System.Windows.Forms.Label();
            this.labelValueField = new System.Windows.Forms.Label();
            this.buttonExportSLD = new System.Windows.Forms.Button();
            this.labelLayerName = new System.Windows.Forms.Label();
            this.labelFRendererType = new System.Windows.Forms.Label();
            this.labelLabelStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxPublishSLD.SuspendLayout();
            this.groupBoxExportSLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPublishSLD
            // 
            this.groupBoxPublishSLD.Controls.Add(this.buttonGSpublishSLD);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSlayers);
            this.groupBoxPublishSLD.Controls.Add(this.comboBoxGSlayers);
            this.groupBoxPublishSLD.Controls.Add(this.buttonGSconnect);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSpassword);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSusername);
            this.groupBoxPublishSLD.Controls.Add(this.textBoxGSpassword);
            this.groupBoxPublishSLD.Controls.Add(this.textBoxGSusername);
            this.groupBoxPublishSLD.Location = new System.Drawing.Point(358, 85);
            this.groupBoxPublishSLD.Name = "groupBoxPublishSLD";
            this.groupBoxPublishSLD.Size = new System.Drawing.Size(416, 220);
            this.groupBoxPublishSLD.TabIndex = 0;
            this.groupBoxPublishSLD.TabStop = false;
            this.groupBoxPublishSLD.Text = "Create SLD style on published GeoServer Layer";
            // 
            // buttonGSpublishSLD
            // 
            this.buttonGSpublishSLD.Location = new System.Drawing.Point(297, 183);
            this.buttonGSpublishSLD.Name = "buttonGSpublishSLD";
            this.buttonGSpublishSLD.Size = new System.Drawing.Size(113, 23);
            this.buttonGSpublishSLD.TabIndex = 7;
            this.buttonGSpublishSLD.Text = "Publish SLD";
            this.buttonGSpublishSLD.UseVisualStyleBackColor = true;
            // 
            // labelGSlayers
            // 
            this.labelGSlayers.AutoSize = true;
            this.labelGSlayers.Location = new System.Drawing.Point(80, 156);
            this.labelGSlayers.Name = "labelGSlayers";
            this.labelGSlayers.Size = new System.Drawing.Size(128, 17);
            this.labelGSlayers.TabIndex = 6;
            this.labelGSlayers.Text = "GeoServer Layers:";
            // 
            // comboBoxGSlayers
            // 
            this.comboBoxGSlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGSlayers.FormattingEnabled = true;
            this.comboBoxGSlayers.Location = new System.Drawing.Point(230, 153);
            this.comboBoxGSlayers.Name = "comboBoxGSlayers";
            this.comboBoxGSlayers.Size = new System.Drawing.Size(180, 24);
            this.comboBoxGSlayers.TabIndex = 5;
            // 
            // buttonGSconnect
            // 
            this.buttonGSconnect.Location = new System.Drawing.Point(322, 108);
            this.buttonGSconnect.Name = "buttonGSconnect";
            this.buttonGSconnect.Size = new System.Drawing.Size(88, 23);
            this.buttonGSconnect.TabIndex = 4;
            this.buttonGSconnect.Text = "Connect";
            this.buttonGSconnect.UseVisualStyleBackColor = true;
            // 
            // labelGSpassword
            // 
            this.labelGSpassword.AutoSize = true;
            this.labelGSpassword.Location = new System.Drawing.Point(135, 83);
            this.labelGSpassword.Name = "labelGSpassword";
            this.labelGSpassword.Size = new System.Drawing.Size(73, 17);
            this.labelGSpassword.TabIndex = 3;
            this.labelGSpassword.Text = "Password:";
            // 
            // labelGSusername
            // 
            this.labelGSusername.AutoSize = true;
            this.labelGSusername.Location = new System.Drawing.Point(131, 54);
            this.labelGSusername.Name = "labelGSusername";
            this.labelGSusername.Size = new System.Drawing.Size(77, 17);
            this.labelGSusername.TabIndex = 2;
            this.labelGSusername.Text = "Username:";
            this.labelGSusername.Click += new System.EventHandler(this.labelGSusername_Click);
            // 
            // textBoxGSpassword
            // 
            this.textBoxGSpassword.Location = new System.Drawing.Point(230, 80);
            this.textBoxGSpassword.Name = "textBoxGSpassword";
            this.textBoxGSpassword.Size = new System.Drawing.Size(180, 22);
            this.textBoxGSpassword.TabIndex = 1;
            // 
            // textBoxGSusername
            // 
            this.textBoxGSusername.Location = new System.Drawing.Point(230, 51);
            this.textBoxGSusername.Name = "textBoxGSusername";
            this.textBoxGSusername.Size = new System.Drawing.Size(180, 22);
            this.textBoxGSusername.TabIndex = 0;
            // 
            // groupBoxExportSLD
            // 
            this.groupBoxExportSLD.Controls.Add(this.labelResultValueField);
            this.groupBoxExportSLD.Controls.Add(this.labelResultLabelStatus);
            this.groupBoxExportSLD.Controls.Add(this.labelResultLayerName);
            this.groupBoxExportSLD.Controls.Add(this.labelResultFRendererType);
            this.groupBoxExportSLD.Controls.Add(this.labelValueField);
            this.groupBoxExportSLD.Controls.Add(this.buttonExportSLD);
            this.groupBoxExportSLD.Controls.Add(this.labelLayerName);
            this.groupBoxExportSLD.Controls.Add(this.labelFRendererType);
            this.groupBoxExportSLD.Controls.Add(this.labelLabelStatus);
            this.groupBoxExportSLD.Location = new System.Drawing.Point(12, 85);
            this.groupBoxExportSLD.Name = "groupBoxExportSLD";
            this.groupBoxExportSLD.Size = new System.Drawing.Size(340, 220);
            this.groupBoxExportSLD.TabIndex = 1;
            this.groupBoxExportSLD.TabStop = false;
            this.groupBoxExportSLD.Text = "Export layer symbology as SLD";
            // 
            // labelResultValueField
            // 
            this.labelResultValueField.AutoSize = true;
            this.labelResultValueField.Location = new System.Drawing.Point(180, 138);
            this.labelResultValueField.Name = "labelResultValueField";
            this.labelResultValueField.Size = new System.Drawing.Size(13, 17);
            this.labelResultValueField.TabIndex = 8;
            this.labelResultValueField.Text = "-";
            // 
            // labelResultLabelStatus
            // 
            this.labelResultLabelStatus.AutoSize = true;
            this.labelResultLabelStatus.Location = new System.Drawing.Point(180, 111);
            this.labelResultLabelStatus.Name = "labelResultLabelStatus";
            this.labelResultLabelStatus.Size = new System.Drawing.Size(13, 17);
            this.labelResultLabelStatus.TabIndex = 7;
            this.labelResultLabelStatus.Text = "-";
            // 
            // labelResultLayerName
            // 
            this.labelResultLayerName.AutoSize = true;
            this.labelResultLayerName.Location = new System.Drawing.Point(180, 54);
            this.labelResultLayerName.Name = "labelResultLayerName";
            this.labelResultLayerName.Size = new System.Drawing.Size(13, 17);
            this.labelResultLayerName.TabIndex = 6;
            this.labelResultLayerName.Text = "-";
            // 
            // labelResultFRendererType
            // 
            this.labelResultFRendererType.AutoSize = true;
            this.labelResultFRendererType.Location = new System.Drawing.Point(180, 83);
            this.labelResultFRendererType.Name = "labelResultFRendererType";
            this.labelResultFRendererType.Size = new System.Drawing.Size(13, 17);
            this.labelResultFRendererType.TabIndex = 5;
            this.labelResultFRendererType.Text = "-";
            // 
            // labelValueField
            // 
            this.labelValueField.AutoSize = true;
            this.labelValueField.Location = new System.Drawing.Point(85, 138);
            this.labelValueField.Name = "labelValueField";
            this.labelValueField.Size = new System.Drawing.Size(82, 17);
            this.labelValueField.TabIndex = 4;
            this.labelValueField.Text = "Value Field:";
            // 
            // buttonExportSLD
            // 
            this.buttonExportSLD.Location = new System.Drawing.Point(219, 183);
            this.buttonExportSLD.Name = "buttonExportSLD";
            this.buttonExportSLD.Size = new System.Drawing.Size(115, 23);
            this.buttonExportSLD.TabIndex = 3;
            this.buttonExportSLD.Text = "Export SLD";
            this.buttonExportSLD.UseVisualStyleBackColor = true;
            // 
            // labelLayerName
            // 
            this.labelLayerName.AutoSize = true;
            this.labelLayerName.Location = new System.Drawing.Point(78, 54);
            this.labelLayerName.Name = "labelLayerName";
            this.labelLayerName.Size = new System.Drawing.Size(89, 17);
            this.labelLayerName.TabIndex = 2;
            this.labelLayerName.Text = "Layer Name:";
            // 
            // labelFRendererType
            // 
            this.labelFRendererType.AutoSize = true;
            this.labelFRendererType.Location = new System.Drawing.Point(6, 83);
            this.labelFRendererType.Name = "labelFRendererType";
            this.labelFRendererType.Size = new System.Drawing.Size(161, 17);
            this.labelFRendererType.TabIndex = 1;
            this.labelFRendererType.Text = "Feature Renderer Type:";
            // 
            // labelLabelStatus
            // 
            this.labelLabelStatus.AutoSize = true;
            this.labelLabelStatus.Location = new System.Drawing.Point(76, 111);
            this.labelLabelStatus.Name = "labelLabelStatus";
            this.labelLabelStatus.Size = new System.Drawing.Size(91, 17);
            this.labelLabelStatus.TabIndex = 0;
            this.labelLabelStatus.Text = "Label Status:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SLDExporter.SLDExporterResource.gServerLogo;
            this.pictureBox1.Location = new System.Drawing.Point(560, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SLDExporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxExportSLD);
            this.Controls.Add(this.groupBoxPublishSLD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SLDExporterForm";
            this.Text = "SLDExporter";
            this.Load += new System.EventHandler(this.SLDExporterForm_Load);
            this.groupBoxPublishSLD.ResumeLayout(false);
            this.groupBoxPublishSLD.PerformLayout();
            this.groupBoxExportSLD.ResumeLayout(false);
            this.groupBoxExportSLD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPublishSLD;
        private System.Windows.Forms.Label labelGSlayers;
        private System.Windows.Forms.ComboBox comboBoxGSlayers;
        private System.Windows.Forms.Button buttonGSconnect;
        private System.Windows.Forms.Label labelGSpassword;
        private System.Windows.Forms.Label labelGSusername;
        private System.Windows.Forms.TextBox textBoxGSpassword;
        private System.Windows.Forms.TextBox textBoxGSusername;
        private System.Windows.Forms.GroupBox groupBoxExportSLD;
        private System.Windows.Forms.Button buttonGSpublishSLD;
        private System.Windows.Forms.Button buttonExportSLD;
        private System.Windows.Forms.Label labelLayerName;
        private System.Windows.Forms.Label labelFRendererType;
        private System.Windows.Forms.Label labelLabelStatus;
        private System.Windows.Forms.Label labelResultValueField;
        private System.Windows.Forms.Label labelResultLabelStatus;
        private System.Windows.Forms.Label labelResultLayerName;
        private System.Windows.Forms.Label labelResultFRendererType;
        private System.Windows.Forms.Label labelValueField;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}