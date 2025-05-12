namespace DVLDProject
{
    partial class FrmLocalDrivingApplicationManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalDrivingApplicationManage));
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Applications = new System.Windows.Forms.DataGridView();
            this.C_AppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_DrivingClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PasedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_ProccessOnLocalDrivingLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.L_RecordsN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_FillterBy = new System.Windows.Forms.ComboBox();
            this.TB_FillterBy = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CB_Status = new System.Windows.Forms.ComboBox();
            this.Close = new System.Windows.Forms.Button();
            this.B_AddNewLocalApplication = new System.Windows.Forms.Button();
            this.TMS_ShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_EditAplication = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_DeleteApp = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_CancelApp = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_SchdueTests = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_VisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_WrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_StreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_IssueDrivingLicenseFT = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ShowPersonLicenseHistore = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Applications)).BeginInit();
            this.CMS_ProccessOnLocalDrivingLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(363, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Driving License Application";
            // 
            // DGV_Applications
            // 
            this.DGV_Applications.AllowUserToAddRows = false;
            this.DGV_Applications.AllowUserToDeleteRows = false;
            this.DGV_Applications.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Applications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Applications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_AppID,
            this.C_DrivingClass,
            this.C_NationalNo,
            this.C_FullName,
            this.C_ApplicationDate,
            this.C_PasedTests,
            this.C_Status});
            this.DGV_Applications.ContextMenuStrip = this.CMS_ProccessOnLocalDrivingLicense;
            this.DGV_Applications.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_Applications.Location = new System.Drawing.Point(-3, 347);
            this.DGV_Applications.MultiSelect = false;
            this.DGV_Applications.Name = "DGV_Applications";
            this.DGV_Applications.ReadOnly = true;
            this.DGV_Applications.RowHeadersWidth = 51;
            this.DGV_Applications.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Applications.RowTemplate.Height = 24;
            this.DGV_Applications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Applications.Size = new System.Drawing.Size(1700, 391);
            this.DGV_Applications.TabIndex = 2;
            // 
            // C_AppID
            // 
            this.C_AppID.HeaderText = "L_D_LAppID";
            this.C_AppID.MinimumWidth = 6;
            this.C_AppID.Name = "C_AppID";
            this.C_AppID.ReadOnly = true;
            this.C_AppID.Width = 125;
            // 
            // C_DrivingClass
            // 
            this.C_DrivingClass.HeaderText = "Driving Class";
            this.C_DrivingClass.MinimumWidth = 6;
            this.C_DrivingClass.Name = "C_DrivingClass";
            this.C_DrivingClass.ReadOnly = true;
            this.C_DrivingClass.Width = 275;
            // 
            // C_NationalNo
            // 
            this.C_NationalNo.HeaderText = "National No";
            this.C_NationalNo.MinimumWidth = 6;
            this.C_NationalNo.Name = "C_NationalNo";
            this.C_NationalNo.ReadOnly = true;
            this.C_NationalNo.Width = 125;
            // 
            // C_FullName
            // 
            this.C_FullName.HeaderText = "Full Name";
            this.C_FullName.MinimumWidth = 6;
            this.C_FullName.Name = "C_FullName";
            this.C_FullName.ReadOnly = true;
            this.C_FullName.Width = 250;
            // 
            // C_ApplicationDate
            // 
            this.C_ApplicationDate.HeaderText = "Application Date";
            this.C_ApplicationDate.MinimumWidth = 6;
            this.C_ApplicationDate.Name = "C_ApplicationDate";
            this.C_ApplicationDate.ReadOnly = true;
            this.C_ApplicationDate.Width = 125;
            // 
            // C_PasedTests
            // 
            this.C_PasedTests.HeaderText = "Pased Test";
            this.C_PasedTests.MinimumWidth = 6;
            this.C_PasedTests.Name = "C_PasedTests";
            this.C_PasedTests.ReadOnly = true;
            this.C_PasedTests.Width = 125;
            // 
            // C_Status
            // 
            this.C_Status.HeaderText = "Status";
            this.C_Status.MinimumWidth = 6;
            this.C_Status.Name = "C_Status";
            this.C_Status.ReadOnly = true;
            this.C_Status.Width = 125;
            // 
            // CMS_ProccessOnLocalDrivingLicense
            // 
            this.CMS_ProccessOnLocalDrivingLicense.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMS_ProccessOnLocalDrivingLicense.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_ProccessOnLocalDrivingLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_ShowApplicationDetails,
            this.toolStripMenuItem1,
            this.TMS_EditAplication,
            this.TMS_DeleteApp,
            this.toolStripMenuItem2,
            this.TMS_CancelApp,
            this.toolStripMenuItem3,
            this.TMS_SchdueTests,
            this.toolStripMenuItem4,
            this.TMS_IssueDrivingLicenseFT,
            this.toolStripMenuItem5,
            this.TMS_ShowLicense,
            this.toolStripMenuItem6,
            this.TMS_ShowPersonLicenseHistore,
            this.toolStripMenuItem8});
            this.CMS_ProccessOnLocalDrivingLicense.Name = "contextMenuStrip1";
            this.CMS_ProccessOnLocalDrivingLicense.Size = new System.Drawing.Size(471, 410);
            this.CMS_ProccessOnLocalDrivingLicense.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ProccessOnLocalDrivingLicense_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(467, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(467, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(467, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(467, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(467, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(467, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(470, 38);
            this.toolStripMenuItem8.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 742);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Records :";
            // 
            // L_RecordsN
            // 
            this.L_RecordsN.AutoSize = true;
            this.L_RecordsN.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_RecordsN.Location = new System.Drawing.Point(118, 742);
            this.L_RecordsN.Name = "L_RecordsN";
            this.L_RecordsN.Size = new System.Drawing.Size(30, 22);
            this.L_RecordsN.TabIndex = 4;
            this.L_RecordsN.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fillter By :";
            // 
            // CB_FillterBy
            // 
            this.CB_FillterBy.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CB_FillterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FillterBy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FillterBy.ForeColor = System.Drawing.Color.Black;
            this.CB_FillterBy.FormattingEnabled = true;
            this.CB_FillterBy.Items.AddRange(new object[] {
            "None",
            "L_V_LAppID",
            "NationalNo",
            "Driving Class",
            "Pased Tests",
            "Status"});
            this.CB_FillterBy.Location = new System.Drawing.Point(163, 311);
            this.CB_FillterBy.Name = "CB_FillterBy";
            this.CB_FillterBy.Size = new System.Drawing.Size(264, 31);
            this.CB_FillterBy.TabIndex = 7;
            this.CB_FillterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FillterBy_SelectedIndexChanged);
            // 
            // TB_FillterBy
            // 
            this.TB_FillterBy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FillterBy.Location = new System.Drawing.Point(445, 311);
            this.TB_FillterBy.Name = "TB_FillterBy";
            this.TB_FillterBy.Size = new System.Drawing.Size(281, 31);
            this.TB_FillterBy.TabIndex = 8;
            this.TB_FillterBy.Visible = false;
            this.TB_FillterBy.TextChanged += new System.EventHandler(this.TB_FillterBy_TextChanged);
            this.TB_FillterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_FillterBy_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            // 
            // CB_Status
            // 
            this.CB_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Status.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Status.FormattingEnabled = true;
            this.CB_Status.Items.AddRange(new object[] {
            "None",
            "New",
            "Completed",
            "Cancel"});
            this.CB_Status.Location = new System.Drawing.Point(473, 315);
            this.CB_Status.Name = "CB_Status";
            this.CB_Status.Size = new System.Drawing.Size(134, 26);
            this.CB_Status.TabIndex = 10;
            this.CB_Status.Visible = false;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.ImageIndex = 0;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(1357, 742);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(179, 38);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // B_AddNewLocalApplication
            // 
            this.B_AddNewLocalApplication.BackgroundImage = global::DVLDProject.Properties.Resources.application;
            this.B_AddNewLocalApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_AddNewLocalApplication.ContextMenuStrip = this.CMS_ProccessOnLocalDrivingLicense;
            this.B_AddNewLocalApplication.Location = new System.Drawing.Point(1454, 273);
            this.B_AddNewLocalApplication.Name = "B_AddNewLocalApplication";
            this.B_AddNewLocalApplication.Size = new System.Drawing.Size(70, 69);
            this.B_AddNewLocalApplication.TabIndex = 5;
            this.B_AddNewLocalApplication.UseVisualStyleBackColor = true;
            this.B_AddNewLocalApplication.Click += new System.EventHandler(this.B_AddNewLocalApplication_Click);
            // 
            // TMS_ShowApplicationDetails
            // 
            this.TMS_ShowApplicationDetails.Image = global::DVLDProject.Properties.Resources.info;
            this.TMS_ShowApplicationDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowApplicationDetails.Name = "TMS_ShowApplicationDetails";
            this.TMS_ShowApplicationDetails.Size = new System.Drawing.Size(470, 38);
            this.TMS_ShowApplicationDetails.Text = "Show Application Details";
            this.TMS_ShowApplicationDetails.Click += new System.EventHandler(this.TMS_ShowApplicationDetails_Click);
            // 
            // TMS_EditAplication
            // 
            this.TMS_EditAplication.Image = global::DVLDProject.Properties.Resources.write;
            this.TMS_EditAplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_EditAplication.Name = "TMS_EditAplication";
            this.TMS_EditAplication.Size = new System.Drawing.Size(470, 38);
            this.TMS_EditAplication.Text = "Edit Aplication";
            // 
            // TMS_DeleteApp
            // 
            this.TMS_DeleteApp.Image = global::DVLDProject.Properties.Resources.file;
            this.TMS_DeleteApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_DeleteApp.Name = "TMS_DeleteApp";
            this.TMS_DeleteApp.Size = new System.Drawing.Size(470, 38);
            this.TMS_DeleteApp.Text = "Delete Application";
            this.TMS_DeleteApp.Click += new System.EventHandler(this.TMS_DeleteApp_Click);
            // 
            // TMS_CancelApp
            // 
            this.TMS_CancelApp.Image = global::DVLDProject.Properties.Resources.wrong;
            this.TMS_CancelApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_CancelApp.Name = "TMS_CancelApp";
            this.TMS_CancelApp.Size = new System.Drawing.Size(470, 38);
            this.TMS_CancelApp.Text = "Cancel Application";
            this.TMS_CancelApp.Click += new System.EventHandler(this.TMS_CancelApp_Click);
            // 
            // TMS_SchdueTests
            // 
            this.TMS_SchdueTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_VisionTest,
            this.TMS_WrittenTest,
            this.TMS_StreetTest});
            this.TMS_SchdueTests.Image = global::DVLDProject.Properties.Resources.test__2_;
            this.TMS_SchdueTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_SchdueTests.Name = "TMS_SchdueTests";
            this.TMS_SchdueTests.ShowShortcutKeys = false;
            this.TMS_SchdueTests.Size = new System.Drawing.Size(470, 38);
            this.TMS_SchdueTests.Text = "Schdule Tests";
            this.TMS_SchdueTests.Click += new System.EventHandler(this.TMS_SchdueTests_Click);
            // 
            // TMS_VisionTest
            // 
            this.TMS_VisionTest.Image = global::DVLDProject.Properties.Resources.vision1;
            this.TMS_VisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_VisionTest.Name = "TMS_VisionTest";
            this.TMS_VisionTest.Size = new System.Drawing.Size(238, 38);
            this.TMS_VisionTest.Text = "Vision Test";
            this.TMS_VisionTest.Click += new System.EventHandler(this.TMS_VisionTest_Click);
            // 
            // TMS_WrittenTest
            // 
            this.TMS_WrittenTest.Enabled = false;
            this.TMS_WrittenTest.Image = global::DVLDProject.Properties.Resources.writing1;
            this.TMS_WrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_WrittenTest.Name = "TMS_WrittenTest";
            this.TMS_WrittenTest.Size = new System.Drawing.Size(238, 38);
            this.TMS_WrittenTest.Text = "Written test";
            this.TMS_WrittenTest.Click += new System.EventHandler(this.TMS_WrittenTest_Click);
            // 
            // TMS_StreetTest
            // 
            this.TMS_StreetTest.Enabled = false;
            this.TMS_StreetTest.Image = global::DVLDProject.Properties.Resources.drive1;
            this.TMS_StreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_StreetTest.Name = "TMS_StreetTest";
            this.TMS_StreetTest.Size = new System.Drawing.Size(238, 38);
            this.TMS_StreetTest.Text = "Street Text";
            this.TMS_StreetTest.Click += new System.EventHandler(this.TMS_StreetTest_Click);
            // 
            // TMS_IssueDrivingLicenseFT
            // 
            this.TMS_IssueDrivingLicenseFT.Enabled = false;
            this.TMS_IssueDrivingLicenseFT.Image = global::DVLDProject.Properties.Resources.driving_license__2_;
            this.TMS_IssueDrivingLicenseFT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_IssueDrivingLicenseFT.Name = "TMS_IssueDrivingLicenseFT";
            this.TMS_IssueDrivingLicenseFT.Size = new System.Drawing.Size(470, 38);
            this.TMS_IssueDrivingLicenseFT.Text = "Issue Driving License (first Time)";
            this.TMS_IssueDrivingLicenseFT.Click += new System.EventHandler(this.TMS_IssueDrivingLicenseFT_Click);
            // 
            // TMS_ShowLicense
            // 
            this.TMS_ShowLicense.Enabled = false;
            this.TMS_ShowLicense.Image = global::DVLDProject.Properties.Resources.driving_license__3_;
            this.TMS_ShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowLicense.Name = "TMS_ShowLicense";
            this.TMS_ShowLicense.Size = new System.Drawing.Size(470, 38);
            this.TMS_ShowLicense.Text = "Show License";
            this.TMS_ShowLicense.Click += new System.EventHandler(this.TMS_ShowLicense_Click);
            // 
            // TMS_ShowPersonLicenseHistore
            // 
            this.TMS_ShowPersonLicenseHistore.Image = global::DVLDProject.Properties.Resources.task;
            this.TMS_ShowPersonLicenseHistore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowPersonLicenseHistore.Name = "TMS_ShowPersonLicenseHistore";
            this.TMS_ShowPersonLicenseHistore.Size = new System.Drawing.Size(470, 38);
            this.TMS_ShowPersonLicenseHistore.Text = "Show Person License Histore";
            this.TMS_ShowPersonLicenseHistore.Click += new System.EventHandler(this.TMS_ShowPersonLicenseHistore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.test__1_;
            this.pictureBox1.Location = new System.Drawing.Point(646, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLocalDrivingApplicationManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 782);
            this.Controls.Add(this.CB_Status);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TB_FillterBy);
            this.Controls.Add(this.CB_FillterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_AddNewLocalApplication);
            this.Controls.Add(this.L_RecordsN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Applications);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmLocalDrivingApplicationManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLocalDrivingApplicationManage";
            this.Load += new System.EventHandler(this.FrmLocalDrivingApplicationManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Applications)).EndInit();
            this.CMS_ProccessOnLocalDrivingLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGV_Applications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_RecordsN;
        private System.Windows.Forms.Button B_AddNewLocalApplication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_FillterBy;
        private System.Windows.Forms.TextBox TB_FillterBy;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ContextMenuStrip CMS_ProccessOnLocalDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TMS_EditAplication;
        private System.Windows.Forms.ToolStripMenuItem TMS_DeleteApp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TMS_CancelApp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TMS_SchdueTests;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem TMS_IssueDrivingLicenseFT;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowPersonLicenseHistore;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox CB_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DrivingClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PasedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Status;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem TMS_VisionTest;
        private System.Windows.Forms.ToolStripMenuItem TMS_WrittenTest;
        private System.Windows.Forms.ToolStripMenuItem TMS_StreetTest;
    }
}