namespace DVLDProject
{
    partial class Frm_Main
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
            this.MS_TaskBar = new System.Windows.Forms.MenuStrip();
            this.TMS_Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_DrivingLecinsesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_NewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_LocalDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_InternalDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_RenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostOrDamagedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_ReleaseLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_RetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_ManageApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_LocalManage = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_InternationalLicenseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_DetainsLecinses = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ManageDetais = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_DetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ReleaseLicense2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_People = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Dirvers = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Users = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_AccountSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_CurrentInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_TaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_TaskBar
            // 
            this.MS_TaskBar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_TaskBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_TaskBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_Applications,
            this.TMS_People,
            this.TMS_Dirvers,
            this.TMS_Users,
            this.TMS_AccountSetting});
            this.MS_TaskBar.Location = new System.Drawing.Point(0, 0);
            this.MS_TaskBar.Name = "MS_TaskBar";
            this.MS_TaskBar.Size = new System.Drawing.Size(1475, 72);
            this.MS_TaskBar.TabIndex = 0;
            this.MS_TaskBar.Text = "TaskBar";
            // 
            // TMS_Applications
            // 
            this.TMS_Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_DrivingLecinsesServices,
            this.toolStripSeparator2,
            this.TMS_ManageApplication,
            this.toolStripSeparator3,
            this.TMS_DetainsLecinses,
            this.TMS_ManageApplicationTypes,
            this.TMS_ManageTestTypes});
            this.TMS_Applications.Image = global::DVLDProject.Properties.Resources.menu__1_;
            this.TMS_Applications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Applications.Name = "TMS_Applications";
            this.TMS_Applications.Size = new System.Drawing.Size(220, 68);
            this.TMS_Applications.Text = "Applicatoins";
            this.TMS_Applications.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // TMS_DrivingLecinsesServices
            // 
            this.TMS_DrivingLecinsesServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_NewDrivingLicense,
            this.TMS_RenewDrivingLicense,
            this.replacementForLostOrDamagedLicenseToolStripMenuItem,
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1,
            this.releaseDetainedDrivingLicenseToolStripMenuItem,
            this.TMS_ReleaseLicense,
            this.TMS_RetakeTest});
            this.TMS_DrivingLecinsesServices.Image = global::DVLDProject.Properties.Resources.driving_licence;
            this.TMS_DrivingLecinsesServices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_DrivingLecinsesServices.Name = "TMS_DrivingLecinsesServices";
            this.TMS_DrivingLecinsesServices.Size = new System.Drawing.Size(381, 38);
            this.TMS_DrivingLecinsesServices.Text = "Driving Licenses Services";
            // 
            // TMS_NewDrivingLicense
            // 
            this.TMS_NewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_LocalDrivingLicense,
            this.TMS_InternalDrivingLicense});
            this.TMS_NewDrivingLicense.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_NewDrivingLicense.Image = global::DVLDProject.Properties.Resources.driving_license__1_;
            this.TMS_NewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_NewDrivingLicense.Name = "TMS_NewDrivingLicense";
            this.TMS_NewDrivingLicense.Size = new System.Drawing.Size(535, 38);
            this.TMS_NewDrivingLicense.Text = "New Driving License";
            this.TMS_NewDrivingLicense.Click += new System.EventHandler(this.TMS_NewDrivingLicense_Click);
            // 
            // TMS_LocalDrivingLicense
            // 
            this.TMS_LocalDrivingLicense.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_LocalDrivingLicense.Image = global::DVLDProject.Properties.Resources.local_business;
            this.TMS_LocalDrivingLicense.Name = "TMS_LocalDrivingLicense";
            this.TMS_LocalDrivingLicense.Size = new System.Drawing.Size(309, 26);
            this.TMS_LocalDrivingLicense.Text = "Local Driving License";
            this.TMS_LocalDrivingLicense.Click += new System.EventHandler(this.TMS_LocalDrivingLicense_Click);
            // 
            // TMS_InternalDrivingLicense
            // 
            this.TMS_InternalDrivingLicense.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_InternalDrivingLicense.Image = global::DVLDProject.Properties.Resources.interne;
            this.TMS_InternalDrivingLicense.Name = "TMS_InternalDrivingLicense";
            this.TMS_InternalDrivingLicense.Size = new System.Drawing.Size(309, 26);
            this.TMS_InternalDrivingLicense.Text = "Internal Driving License";
            this.TMS_InternalDrivingLicense.Click += new System.EventHandler(this.TMS_InternalDrivingLicense_Click);
            // 
            // TMS_RenewDrivingLicense
            // 
            this.TMS_RenewDrivingLicense.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_RenewDrivingLicense.Image = global::DVLDProject.Properties.Resources.renewal;
            this.TMS_RenewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_RenewDrivingLicense.Name = "TMS_RenewDrivingLicense";
            this.TMS_RenewDrivingLicense.Size = new System.Drawing.Size(535, 38);
            this.TMS_RenewDrivingLicense.Text = "Renew Driving License";
            this.TMS_RenewDrivingLicense.Click += new System.EventHandler(this.TMS_RenewDrivingLicense_Click);
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new System.Drawing.Size(532, 6);
            this.replacementForLostOrDamagedLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamagedLicenseToolStripMenuItem_Click);
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem1
            // 
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1.Image = global::DVLDProject.Properties.Resources.swap;
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem1";
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1.Size = new System.Drawing.Size(535, 38);
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1.Text = "Replacement for lost or Damaged license";
            this.replacementForLostOrDamagedLicenseToolStripMenuItem1.Click += new System.EventHandler(this.replacementForLostOrDamagedLicenseToolStripMenuItem1_Click);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(532, 6);
            // 
            // TMS_ReleaseLicense
            // 
            this.TMS_ReleaseLicense.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_ReleaseLicense.Image = global::DVLDProject.Properties.Resources.journalist;
            this.TMS_ReleaseLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ReleaseLicense.Name = "TMS_ReleaseLicense";
            this.TMS_ReleaseLicense.Size = new System.Drawing.Size(535, 38);
            this.TMS_ReleaseLicense.Text = "Release Detained Driving license ";
            this.TMS_ReleaseLicense.Click += new System.EventHandler(this.TMS_ReleaseLicense_Click_1);
            // 
            // TMS_RetakeTest
            // 
            this.TMS_RetakeTest.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_RetakeTest.Image = global::DVLDProject.Properties.Resources.test;
            this.TMS_RetakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_RetakeTest.Name = "TMS_RetakeTest";
            this.TMS_RetakeTest.Size = new System.Drawing.Size(535, 38);
            this.TMS_RetakeTest.Text = "Retake Test";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(378, 6);
            // 
            // TMS_ManageApplication
            // 
            this.TMS_ManageApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_LocalManage,
            this.TMS_InternationalLicenseManage});
            this.TMS_ManageApplication.Image = global::DVLDProject.Properties.Resources.resume;
            this.TMS_ManageApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ManageApplication.Name = "TMS_ManageApplication";
            this.TMS_ManageApplication.Size = new System.Drawing.Size(381, 38);
            this.TMS_ManageApplication.Text = "Manage Applications";
            // 
            // TMS_LocalManage
            // 
            this.TMS_LocalManage.Image = global::DVLDProject.Properties.Resources.local_business;
            this.TMS_LocalManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_LocalManage.Name = "TMS_LocalManage";
            this.TMS_LocalManage.Size = new System.Drawing.Size(414, 38);
            this.TMS_LocalManage.Text = "Local Driving License Manage";
            this.TMS_LocalManage.Click += new System.EventHandler(this.TMS_LocalManage_Click);
            // 
            // TMS_InternationalLicenseManage
            // 
            this.TMS_InternationalLicenseManage.Image = global::DVLDProject.Properties.Resources.interne;
            this.TMS_InternationalLicenseManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_InternationalLicenseManage.Name = "TMS_InternationalLicenseManage";
            this.TMS_InternationalLicenseManage.Size = new System.Drawing.Size(414, 38);
            this.TMS_InternationalLicenseManage.Text = "International Licnese Manage";
            this.TMS_InternationalLicenseManage.Click += new System.EventHandler(this.TMS_InternationalLicenseManage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(378, 6);
            // 
            // TMS_DetainsLecinses
            // 
            this.TMS_DetainsLecinses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_ManageDetais,
            this.TMS_DetainLicense,
            this.TMS_ReleaseLicense2});
            this.TMS_DetainsLecinses.Image = global::DVLDProject.Properties.Resources.insurance;
            this.TMS_DetainsLecinses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_DetainsLecinses.Name = "TMS_DetainsLecinses";
            this.TMS_DetainsLecinses.Size = new System.Drawing.Size(381, 38);
            this.TMS_DetainsLecinses.Text = "Detains Lecinses";
            this.TMS_DetainsLecinses.Click += new System.EventHandler(this.TMS_DetainsLecinses_Click);
            // 
            // TMS_ManageDetais
            // 
            this.TMS_ManageDetais.Image = global::DVLDProject.Properties.Resources.detail1;
            this.TMS_ManageDetais.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ManageDetais.Name = "TMS_ManageDetais";
            this.TMS_ManageDetais.Size = new System.Drawing.Size(271, 38);
            this.TMS_ManageDetais.Text = "Manage Detains";
            this.TMS_ManageDetais.Click += new System.EventHandler(this.TMS_ManageDetais_Click);
            // 
            // TMS_DetainLicense
            // 
            this.TMS_DetainLicense.Image = global::DVLDProject.Properties.Resources.driving_license__4_1;
            this.TMS_DetainLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_DetainLicense.Name = "TMS_DetainLicense";
            this.TMS_DetainLicense.Size = new System.Drawing.Size(271, 38);
            this.TMS_DetainLicense.Text = "Detain License";
            this.TMS_DetainLicense.Click += new System.EventHandler(this.TMS_DetainLicense_Click);
            // 
            // TMS_ReleaseLicense2
            // 
            this.TMS_ReleaseLicense2.Image = global::DVLDProject.Properties.Resources.press_release1;
            this.TMS_ReleaseLicense2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ReleaseLicense2.Name = "TMS_ReleaseLicense2";
            this.TMS_ReleaseLicense2.Size = new System.Drawing.Size(271, 38);
            this.TMS_ReleaseLicense2.Text = "Release License";
            this.TMS_ReleaseLicense2.Click += new System.EventHandler(this.TMS_ReleaseLicense2_Click);
            // 
            // TMS_ManageApplicationTypes
            // 
            this.TMS_ManageApplicationTypes.Image = global::DVLDProject.Properties.Resources.job;
            this.TMS_ManageApplicationTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ManageApplicationTypes.Name = "TMS_ManageApplicationTypes";
            this.TMS_ManageApplicationTypes.Size = new System.Drawing.Size(381, 38);
            this.TMS_ManageApplicationTypes.Text = "Manage Application Types";
            this.TMS_ManageApplicationTypes.Click += new System.EventHandler(this.TMS_ManageApplicationTypes_Click);
            // 
            // TMS_ManageTestTypes
            // 
            this.TMS_ManageTestTypes.Image = global::DVLDProject.Properties.Resources.job_application__1_1;
            this.TMS_ManageTestTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ManageTestTypes.Name = "TMS_ManageTestTypes";
            this.TMS_ManageTestTypes.Size = new System.Drawing.Size(381, 38);
            this.TMS_ManageTestTypes.Text = "Manage Test Types";
            this.TMS_ManageTestTypes.Click += new System.EventHandler(this.TMS_ManageTestTypes_Click);
            // 
            // TMS_People
            // 
            this.TMS_People.Image = global::DVLDProject.Properties.Resources.group__2_;
            this.TMS_People.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_People.Name = "TMS_People";
            this.TMS_People.Size = new System.Drawing.Size(154, 68);
            this.TMS_People.Text = "People";
            this.TMS_People.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // TMS_Dirvers
            // 
            this.TMS_Dirvers.Image = global::DVLDProject.Properties.Resources.people;
            this.TMS_Dirvers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Dirvers.Name = "TMS_Dirvers";
            this.TMS_Dirvers.Size = new System.Drawing.Size(165, 68);
            this.TMS_Dirvers.Text = "Drivers";
            this.TMS_Dirvers.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // TMS_Users
            // 
            this.TMS_Users.Image = global::DVLDProject.Properties.Resources.laptop;
            this.TMS_Users.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Users.Name = "TMS_Users";
            this.TMS_Users.Size = new System.Drawing.Size(143, 68);
            this.TMS_Users.Text = "Users";
            this.TMS_Users.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // TMS_AccountSetting
            // 
            this.TMS_AccountSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_CurrentInfo,
            this.TMS_ChangePassword,
            this.toolStripSeparator1,
            this.TMS_SignOut});
            this.TMS_AccountSetting.Image = global::DVLDProject.Properties.Resources.user__1_;
            this.TMS_AccountSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_AccountSetting.Name = "TMS_AccountSetting";
            this.TMS_AccountSetting.Size = new System.Drawing.Size(253, 68);
            this.TMS_AccountSetting.Text = "Account Setting";
            // 
            // TMS_CurrentInfo
            // 
            this.TMS_CurrentInfo.Image = global::DVLDProject.Properties.Resources.contact;
            this.TMS_CurrentInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_CurrentInfo.Name = "TMS_CurrentInfo";
            this.TMS_CurrentInfo.Size = new System.Drawing.Size(271, 38);
            this.TMS_CurrentInfo.Text = "Current Info";
            this.TMS_CurrentInfo.Click += new System.EventHandler(this.TMS_CurrentInfo_Click);
            // 
            // TMS_ChangePassword
            // 
            this.TMS_ChangePassword.Image = global::DVLDProject.Properties.Resources.reset_password__1_;
            this.TMS_ChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ChangePassword.Name = "TMS_ChangePassword";
            this.TMS_ChangePassword.Size = new System.Drawing.Size(271, 38);
            this.TMS_ChangePassword.Text = "Change Password";
            this.TMS_ChangePassword.Click += new System.EventHandler(this.TMS_ChangePassword_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // TMS_SignOut
            // 
            this.TMS_SignOut.Image = global::DVLDProject.Properties.Resources.logout;
            this.TMS_SignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_SignOut.Name = "TMS_SignOut";
            this.TMS_SignOut.Size = new System.Drawing.Size(271, 38);
            this.TMS_SignOut.Text = "Sign Out";
            this.TMS_SignOut.Click += new System.EventHandler(this.TMS_SignOut_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1475, 743);
            this.Controls.Add(this.MS_TaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MS_TaskBar;
            this.Name = "Frm_Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.MS_TaskBar.ResumeLayout(false);
            this.MS_TaskBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_TaskBar;
        private System.Windows.Forms.ToolStripMenuItem TMS_Applications;
        private System.Windows.Forms.ToolStripMenuItem TMS_People;
        private System.Windows.Forms.ToolStripMenuItem TMS_Dirvers;
        private System.Windows.Forms.ToolStripMenuItem TMS_Users;
        private System.Windows.Forms.ToolStripMenuItem TMS_AccountSetting;
        private System.Windows.Forms.ToolStripMenuItem TMS_CurrentInfo;
        private System.Windows.Forms.ToolStripMenuItem TMS_ChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TMS_SignOut;
        private System.Windows.Forms.ToolStripMenuItem TMS_DrivingLecinsesServices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TMS_ManageApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TMS_DetainsLecinses;
        private System.Windows.Forms.ToolStripMenuItem TMS_ManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem TMS_ManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem TMS_NewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem TMS_LocalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem TMS_InternalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem TMS_RenewDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator replacementForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator releaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TMS_ReleaseLicense;
        private System.Windows.Forms.ToolStripMenuItem TMS_RetakeTest;
        private System.Windows.Forms.ToolStripMenuItem TMS_LocalManage;
        private System.Windows.Forms.ToolStripMenuItem TMS_InternationalLicenseManage;
        private System.Windows.Forms.ToolStripMenuItem TMS_ManageDetais;
        private System.Windows.Forms.ToolStripMenuItem TMS_DetainLicense;
        private System.Windows.Forms.ToolStripMenuItem TMS_ReleaseLicense2;
    }
}