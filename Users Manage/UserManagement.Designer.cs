namespace DVLDProject
{
    partial class Frm_UserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Users = new System.Windows.Forms.DataGridView();
            this.C_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CMS_ManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TMS_ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Pnone = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.B_AddUsers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_FillterBy = new System.Windows.Forms.ComboBox();
            this.TB_FillterBy = new System.Windows.Forms.TextBox();
            this.CB_IssActive = new System.Windows.Forms.ComboBox();
            this.B_UpdatePeopleTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.L_Records = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).BeginInit();
            this.CMS_ManagePeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.team;
            this.pictureBox1.Location = new System.Drawing.Point(339, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(316, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // DGV_Users
            // 
            this.DGV_Users.AllowUserToAddRows = false;
            this.DGV_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Users.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_UserID,
            this.C_PersonID,
            this.C_FullName,
            this.C_UserName,
            this.C_IsActive});
            this.DGV_Users.Location = new System.Drawing.Point(1, 340);
            this.DGV_Users.MultiSelect = false;
            this.DGV_Users.Name = "DGV_Users";
            this.DGV_Users.ReadOnly = true;
            this.DGV_Users.RowHeadersWidth = 51;
            this.DGV_Users.RowTemplate.ContextMenuStrip = this.CMS_ManagePeople;
            this.DGV_Users.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Users.RowTemplate.Height = 24;
            this.DGV_Users.RowTemplate.ReadOnly = true;
            this.DGV_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Users.Size = new System.Drawing.Size(1042, 365);
            this.DGV_Users.TabIndex = 2;
            // 
            // C_UserID
            // 
            this.C_UserID.HeaderText = "User ID";
            this.C_UserID.MinimumWidth = 6;
            this.C_UserID.Name = "C_UserID";
            this.C_UserID.ReadOnly = true;
            this.C_UserID.Width = 125;
            // 
            // C_PersonID
            // 
            this.C_PersonID.HeaderText = "Person ID";
            this.C_PersonID.MinimumWidth = 6;
            this.C_PersonID.Name = "C_PersonID";
            this.C_PersonID.ReadOnly = true;
            this.C_PersonID.Width = 125;
            // 
            // C_FullName
            // 
            this.C_FullName.HeaderText = "Full Name";
            this.C_FullName.MinimumWidth = 6;
            this.C_FullName.Name = "C_FullName";
            this.C_FullName.ReadOnly = true;
            this.C_FullName.Width = 250;
            // 
            // C_UserName
            // 
            this.C_UserName.HeaderText = "UserName";
            this.C_UserName.MinimumWidth = 6;
            this.C_UserName.Name = "C_UserName";
            this.C_UserName.ReadOnly = true;
            this.C_UserName.Width = 150;
            // 
            // C_IsActive
            // 
            this.C_IsActive.HeaderText = "Is Active";
            this.C_IsActive.MinimumWidth = 6;
            this.C_IsActive.Name = "C_IsActive";
            this.C_IsActive.ReadOnly = true;
            this.C_IsActive.Width = 125;
            // 
            // CMS_ManagePeople
            // 
            this.CMS_ManagePeople.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMS_ManagePeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_ManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_ShowDetails,
            this.toolStripMenuItem2,
            this.TMS_AddNewPerson,
            this.TMS_Edit,
            this.TMS_Delete,
            this.toolStripMenuItem1,
            this.TMS_SendEmail,
            this.TMS_Pnone,
            this.TMS_ChangePassword});
            this.CMS_ManagePeople.Name = "CMS_ManagePeople";
            this.CMS_ManagePeople.Size = new System.Drawing.Size(230, 282);
            // 
            // TMS_ShowDetails
            // 
            this.TMS_ShowDetails.Image = global::DVLDProject.Properties.Resources.contact;
            this.TMS_ShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowDetails.Name = "TMS_ShowDetails";
            this.TMS_ShowDetails.Size = new System.Drawing.Size(229, 38);
            this.TMS_ShowDetails.Text = "Show Details";
            this.TMS_ShowDetails.Click += new System.EventHandler(this.TMS_ShowDetails_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 6);
            // 
            // TMS_AddNewPerson
            // 
            this.TMS_AddNewPerson.Image = global::DVLDProject.Properties.Resources.person;
            this.TMS_AddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_AddNewPerson.Name = "TMS_AddNewPerson";
            this.TMS_AddNewPerson.Size = new System.Drawing.Size(229, 38);
            this.TMS_AddNewPerson.Text = "Add New Person";
            this.TMS_AddNewPerson.Click += new System.EventHandler(this.TMS_AddNewPerson_Click);
            // 
            // TMS_Edit
            // 
            this.TMS_Edit.Image = global::DVLDProject.Properties.Resources.person_boy__6_;
            this.TMS_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Edit.Name = "TMS_Edit";
            this.TMS_Edit.Size = new System.Drawing.Size(229, 38);
            this.TMS_Edit.Text = "Edit";
            this.TMS_Edit.Click += new System.EventHandler(this.TMS_Edit_Click);
            // 
            // TMS_Delete
            // 
            this.TMS_Delete.Image = global::DVLDProject.Properties.Resources.person_boy__7_;
            this.TMS_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Delete.Name = "TMS_Delete";
            this.TMS_Delete.Size = new System.Drawing.Size(229, 38);
            this.TMS_Delete.Text = "Delete";
            this.TMS_Delete.Click += new System.EventHandler(this.TMS_Delete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // TMS_SendEmail
            // 
            this.TMS_SendEmail.Image = global::DVLDProject.Properties.Resources.letter;
            this.TMS_SendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_SendEmail.Name = "TMS_SendEmail";
            this.TMS_SendEmail.Size = new System.Drawing.Size(229, 38);
            this.TMS_SendEmail.Text = "Send Email";
            // 
            // TMS_Pnone
            // 
            this.TMS_Pnone.Image = global::DVLDProject.Properties.Resources.call;
            this.TMS_Pnone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Pnone.Name = "TMS_Pnone";
            this.TMS_Pnone.Size = new System.Drawing.Size(229, 38);
            this.TMS_Pnone.Text = "Phone";
            // 
            // TMS_ChangePassword
            // 
            this.TMS_ChangePassword.Image = global::DVLDProject.Properties.Resources.reset_password__2_;
            this.TMS_ChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ChangePassword.Name = "TMS_ChangePassword";
            this.TMS_ChangePassword.Size = new System.Drawing.Size(229, 38);
            this.TMS_ChangePassword.Text = "Change Password";
            this.TMS_ChangePassword.Click += new System.EventHandler(this.TMS_ChangePassword_Click);
            // 
            // B_AddUsers
            // 
            this.B_AddUsers.BackgroundImage = global::DVLDProject.Properties.Resources.add_friend;
            this.B_AddUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_AddUsers.Location = new System.Drawing.Point(968, 264);
            this.B_AddUsers.Name = "B_AddUsers";
            this.B_AddUsers.Size = new System.Drawing.Size(75, 70);
            this.B_AddUsers.TabIndex = 3;
            this.B_AddUsers.UseVisualStyleBackColor = true;
            this.B_AddUsers.Click += new System.EventHandler(this.B_AddUsers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fillter By :";
            // 
            // CB_FillterBy
            // 
            this.CB_FillterBy.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.CB_FillterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FillterBy.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FillterBy.ForeColor = System.Drawing.Color.Black;
            this.CB_FillterBy.FormattingEnabled = true;
            this.CB_FillterBy.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "UserName",
            "IsActive"});
            this.CB_FillterBy.Location = new System.Drawing.Point(171, 306);
            this.CB_FillterBy.Name = "CB_FillterBy";
            this.CB_FillterBy.Size = new System.Drawing.Size(211, 28);
            this.CB_FillterBy.TabIndex = 5;
            this.CB_FillterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FillterBy_SelectedIndexChanged);
            // 
            // TB_FillterBy
            // 
            this.TB_FillterBy.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FillterBy.Location = new System.Drawing.Point(397, 307);
            this.TB_FillterBy.Name = "TB_FillterBy";
            this.TB_FillterBy.Size = new System.Drawing.Size(215, 27);
            this.TB_FillterBy.TabIndex = 6;
            this.TB_FillterBy.Visible = false;
            this.TB_FillterBy.TextChanged += new System.EventHandler(this.TB_FillterBy_TextChanged);
            this.TB_FillterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_FillterBy_KeyPress);
            // 
            // CB_IssActive
            // 
            this.CB_IssActive.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.CB_IssActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_IssActive.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_IssActive.ForeColor = System.Drawing.Color.Black;
            this.CB_IssActive.FormattingEnabled = true;
            this.CB_IssActive.Items.AddRange(new object[] {
            "None",
            "Yes",
            "No"});
            this.CB_IssActive.Location = new System.Drawing.Point(397, 306);
            this.CB_IssActive.Name = "CB_IssActive";
            this.CB_IssActive.Size = new System.Drawing.Size(131, 28);
            this.CB_IssActive.TabIndex = 8;
            this.CB_IssActive.Visible = false;
            this.CB_IssActive.SelectedIndexChanged += new System.EventHandler(this.CB_IISActive_SelectedIndexChanged);
            // 
            // B_UpdatePeopleTable
            // 
            this.B_UpdatePeopleTable.BackgroundImage = global::DVLDProject.Properties.Resources.refresh;
            this.B_UpdatePeopleTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_UpdatePeopleTable.Location = new System.Drawing.Point(887, 264);
            this.B_UpdatePeopleTable.Name = "B_UpdatePeopleTable";
            this.B_UpdatePeopleTable.Size = new System.Drawing.Size(75, 70);
            this.B_UpdatePeopleTable.TabIndex = 10;
            this.B_UpdatePeopleTable.UseVisualStyleBackColor = true;
            this.B_UpdatePeopleTable.Click += new System.EventHandler(this.B_UpdatePeopleTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 709);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Records :";
            // 
            // L_Records
            // 
            this.L_Records.AutoSize = true;
            this.L_Records.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Records.Location = new System.Drawing.Point(127, 709);
            this.L_Records.Name = "L_Records";
            this.L_Records.Size = new System.Drawing.Size(21, 23);
            this.L_Records.TabIndex = 12;
            this.L_Records.Text = "#";
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.B_Close.Location = new System.Drawing.Point(902, 709);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(132, 32);
            this.B_Close.TabIndex = 13;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // Frm_UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 741);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.L_Records);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_UpdatePeopleTable);
            this.Controls.Add(this.CB_IssActive);
            this.Controls.Add(this.TB_FillterBy);
            this.Controls.Add(this.CB_FillterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_AddUsers);
            this.Controls.Add(this.DGV_Users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.Frm_UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).EndInit();
            this.CMS_ManagePeople.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Users;
        private System.Windows.Forms.Button B_AddUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C_IsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_FillterBy;
        private System.Windows.Forms.TextBox TB_FillterBy;
        private System.Windows.Forms.ComboBox CB_IssActive;
        private System.Windows.Forms.ContextMenuStrip CMS_ManagePeople;
        private System.Windows.Forms.ToolStripMenuItem TMS_ShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TMS_AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem TMS_Edit;
        private System.Windows.Forms.ToolStripMenuItem TMS_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TMS_SendEmail;
        private System.Windows.Forms.ToolStripMenuItem TMS_Pnone;
        private System.Windows.Forms.Button B_UpdatePeopleTable;
        private System.Windows.Forms.ToolStripMenuItem TMS_ChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_Records;
        private System.Windows.Forms.Button B_Close;
    }
}