namespace DVLDProject
{
    partial class FindLicenseForRenew
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_Fillter = new System.Windows.Forms.GroupBox();
            this.TB_LicenseID = new System.Windows.Forms.TextBox();
            this.L_LicenseID = new System.Windows.Forms.Label();
            this.UC_DriverLicenseInfo = new DVLDProject.DriverLicneseInfo();
            this.B_Find = new System.Windows.Forms.Button();
            this.GB_Fillter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Fillter
            // 
            this.GB_Fillter.Controls.Add(this.B_Find);
            this.GB_Fillter.Controls.Add(this.TB_LicenseID);
            this.GB_Fillter.Controls.Add(this.L_LicenseID);
            this.GB_Fillter.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Fillter.Location = new System.Drawing.Point(3, 3);
            this.GB_Fillter.Name = "GB_Fillter";
            this.GB_Fillter.Size = new System.Drawing.Size(705, 77);
            this.GB_Fillter.TabIndex = 2;
            this.GB_Fillter.TabStop = false;
            this.GB_Fillter.Text = "Filtter";
            // 
            // TB_LicenseID
            // 
            this.TB_LicenseID.Location = new System.Drawing.Point(158, 38);
            this.TB_LicenseID.Name = "TB_LicenseID";
            this.TB_LicenseID.Size = new System.Drawing.Size(383, 27);
            this.TB_LicenseID.TabIndex = 1;
            this.TB_LicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_LicenseID_KeyPress);
            // 
            // L_LicenseID
            // 
            this.L_LicenseID.AutoSize = true;
            this.L_LicenseID.Location = new System.Drawing.Point(29, 45);
            this.L_LicenseID.Name = "L_LicenseID";
            this.L_LicenseID.Size = new System.Drawing.Size(108, 20);
            this.L_LicenseID.TabIndex = 0;
            this.L_LicenseID.Text = "License ID:";
            // 
            // UC_DriverLicenseInfo
            // 
            this.UC_DriverLicenseInfo.Location = new System.Drawing.Point(3, 86);
            this.UC_DriverLicenseInfo.Name = "UC_DriverLicenseInfo";
            this.UC_DriverLicenseInfo.Size = new System.Drawing.Size(962, 396);
            this.UC_DriverLicenseInfo.TabIndex = 3;
            // 
            // B_Find
            // 
            this.B_Find.BackgroundImage = global::DVLDProject.Properties.Resources.face_scan;
            this.B_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Find.Location = new System.Drawing.Point(596, 21);
            this.B_Find.Name = "B_Find";
            this.B_Find.Size = new System.Drawing.Size(76, 44);
            this.B_Find.TabIndex = 2;
            this.B_Find.UseVisualStyleBackColor = true;
            this.B_Find.Click += new System.EventHandler(this.B_Find_Click);
            // 
            // FindLicenseForRenew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UC_DriverLicenseInfo);
            this.Controls.Add(this.GB_Fillter);
            this.Name = "FindLicenseForRenew";
            this.Size = new System.Drawing.Size(957, 500);
            this.Load += new System.EventHandler(this.FindLicenseForRenew_Load);
            this.GB_Fillter.ResumeLayout(false);
            this.GB_Fillter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Fillter;
        private System.Windows.Forms.Button B_Find;
        private System.Windows.Forms.TextBox TB_LicenseID;
        private System.Windows.Forms.Label L_LicenseID;
        private DriverLicneseInfo UC_DriverLicenseInfo;
    }
}
