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
            this.labelGSurl = new System.Windows.Forms.Label();
            this.textBoxGSurl = new System.Windows.Forms.TextBox();
            this.buttonGSaddStyleToLayer = new System.Windows.Forms.Button();
            this.labelGSstyles = new System.Windows.Forms.Label();
            this.labelGSsldName = new System.Windows.Forms.Label();
            this.textBoxGSsldName = new System.Windows.Forms.TextBox();
            this.labelGSworkspaces = new System.Windows.Forms.Label();
            this.comboBoxGSstyles = new System.Windows.Forms.ComboBox();
            this.comboBoxGSworkspaces = new System.Windows.Forms.ComboBox();
            this.buttonGSpublishSLD = new System.Windows.Forms.Button();
            this.labelGSlayers = new System.Windows.Forms.Label();
            this.comboBoxGSlayers = new System.Windows.Forms.ComboBox();
            this.buttonGSconnect = new System.Windows.Forms.Button();
            this.labelGSpassword = new System.Windows.Forms.Label();
            this.labelGSusername = new System.Windows.Forms.Label();
            this.textBoxGSpassword = new System.Windows.Forms.TextBox();
            this.textBoxGSusername = new System.Windows.Forms.TextBox();
            this.buttonExportSLD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxPublishSLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPublishSLD
            // 
            this.groupBoxPublishSLD.Controls.Add(this.labelGSurl);
            this.groupBoxPublishSLD.Controls.Add(this.textBoxGSurl);
            this.groupBoxPublishSLD.Controls.Add(this.buttonGSaddStyleToLayer);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSstyles);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSsldName);
            this.groupBoxPublishSLD.Controls.Add(this.textBoxGSsldName);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSworkspaces);
            this.groupBoxPublishSLD.Controls.Add(this.comboBoxGSstyles);
            this.groupBoxPublishSLD.Controls.Add(this.comboBoxGSworkspaces);
            this.groupBoxPublishSLD.Controls.Add(this.buttonGSpublishSLD);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSlayers);
            this.groupBoxPublishSLD.Controls.Add(this.comboBoxGSlayers);
            this.groupBoxPublishSLD.Controls.Add(this.buttonGSconnect);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSpassword);
            this.groupBoxPublishSLD.Controls.Add(this.labelGSusername);
            this.groupBoxPublishSLD.Controls.Add(this.textBoxGSpassword);
            this.groupBoxPublishSLD.Controls.Add(this.textBoxGSusername);
            this.groupBoxPublishSLD.Location = new System.Drawing.Point(12, 85);
            this.groupBoxPublishSLD.Name = "groupBoxPublishSLD";
            this.groupBoxPublishSLD.Size = new System.Drawing.Size(416, 391);
            this.groupBoxPublishSLD.TabIndex = 1;
            this.groupBoxPublishSLD.TabStop = false;
            this.groupBoxPublishSLD.Text = "Create SLD style on published GeoServer Layer";
            // 
            // labelGSurl
            // 
            this.labelGSurl.AutoSize = true;
            this.labelGSurl.Location = new System.Drawing.Point(90, 53);
            this.labelGSurl.Name = "labelGSurl";
            this.labelGSurl.Size = new System.Drawing.Size(113, 17);
            this.labelGSurl.TabIndex = 16;
            this.labelGSurl.Text = "GeoServer URL:";
            // 
            // textBoxGSurl
            // 
            this.textBoxGSurl.Location = new System.Drawing.Point(230, 50);
            this.textBoxGSurl.Name = "textBoxGSurl";
            this.textBoxGSurl.Size = new System.Drawing.Size(180, 22);
            this.textBoxGSurl.TabIndex = 1;
            // 
            // buttonGSaddStyleToLayer
            // 
            this.buttonGSaddStyleToLayer.Location = new System.Drawing.Point(245, 355);
            this.buttonGSaddStyleToLayer.Name = "buttonGSaddStyleToLayer";
            this.buttonGSaddStyleToLayer.Size = new System.Drawing.Size(165, 23);
            this.buttonGSaddStyleToLayer.TabIndex = 10;
            this.buttonGSaddStyleToLayer.Text = "Add Style To Layer";
            this.buttonGSaddStyleToLayer.UseVisualStyleBackColor = true;
            this.buttonGSaddStyleToLayer.Click += new System.EventHandler(this.buttonGSaddStyleToLayer_Click);
            // 
            // labelGSstyles
            // 
            this.labelGSstyles.AutoSize = true;
            this.labelGSstyles.Location = new System.Drawing.Point(80, 328);
            this.labelGSstyles.Name = "labelGSstyles";
            this.labelGSstyles.Size = new System.Drawing.Size(123, 17);
            this.labelGSstyles.TabIndex = 13;
            this.labelGSstyles.Text = "GeoServer Styles:";
            // 
            // labelGSsldName
            // 
            this.labelGSsldName.AutoSize = true;
            this.labelGSsldName.Location = new System.Drawing.Point(123, 220);
            this.labelGSsldName.Name = "labelGSsldName";
            this.labelGSsldName.Size = new System.Drawing.Size(80, 17);
            this.labelGSsldName.TabIndex = 12;
            this.labelGSsldName.Text = "SLD Name:";
            // 
            // textBoxGSsldName
            // 
            this.textBoxGSsldName.Location = new System.Drawing.Point(230, 217);
            this.textBoxGSsldName.Name = "textBoxGSsldName";
            this.textBoxGSsldName.Size = new System.Drawing.Size(180, 22);
            this.textBoxGSsldName.TabIndex = 6;
            // 
            // labelGSworkspaces
            // 
            this.labelGSworkspaces.AutoSize = true;
            this.labelGSworkspaces.Location = new System.Drawing.Point(40, 187);
            this.labelGSworkspaces.Name = "labelGSworkspaces";
            this.labelGSworkspaces.Size = new System.Drawing.Size(163, 17);
            this.labelGSworkspaces.TabIndex = 10;
            this.labelGSworkspaces.Text = "GeoServer Workspaces:";
            // 
            // comboBoxGSstyles
            // 
            this.comboBoxGSstyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGSstyles.FormattingEnabled = true;
            this.comboBoxGSstyles.Location = new System.Drawing.Point(230, 325);
            this.comboBoxGSstyles.Name = "comboBoxGSstyles";
            this.comboBoxGSstyles.Size = new System.Drawing.Size(180, 24);
            this.comboBoxGSstyles.TabIndex = 9;
            // 
            // comboBoxGSworkspaces
            // 
            this.comboBoxGSworkspaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGSworkspaces.FormattingEnabled = true;
            this.comboBoxGSworkspaces.Location = new System.Drawing.Point(230, 184);
            this.comboBoxGSworkspaces.Name = "comboBoxGSworkspaces";
            this.comboBoxGSworkspaces.Size = new System.Drawing.Size(180, 24);
            this.comboBoxGSworkspaces.TabIndex = 5;
            // 
            // buttonGSpublishSLD
            // 
            this.buttonGSpublishSLD.Location = new System.Drawing.Point(284, 245);
            this.buttonGSpublishSLD.Name = "buttonGSpublishSLD";
            this.buttonGSpublishSLD.Size = new System.Drawing.Size(126, 23);
            this.buttonGSpublishSLD.TabIndex = 7;
            this.buttonGSpublishSLD.Text = "Publish SLD";
            this.buttonGSpublishSLD.UseVisualStyleBackColor = true;
            this.buttonGSpublishSLD.Click += new System.EventHandler(this.buttonGSpublishSLD_Click);
            // 
            // labelGSlayers
            // 
            this.labelGSlayers.AutoSize = true;
            this.labelGSlayers.Location = new System.Drawing.Point(75, 298);
            this.labelGSlayers.Name = "labelGSlayers";
            this.labelGSlayers.Size = new System.Drawing.Size(128, 17);
            this.labelGSlayers.TabIndex = 6;
            this.labelGSlayers.Text = "GeoServer Layers:";
            // 
            // comboBoxGSlayers
            // 
            this.comboBoxGSlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGSlayers.FormattingEnabled = true;
            this.comboBoxGSlayers.Location = new System.Drawing.Point(230, 295);
            this.comboBoxGSlayers.Name = "comboBoxGSlayers";
            this.comboBoxGSlayers.Size = new System.Drawing.Size(180, 24);
            this.comboBoxGSlayers.TabIndex = 8;
            // 
            // buttonGSconnect
            // 
            this.buttonGSconnect.Location = new System.Drawing.Point(309, 134);
            this.buttonGSconnect.Name = "buttonGSconnect";
            this.buttonGSconnect.Size = new System.Drawing.Size(101, 23);
            this.buttonGSconnect.TabIndex = 4;
            this.buttonGSconnect.Text = "Connect";
            this.buttonGSconnect.UseVisualStyleBackColor = true;
            this.buttonGSconnect.Click += new System.EventHandler(this.buttonGSconnect_Click);
            // 
            // labelGSpassword
            // 
            this.labelGSpassword.AutoSize = true;
            this.labelGSpassword.Location = new System.Drawing.Point(130, 109);
            this.labelGSpassword.Name = "labelGSpassword";
            this.labelGSpassword.Size = new System.Drawing.Size(73, 17);
            this.labelGSpassword.TabIndex = 3;
            this.labelGSpassword.Text = "Password:";
            // 
            // labelGSusername
            // 
            this.labelGSusername.AutoSize = true;
            this.labelGSusername.Location = new System.Drawing.Point(126, 81);
            this.labelGSusername.Name = "labelGSusername";
            this.labelGSusername.Size = new System.Drawing.Size(77, 17);
            this.labelGSusername.TabIndex = 2;
            this.labelGSusername.Text = "Username:";
            this.labelGSusername.Click += new System.EventHandler(this.labelGSusername_Click);
            // 
            // textBoxGSpassword
            // 
            this.textBoxGSpassword.Location = new System.Drawing.Point(230, 106);
            this.textBoxGSpassword.Name = "textBoxGSpassword";
            this.textBoxGSpassword.Size = new System.Drawing.Size(180, 22);
            this.textBoxGSpassword.TabIndex = 3;
            this.textBoxGSpassword.UseSystemPasswordChar = true;
            // 
            // textBoxGSusername
            // 
            this.textBoxGSusername.Location = new System.Drawing.Point(230, 78);
            this.textBoxGSusername.Name = "textBoxGSusername";
            this.textBoxGSusername.Size = new System.Drawing.Size(180, 22);
            this.textBoxGSusername.TabIndex = 2;
            // 
            // buttonExportSLD
            // 
            this.buttonExportSLD.Location = new System.Drawing.Point(12, 12);
            this.buttonExportSLD.Name = "buttonExportSLD";
            this.buttonExportSLD.Size = new System.Drawing.Size(167, 50);
            this.buttonExportSLD.TabIndex = 0;
            this.buttonExportSLD.Text = "Export SLD as XML";
            this.buttonExportSLD.UseVisualStyleBackColor = true;
            this.buttonExportSLD.Click += new System.EventHandler(this.buttonExportSLD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SLDExporter.SLDExporterResource.gServerLogo;
            this.pictureBox1.Location = new System.Drawing.Point(214, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SLDExporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxPublishSLD);
            this.Controls.Add(this.buttonExportSLD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SLDExporterForm";
            this.Text = "SLDExporter";
            this.Load += new System.EventHandler(this.SLDExporterForm_Load);
            this.groupBoxPublishSLD.ResumeLayout(false);
            this.groupBoxPublishSLD.PerformLayout();
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
        private System.Windows.Forms.Button buttonGSpublishSLD;
        private System.Windows.Forms.Button buttonExportSLD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGSaddStyleToLayer;
        private System.Windows.Forms.Label labelGSstyles;
        private System.Windows.Forms.Label labelGSsldName;
        private System.Windows.Forms.TextBox textBoxGSsldName;
        private System.Windows.Forms.Label labelGSworkspaces;
        private System.Windows.Forms.ComboBox comboBoxGSstyles;
        private System.Windows.Forms.ComboBox comboBoxGSworkspaces;
        private System.Windows.Forms.Label labelGSurl;
        private System.Windows.Forms.TextBox textBoxGSurl;
    }
}