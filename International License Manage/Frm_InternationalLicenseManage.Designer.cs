namespace DVLDProject
{
    partial class Frm_InternationalLicenseManage
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
            this.DGV_IntLicenses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Recourds = new System.Windows.Forms.Label();
            this.C_IntLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_AppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_LocalLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.B_AddIntLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TMS_ShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ShowLicenseHistore = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_IntLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_IntLicenses
            // 
            this.DGV_IntLicenses.AllowUserToAddRows = false;
            this.DGV_IntLicenses.AllowUserToDeleteRows = false;
            this.DGV_IntLicenses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_IntLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_IntLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_IntLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_IntLicense,
            this.C_AppID,
            this.C_DriverID,
            this.C_LocalLicenseID,
            this.C_IssueDate,
            this.C_ExpirationDate,
            this.C_IsActive});
            this.DGV_IntLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_IntLicenses.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_IntLicenses.Location = new System.Drawing.Point(3, 247);
            this.DGV_IntLicenses.MultiSelect = false;
            this.DGV_IntLicenses.Name = "DGV_IntLicenses";
            this.DGV_IntLicenses.ReadOnly = true;
            this.DGV_IntLicenses.RowHeadersWidth = 51;
            this.DGV_IntLicenses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_IntLicenses.RowTemplate.Height = 24;
            this.DGV_IntLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_IntLicenses.Size = new System.Drawing.Size(1386, 388);
            this.DGV_IntLicenses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "International Licneses Manage";
            // 
            // B_Close
            // 
            this.B_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.Location = new System.Drawing.Point(1144, 652);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(234, 41);
            this.B_Close.TabIndex = 4;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rcourds :";
            // 
            // L_Recourds
            // 
            this.L_Recourds.AutoSize = true;
            this.L_Recourds.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Recourds.Location = new System.Drawing.Point(127, 652);
            this.L_Recourds.Name = "L_Recourds";
            this.L_Recourds.Size = new System.Drawing.Size(32, 23);
            this.L_Recourds.TabIndex = 6;
            this.L_Recourds.Text = "##";
            // 
            // C_IntLicense
            // 
            this.C_IntLicense.HeaderText = "Int.Licnese";
            this.C_IntLicense.MinimumWidth = 6;
            this.C_IntLicense.Name = "C_IntLicense";
            this.C_IntLicense.ReadOnly = true;
            this.C_IntLicense.Width = 125;
            // 
            // C_AppID
            // 
            this.C_AppID.HeaderText = "ApplicationID";
            this.C_AppID.MinimumWidth = 6;
            this.C_AppID.Name = "C_AppID";
            this.C_AppID.ReadOnly = true;
            this.C_AppID.Width = 125;
            // 
            // C_DriverID
            // 
            this.C_DriverID.HeaderText = "DriverID";
            this.C_DriverID.MinimumWidth = 6;
            this.C_DriverID.Name = "C_DriverID";
            this.C_DriverID.ReadOnly = true;
            this.C_DriverID.Width = 125;
            // 
            // C_LocalLicenseID
            // 
            this.C_LocalLicenseID.HeaderText = "Local LicenseID";
            this.C_LocalLicenseID.MinimumWidth = 6;
            this.C_LocalLicenseID.Name = "C_LocalLicenseID";
            this.C_LocalLicenseID.ReadOnly = true;
            this.C_LocalLicenseID.Width = 150;
            // 
            // C_IssueDate
            // 
            this.C_IssueDate.HeaderText = "Issue Date";
            this.C_IssueDate.MinimumWidth = 6;
            this.C_IssueDate.Name = "C_IssueDate";
            this.C_IssueDate.ReadOnly = true;
            this.C_IssueDate.Width = 175;
            // 
            // C_ExpirationDate
            // 
            this.C_ExpirationDate.HeaderText = "Expiration Date";
            this.C_ExpirationDate.MinimumWidth = 6;
            this.C_ExpirationDate.Name = "C_ExpirationDate";
            this.C_ExpirationDate.ReadOnly = true;
            this.C_ExpirationDate.Width = 175;
            // 
            // C_IsActive
            // 
            this.C_IsActive.HeaderText = "IsActive";
            this.C_IsActive.MinimumWidth = 6;
            this.C_IsActive.Name = "C_IsActive";
            this.C_IsActive.ReadOnly = true;
            this.C_IsActive.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_ShowPersonDetails,
            this.TMS_ShowLicenseDetails,
            this.TMS_ShowLicenseHistore});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(284, 118);
            // 
            // B_AddIntLicense
            // 
            this.B_AddIntLicense.BackgroundImage = global::DVLDProject.Properties.Resources.license__1_4;
            this.B_AddIntLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_AddIntLicense.Location = new System.Drawing.Point(1302, 178);
            this.B_AddIntLicense.Name = "B_AddIntLicense";
            this.B_AddIntLicense.Size = new System.Drawing.Size(76, 63);
            this.B_AddIntLicense.TabIndex = 3;
            this.B_AddIntLicense.UseVisualStyleBackColor = true;
            this.B_AddIntLicense.Click += new System.EventHandler(this.B_AddIntLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDProject.Properties.Resources.earth1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(577, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 139);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TMS_ShowPersonDetails
            // 
            this.TMS_ShowPersonDetails.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_ShowPersonDetails.Image = global::DVLDProject.Properties.Resources.personal_data;
            this.TMS_ShowPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowPersonDetails.Name = "TMS_ShowPersonDetails";
            this.TMS_ShowPersonDetails.Size = new System.Drawing.Size(283, 38);
            this.TMS_ShowPersonDetails.Text = "Show Person Details";
            this.TMS_ShowPersonDetails.Click += new System.EventHandler(this.TMS_ShowPersonDetails_Click);
            // 
            // TMS_ShowLicenseDetails
            // 
            this.TMS_ShowLicenseDetails.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_ShowLicenseDetails.Image = global::DVLDProject.Properties.Resources.business_card;
            this.TMS_ShowLicenseDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TMS_ShowLicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowLicenseDetails.Name = "TMS_ShowLicenseDetails";
            this.TMS_ShowLicenseDetails.Size = new System.Drawing.Size(283, 38);
            this.TMS_ShowLicenseDetails.Text = "Show License Details";
            this.TMS_ShowLicenseDetails.Click += new System.EventHandler(this.TMS_ShowLicenseDetails_Click);
            // 
            // TMS_ShowLicenseHistore
            // 
            this.TMS_ShowLicenseHistore.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_ShowLicenseHistore.Image = global::DVLDProject.Properties.Resources.driving_license__3_1;
            this.TMS_ShowLicenseHistore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowLicenseHistore.Name = "TMS_ShowLicenseHistore";
            this.TMS_ShowLicenseHistore.Size = new System.Drawing.Size(283, 38);
            this.TMS_ShowLicenseHistore.Text = "Show Licenses Histore";
            this.TMS_ShowLicenseHistore.Click += new System.EventHandler(this.TMS_ShowLicenseHistore_Click);
            // 
            // Frm_InternationalLicenseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 718);
            this.Controls.Add(this.L_Recourds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_AddIntLicense);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_IntLicenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_InternationalLicenseManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InternationalLicenseManage";
            this.Load += new System.EventHandler(this.Frm_InternationalLicenseManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_IntLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_IntLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_AddIntLicense;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_Recourds;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_IntLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_LocalLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C_IsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowLicenseHistore;
    }
}