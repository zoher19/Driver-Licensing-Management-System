namespace DVLDProject
{
    partial class Frm_InternationalLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InternationalLicenseApplication));
            this.label1 = new System.Windows.Forms.Label();
            this.B_Issue = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.B_Close = new System.Windows.Forms.Button();
            this.LL_ShowIntLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.LL_ShowLicenseHistore = new System.Windows.Forms.LinkLabel();
            this.UC_FindLicense = new DVLDProject.FindLicense();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(220, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "International License Application";
            // 
            // B_Issue
            // 
            this.B_Issue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Issue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Issue.ImageIndex = 1;
            this.B_Issue.ImageList = this.imageList1;
            this.B_Issue.Location = new System.Drawing.Point(1168, 640);
            this.B_Issue.Name = "B_Issue";
            this.B_Issue.Size = new System.Drawing.Size(128, 48);
            this.B_Issue.TabIndex = 2;
            this.B_Issue.Text = "Issue";
            this.B_Issue.UseVisualStyleBackColor = true;
            this.B_Issue.Click += new System.EventHandler(this.B_Issue_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel.png");
            this.imageList1.Images.SetKeyName(1, "globe.png");
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Close.ImageIndex = 0;
            this.B_Close.ImageList = this.imageList1;
            this.B_Close.Location = new System.Drawing.Point(1168, 694);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(128, 48);
            this.B_Close.TabIndex = 3;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // LL_ShowIntLicenseInfo
            // 
            this.LL_ShowIntLicenseInfo.AutoSize = true;
            this.LL_ShowIntLicenseInfo.Enabled = false;
            this.LL_ShowIntLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_ShowIntLicenseInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LL_ShowIntLicenseInfo.Location = new System.Drawing.Point(1075, 269);
            this.LL_ShowIntLicenseInfo.Name = "LL_ShowIntLicenseInfo";
            this.LL_ShowIntLicenseInfo.Size = new System.Drawing.Size(314, 25);
            this.LL_ShowIntLicenseInfo.TabIndex = 4;
            this.LL_ShowIntLicenseInfo.TabStop = true;
            this.LL_ShowIntLicenseInfo.Text = "Show International License Info";
            this.LL_ShowIntLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_ShowIntLicenseInfo_LinkClicked);
            // 
            // LL_ShowLicenseHistore
            // 
            this.LL_ShowLicenseHistore.AutoSize = true;
            this.LL_ShowLicenseHistore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_ShowLicenseHistore.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LL_ShowLicenseHistore.Location = new System.Drawing.Point(1075, 312);
            this.LL_ShowLicenseHistore.Name = "LL_ShowLicenseHistore";
            this.LL_ShowLicenseHistore.Size = new System.Drawing.Size(221, 25);
            this.LL_ShowLicenseHistore.TabIndex = 5;
            this.LL_ShowLicenseHistore.TabStop = true;
            this.LL_ShowLicenseHistore.Text = "Show Licnese Histore";
            this.LL_ShowLicenseHistore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_ShowLicenseHistore_LinkClicked);
            // 
            // UC_FindLicense
            // 
            this.UC_FindLicense.Location = new System.Drawing.Point(12, 38);
            this.UC_FindLicense.Name = "UC_FindLicense";
            this.UC_FindLicense.Size = new System.Drawing.Size(1057, 890);
            this.UC_FindLicense.TabIndex = 6;
            // 
            // Frm_InternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 952);
            this.Controls.Add(this.UC_FindLicense);
            this.Controls.Add(this.LL_ShowLicenseHistore);
            this.Controls.Add(this.LL_ShowIntLicenseInfo);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Issue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_InternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InternationalLicenseApplication";
            this.Load += new System.EventHandler(this.Frm_InternationalLicenseApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Issue;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.LinkLabel LL_ShowIntLicenseInfo;
        private System.Windows.Forms.LinkLabel LL_ShowLicenseHistore;
        private System.Windows.Forms.ImageList imageList1;
        private FindLicense UC_FindLicense;
    }
}