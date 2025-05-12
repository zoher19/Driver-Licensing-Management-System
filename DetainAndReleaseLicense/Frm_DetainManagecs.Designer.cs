namespace DVLDProject
{
    partial class Frm_DetainManagecs
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Detain = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Recourds = new System.Windows.Forms.Label();
            this.C_DetainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_LicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_D_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IsReleased = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.C_FineFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ReleaseAppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.B_Detain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TMS_ShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ShowLicenseHistoreDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ReleaseLicense = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detain Licenses Manage";
            // 
            // DGV_Detain
            // 
            this.DGV_Detain.AllowUserToAddRows = false;
            this.DGV_Detain.AllowUserToDeleteRows = false;
            this.DGV_Detain.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Detain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Detain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Detain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_DetainID,
            this.C_LicenseID,
            this.C_D_Date,
            this.C_IsReleased,
            this.C_FineFees,
            this.C_ReleaseDate,
            this.C_NationalNo,
            this.C_FullName,
            this.C_ReleaseAppID});
            this.DGV_Detain.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_Detain.Location = new System.Drawing.Point(1, 299);
            this.DGV_Detain.MultiSelect = false;
            this.DGV_Detain.Name = "DGV_Detain";
            this.DGV_Detain.ReadOnly = true;
            this.DGV_Detain.RowHeadersWidth = 51;
            this.DGV_Detain.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Detain.RowTemplate.Height = 24;
            this.DGV_Detain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Detain.Size = new System.Drawing.Size(1435, 395);
            this.DGV_Detain.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1260, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 713);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recourds :";
            // 
            // L_Recourds
            // 
            this.L_Recourds.AutoSize = true;
            this.L_Recourds.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Recourds.Location = new System.Drawing.Point(138, 713);
            this.L_Recourds.Name = "L_Recourds";
            this.L_Recourds.Size = new System.Drawing.Size(43, 23);
            this.L_Recourds.TabIndex = 5;
            this.L_Recourds.Text = " ##";
            // 
            // C_DetainID
            // 
            this.C_DetainID.HeaderText = "D.ID";
            this.C_DetainID.MinimumWidth = 6;
            this.C_DetainID.Name = "C_DetainID";
            this.C_DetainID.ReadOnly = true;
            this.C_DetainID.Width = 125;
            // 
            // C_LicenseID
            // 
            this.C_LicenseID.HeaderText = "L.ID";
            this.C_LicenseID.MinimumWidth = 6;
            this.C_LicenseID.Name = "C_LicenseID";
            this.C_LicenseID.ReadOnly = true;
            this.C_LicenseID.Width = 125;
            // 
            // C_D_Date
            // 
            this.C_D_Date.HeaderText = "D.Date";
            this.C_D_Date.MinimumWidth = 6;
            this.C_D_Date.Name = "C_D_Date";
            this.C_D_Date.ReadOnly = true;
            this.C_D_Date.Width = 125;
            // 
            // C_IsReleased
            // 
            this.C_IsReleased.HeaderText = "IsReleased";
            this.C_IsReleased.MinimumWidth = 6;
            this.C_IsReleased.Name = "C_IsReleased";
            this.C_IsReleased.ReadOnly = true;
            this.C_IsReleased.Width = 125;
            // 
            // C_FineFees
            // 
            this.C_FineFees.HeaderText = "Fine Fees";
            this.C_FineFees.MinimumWidth = 6;
            this.C_FineFees.Name = "C_FineFees";
            this.C_FineFees.ReadOnly = true;
            this.C_FineFees.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_FineFees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C_FineFees.Width = 125;
            // 
            // C_ReleaseDate
            // 
            this.C_ReleaseDate.HeaderText = "Release Date";
            this.C_ReleaseDate.MinimumWidth = 6;
            this.C_ReleaseDate.Name = "C_ReleaseDate";
            this.C_ReleaseDate.ReadOnly = true;
            this.C_ReleaseDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_ReleaseDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C_ReleaseDate.Width = 125;
            // 
            // C_NationalNo
            // 
            this.C_NationalNo.HeaderText = "NationalNo";
            this.C_NationalNo.MinimumWidth = 6;
            this.C_NationalNo.Name = "C_NationalNo";
            this.C_NationalNo.ReadOnly = true;
            this.C_NationalNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_NationalNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C_NationalNo.Width = 125;
            // 
            // C_FullName
            // 
            this.C_FullName.HeaderText = "FullName";
            this.C_FullName.MinimumWidth = 6;
            this.C_FullName.Name = "C_FullName";
            this.C_FullName.ReadOnly = true;
            this.C_FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C_FullName.Width = 250;
            // 
            // C_ReleaseAppID
            // 
            this.C_ReleaseAppID.HeaderText = "ReleaseAppID";
            this.C_ReleaseAppID.MinimumWidth = 6;
            this.C_ReleaseAppID.Name = "C_ReleaseAppID";
            this.C_ReleaseAppID.ReadOnly = true;
            this.C_ReleaseAppID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_ReleaseAppID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.C_ReleaseAppID.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_ShowPersonDetails,
            this.ShowLicenseDetails,
            this.TMS_ShowLicenseHistoreDetails,
            this.toolStripMenuItem1,
            this.TMS_ReleaseLicense});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(405, 162);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(401, 6);
            // 
            // B_Detain
            // 
            this.B_Detain.BackgroundImage = global::DVLDProject.Properties.Resources.hand1;
            this.B_Detain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Detain.Location = new System.Drawing.Point(1356, 215);
            this.B_Detain.Name = "B_Detain";
            this.B_Detain.Size = new System.Drawing.Size(80, 78);
            this.B_Detain.TabIndex = 6;
            this.B_Detain.UseVisualStyleBackColor = true;
            this.B_Detain.Click += new System.EventHandler(this.B_Detain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.hand;
            this.pictureBox1.Location = new System.Drawing.Point(594, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TMS_ShowPersonDetails
            // 
            this.TMS_ShowPersonDetails.Image = global::DVLDProject.Properties.Resources.list__1_;
            this.TMS_ShowPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowPersonDetails.Name = "TMS_ShowPersonDetails";
            this.TMS_ShowPersonDetails.Size = new System.Drawing.Size(404, 38);
            this.TMS_ShowPersonDetails.Text = "Show person Details";
            this.TMS_ShowPersonDetails.Click += new System.EventHandler(this.TMS_ShowPersonDetails_Click);
            // 
            // ShowLicenseDetails
            // 
            this.ShowLicenseDetails.Image = global::DVLDProject.Properties.Resources.driving_license__4_;
            this.ShowLicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseDetails.Name = "ShowLicenseDetails";
            this.ShowLicenseDetails.Size = new System.Drawing.Size(404, 38);
            this.ShowLicenseDetails.Text = "Show License Details";
            this.ShowLicenseDetails.Click += new System.EventHandler(this.ShowLicenseDetails_Click);
            // 
            // TMS_ShowLicenseHistoreDetails
            // 
            this.TMS_ShowLicenseHistoreDetails.Image = global::DVLDProject.Properties.Resources.detail;
            this.TMS_ShowLicenseHistoreDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowLicenseHistoreDetails.Name = "TMS_ShowLicenseHistoreDetails";
            this.TMS_ShowLicenseHistoreDetails.Size = new System.Drawing.Size(404, 38);
            this.TMS_ShowLicenseHistoreDetails.Text = "Show License Histore Details";
            this.TMS_ShowLicenseHistoreDetails.Click += new System.EventHandler(this.TMS_ShowLicenseHistoreDetails_Click);
            // 
            // TMS_ReleaseLicense
            // 
            this.TMS_ReleaseLicense.Image = global::DVLDProject.Properties.Resources.press_release;
            this.TMS_ReleaseLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ReleaseLicense.Name = "TMS_ReleaseLicense";
            this.TMS_ReleaseLicense.Size = new System.Drawing.Size(404, 38);
            this.TMS_ReleaseLicense.Text = "Release License";
            this.TMS_ReleaseLicense.Click += new System.EventHandler(this.TMS_ReleaseLicense_Click);
            // 
            // Frm_DetainManagecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 772);
            this.Controls.Add(this.B_Detain);
            this.Controls.Add(this.L_Recourds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_Detain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_DetainManagecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DetainManagecs";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Detain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_Recourds;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DetainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_LicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_D_Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C_IsReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_FineFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ReleaseAppID;
        private System.Windows.Forms.Button B_Detain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowLicenseHistoreDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TMS_ReleaseLicense;
    }
}