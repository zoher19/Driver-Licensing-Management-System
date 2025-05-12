namespace DVLDProject
{
    partial class Frm_ShowLicenseHistorecs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TC_LicenseHistore = new System.Windows.Forms.TabControl();
            this.TP_LocalLicense = new System.Windows.Forms.TabPage();
            this.DGV_LocalLicense = new System.Windows.Forms.DataGridView();
            this.C_LicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TP_InternationalLicense = new System.Windows.Forms.TabPage();
            this.DGV_InternationalLicense = new System.Windows.Forms.DataGridView();
            this.B_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Recourd = new System.Windows.Forms.Label();
            this.C_IntLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_AppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ILicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UC_PersonCard = new DVLDProject.PersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TC_LicenseHistore.SuspendLayout();
            this.TP_LocalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicense)).BeginInit();
            this.TP_InternationalLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.license__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(46, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TC_LicenseHistore
            // 
            this.TC_LicenseHistore.Controls.Add(this.TP_LocalLicense);
            this.TC_LicenseHistore.Controls.Add(this.TP_InternationalLicense);
            this.TC_LicenseHistore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC_LicenseHistore.Location = new System.Drawing.Point(3, 411);
            this.TC_LicenseHistore.Name = "TC_LicenseHistore";
            this.TC_LicenseHistore.SelectedIndex = 0;
            this.TC_LicenseHistore.Size = new System.Drawing.Size(1354, 304);
            this.TC_LicenseHistore.TabIndex = 2;
            // 
            // TP_LocalLicense
            // 
            this.TP_LocalLicense.Controls.Add(this.DGV_LocalLicense);
            this.TP_LocalLicense.Location = new System.Drawing.Point(4, 32);
            this.TP_LocalLicense.Name = "TP_LocalLicense";
            this.TP_LocalLicense.Padding = new System.Windows.Forms.Padding(3);
            this.TP_LocalLicense.Size = new System.Drawing.Size(1346, 268);
            this.TP_LocalLicense.TabIndex = 0;
            this.TP_LocalLicense.Text = "Local License";
            this.TP_LocalLicense.UseVisualStyleBackColor = true;
            // 
            // DGV_LocalLicense
            // 
            this.DGV_LocalLicense.AllowUserToAddRows = false;
            this.DGV_LocalLicense.AllowUserToDeleteRows = false;
            this.DGV_LocalLicense.BackgroundColor = System.Drawing.Color.White;
            this.DGV_LocalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LocalLicense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_LicenseID,
            this.C_ApplicationID,
            this.C_ClassName,
            this.C_IssueDate,
            this.C_ExpirationDate,
            this.C_IsActive});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_LocalLicense.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_LocalLicense.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_LocalLicense.Location = new System.Drawing.Point(3, 6);
            this.DGV_LocalLicense.Name = "DGV_LocalLicense";
            this.DGV_LocalLicense.ReadOnly = true;
            this.DGV_LocalLicense.RowHeadersWidth = 51;
            this.DGV_LocalLicense.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_LocalLicense.RowTemplate.Height = 24;
            this.DGV_LocalLicense.Size = new System.Drawing.Size(1337, 259);
            this.DGV_LocalLicense.TabIndex = 0;
            // 
            // C_LicenseID
            // 
            this.C_LicenseID.HeaderText = "Lic.ID";
            this.C_LicenseID.MinimumWidth = 6;
            this.C_LicenseID.Name = "C_LicenseID";
            this.C_LicenseID.ReadOnly = true;
            this.C_LicenseID.Width = 125;
            // 
            // C_ApplicationID
            // 
            this.C_ApplicationID.HeaderText = "App.ID";
            this.C_ApplicationID.MinimumWidth = 6;
            this.C_ApplicationID.Name = "C_ApplicationID";
            this.C_ApplicationID.ReadOnly = true;
            this.C_ApplicationID.Width = 125;
            // 
            // C_ClassName
            // 
            this.C_ClassName.HeaderText = "Class Name";
            this.C_ClassName.MinimumWidth = 6;
            this.C_ClassName.Name = "C_ClassName";
            this.C_ClassName.ReadOnly = true;
            this.C_ClassName.Width = 300;
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
            this.C_IsActive.HeaderText = "Is Active";
            this.C_IsActive.MinimumWidth = 6;
            this.C_IsActive.Name = "C_IsActive";
            this.C_IsActive.ReadOnly = true;
            this.C_IsActive.Width = 125;
            // 
            // TP_InternationalLicense
            // 
            this.TP_InternationalLicense.Controls.Add(this.DGV_InternationalLicense);
            this.TP_InternationalLicense.Location = new System.Drawing.Point(4, 32);
            this.TP_InternationalLicense.Name = "TP_InternationalLicense";
            this.TP_InternationalLicense.Padding = new System.Windows.Forms.Padding(3);
            this.TP_InternationalLicense.Size = new System.Drawing.Size(1346, 268);
            this.TP_InternationalLicense.TabIndex = 1;
            this.TP_InternationalLicense.Text = "International License";
            this.TP_InternationalLicense.UseVisualStyleBackColor = true;
            // 
            // DGV_InternationalLicense
            // 
            this.DGV_InternationalLicense.AllowUserToAddRows = false;
            this.DGV_InternationalLicense.AllowUserToDeleteRows = false;
            this.DGV_InternationalLicense.BackgroundColor = System.Drawing.Color.White;
            this.DGV_InternationalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InternationalLicense.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_IntLicense,
            this.C_AppID,
            this.C_ILicenseID,
            this.C_IIssueDate,
            this.C_IExpirationDate});
            this.DGV_InternationalLicense.Location = new System.Drawing.Point(5, 6);
            this.DGV_InternationalLicense.Name = "DGV_InternationalLicense";
            this.DGV_InternationalLicense.ReadOnly = true;
            this.DGV_InternationalLicense.RowHeadersWidth = 51;
            this.DGV_InternationalLicense.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_InternationalLicense.RowTemplate.Height = 24;
            this.DGV_InternationalLicense.Size = new System.Drawing.Size(1337, 256);
            this.DGV_InternationalLicense.TabIndex = 1;
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.Location = new System.Drawing.Point(1160, 755);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(168, 37);
            this.B_Close.TabIndex = 4;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 718);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recourd :";
            // 
            // L_Recourd
            // 
            this.L_Recourd.AutoSize = true;
            this.L_Recourd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Recourd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.L_Recourd.Location = new System.Drawing.Point(123, 718);
            this.L_Recourd.Name = "L_Recourd";
            this.L_Recourd.Size = new System.Drawing.Size(109, 23);
            this.L_Recourd.TabIndex = 6;
            this.L_Recourd.Text = "Recourd :";
            // 
            // C_IntLicense
            // 
            this.C_IntLicense.HeaderText = "Int.License";
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
            // C_ILicenseID
            // 
            this.C_ILicenseID.HeaderText = "LicenseID";
            this.C_ILicenseID.MinimumWidth = 6;
            this.C_ILicenseID.Name = "C_ILicenseID";
            this.C_ILicenseID.ReadOnly = true;
            this.C_ILicenseID.Width = 125;
            // 
            // C_IIssueDate
            // 
            this.C_IIssueDate.HeaderText = "Issue Date";
            this.C_IIssueDate.MinimumWidth = 6;
            this.C_IIssueDate.Name = "C_IIssueDate";
            this.C_IIssueDate.ReadOnly = true;
            this.C_IIssueDate.Width = 125;
            // 
            // C_IExpirationDate
            // 
            this.C_IExpirationDate.HeaderText = "Expiration Date";
            this.C_IExpirationDate.MinimumWidth = 6;
            this.C_IExpirationDate.Name = "C_IExpirationDate";
            this.C_IExpirationDate.ReadOnly = true;
            this.C_IExpirationDate.Width = 125;
            // 
            // UC_PersonCard
            // 
            this.UC_PersonCard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_PersonCard.Location = new System.Drawing.Point(288, 1);
            this.UC_PersonCard.Margin = new System.Windows.Forms.Padding(4);
            this.UC_PersonCard.Name = "UC_PersonCard";
            this.UC_PersonCard.Size = new System.Drawing.Size(1319, 379);
            this.UC_PersonCard.TabIndex = 3;
            this.UC_PersonCard.Load += new System.EventHandler(this.UC_PersonCard_Load);
            // 
            // Frm_ShowLicenseHistorecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 828);
            this.Controls.Add(this.L_Recourd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.UC_PersonCard);
            this.Controls.Add(this.TC_LicenseHistore);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_ShowLicenseHistorecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ShowLicenseHistorecs";
            this.Load += new System.EventHandler(this.Frm_ShowLicenseHistorecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TC_LicenseHistore.ResumeLayout(false);
            this.TP_LocalLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicense)).EndInit();
            this.TP_InternationalLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl TC_LicenseHistore;
        private System.Windows.Forms.TabPage TP_LocalLicense;
        private System.Windows.Forms.DataGridView DGV_LocalLicense;
        private System.Windows.Forms.TabPage TP_InternationalLicense;
        private System.Windows.Forms.DataGridView DGV_InternationalLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_LicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C_IsActive;
        private PersonCard UC_PersonCard;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Recourd;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_IntLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ILicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_IIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_IExpirationDate;
    }
}