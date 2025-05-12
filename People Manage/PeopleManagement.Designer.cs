namespace DVLDProject
{
    partial class Frm_PeopleManagement
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
            this.DGV_PeopleInfo = new System.Windows.Forms.DataGridView();
            this.C_PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Gendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_ManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TMS_ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Pnone = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_FillterBy = new System.Windows.Forms.ComboBox();
            this.TB_FillterBy = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.L_RecordNumbers = new System.Windows.Forms.Label();
            this.L_FillterBy = new System.Windows.Forms.Label();
            this.B_UpdatePeopleTable = new System.Windows.Forms.Button();
            this.B_AddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_UserTitile = new System.Windows.Forms.Label();
            this.L_UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PeopleInfo)).BeginInit();
            this.CMS_ManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_PeopleInfo
            // 
            this.DGV_PeopleInfo.AllowUserToAddRows = false;
            this.DGV_PeopleInfo.AllowUserToDeleteRows = false;
            this.DGV_PeopleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PeopleInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_PeopleInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PeopleInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_PeopleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PeopleInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_PersonID,
            this.C_NationalNo,
            this.C_FirstName,
            this.C_SecondName,
            this.C_ThirdName,
            this.C_LastName,
            this.C_Gendor,
            this.C_DateOfBirth,
            this.C_Nationality,
            this.C_Phone,
            this.C_Email});
            this.DGV_PeopleInfo.Location = new System.Drawing.Point(0, 308);
            this.DGV_PeopleInfo.MultiSelect = false;
            this.DGV_PeopleInfo.Name = "DGV_PeopleInfo";
            this.DGV_PeopleInfo.ReadOnly = true;
            this.DGV_PeopleInfo.RowHeadersWidth = 51;
            this.DGV_PeopleInfo.RowTemplate.ContextMenuStrip = this.CMS_ManagePeople;
            this.DGV_PeopleInfo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_PeopleInfo.RowTemplate.Height = 24;
            this.DGV_PeopleInfo.RowTemplate.ReadOnly = true;
            this.DGV_PeopleInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PeopleInfo.Size = new System.Drawing.Size(1544, 416);
            this.DGV_PeopleInfo.TabIndex = 0;
            // 
            // C_PersonID
            // 
            this.C_PersonID.HeaderText = "PersonID";
            this.C_PersonID.MinimumWidth = 6;
            this.C_PersonID.Name = "C_PersonID";
            this.C_PersonID.ReadOnly = true;
            // 
            // C_NationalNo
            // 
            this.C_NationalNo.HeaderText = "NationalNo";
            this.C_NationalNo.MinimumWidth = 6;
            this.C_NationalNo.Name = "C_NationalNo";
            this.C_NationalNo.ReadOnly = true;
            // 
            // C_FirstName
            // 
            this.C_FirstName.HeaderText = "First Name";
            this.C_FirstName.MinimumWidth = 6;
            this.C_FirstName.Name = "C_FirstName";
            this.C_FirstName.ReadOnly = true;
            // 
            // C_SecondName
            // 
            this.C_SecondName.HeaderText = "Second Name";
            this.C_SecondName.MinimumWidth = 6;
            this.C_SecondName.Name = "C_SecondName";
            this.C_SecondName.ReadOnly = true;
            // 
            // C_ThirdName
            // 
            this.C_ThirdName.HeaderText = "Third Name";
            this.C_ThirdName.MinimumWidth = 6;
            this.C_ThirdName.Name = "C_ThirdName";
            this.C_ThirdName.ReadOnly = true;
            // 
            // C_LastName
            // 
            this.C_LastName.HeaderText = "Last Name";
            this.C_LastName.MinimumWidth = 6;
            this.C_LastName.Name = "C_LastName";
            this.C_LastName.ReadOnly = true;
            // 
            // C_Gendor
            // 
            this.C_Gendor.HeaderText = "Gendor";
            this.C_Gendor.MinimumWidth = 6;
            this.C_Gendor.Name = "C_Gendor";
            this.C_Gendor.ReadOnly = true;
            // 
            // C_DateOfBirth
            // 
            this.C_DateOfBirth.HeaderText = "Date Of Birth";
            this.C_DateOfBirth.MinimumWidth = 6;
            this.C_DateOfBirth.Name = "C_DateOfBirth";
            this.C_DateOfBirth.ReadOnly = true;
            // 
            // C_Nationality
            // 
            this.C_Nationality.HeaderText = "Nationaolit";
            this.C_Nationality.MinimumWidth = 6;
            this.C_Nationality.Name = "C_Nationality";
            this.C_Nationality.ReadOnly = true;
            // 
            // C_Phone
            // 
            this.C_Phone.HeaderText = "Phone";
            this.C_Phone.MinimumWidth = 6;
            this.C_Phone.Name = "C_Phone";
            this.C_Phone.ReadOnly = true;
            // 
            // C_Email
            // 
            this.C_Email.HeaderText = "Email";
            this.C_Email.MinimumWidth = 6;
            this.C_Email.Name = "C_Email";
            this.C_Email.ReadOnly = true;
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
            this.TMS_Pnone});
            this.CMS_ManagePeople.Name = "CMS_ManagePeople";
            this.CMS_ManagePeople.Size = new System.Drawing.Size(221, 244);
            // 
            // TMS_ShowDetails
            // 
            this.TMS_ShowDetails.Image = global::DVLDProject.Properties.Resources.contact;
            this.TMS_ShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_ShowDetails.Name = "TMS_ShowDetails";
            this.TMS_ShowDetails.Size = new System.Drawing.Size(220, 38);
            this.TMS_ShowDetails.Text = "Show Details";
            this.TMS_ShowDetails.Click += new System.EventHandler(this.TMS_ShowDetails_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 6);
            // 
            // TMS_AddNewPerson
            // 
            this.TMS_AddNewPerson.Image = global::DVLDProject.Properties.Resources.person;
            this.TMS_AddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_AddNewPerson.Name = "TMS_AddNewPerson";
            this.TMS_AddNewPerson.Size = new System.Drawing.Size(220, 38);
            this.TMS_AddNewPerson.Text = "Add New Person";
            this.TMS_AddNewPerson.Click += new System.EventHandler(this.TMS_AddNewPerson_Click);
            // 
            // TMS_Edit
            // 
            this.TMS_Edit.Image = global::DVLDProject.Properties.Resources.person_boy__6_;
            this.TMS_Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Edit.Name = "TMS_Edit";
            this.TMS_Edit.Size = new System.Drawing.Size(220, 38);
            this.TMS_Edit.Text = "Edit";
            this.TMS_Edit.Click += new System.EventHandler(this.TMS_Edit_Click);
            // 
            // TMS_Delete
            // 
            this.TMS_Delete.Image = global::DVLDProject.Properties.Resources.person_boy__7_;
            this.TMS_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Delete.Name = "TMS_Delete";
            this.TMS_Delete.Size = new System.Drawing.Size(220, 38);
            this.TMS_Delete.Text = "Delete";
            this.TMS_Delete.Click += new System.EventHandler(this.TMS_Delete_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 6);
            // 
            // TMS_SendEmail
            // 
            this.TMS_SendEmail.Image = global::DVLDProject.Properties.Resources.letter;
            this.TMS_SendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_SendEmail.Name = "TMS_SendEmail";
            this.TMS_SendEmail.Size = new System.Drawing.Size(220, 38);
            this.TMS_SendEmail.Text = "Send Email";
            this.TMS_SendEmail.Click += new System.EventHandler(this.TMS_SendEmail_Click);
            // 
            // TMS_Pnone
            // 
            this.TMS_Pnone.Image = global::DVLDProject.Properties.Resources.call;
            this.TMS_Pnone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Pnone.Name = "TMS_Pnone";
            this.TMS_Pnone.Size = new System.Drawing.Size(220, 38);
            this.TMS_Pnone.Text = "Phone";
            this.TMS_Pnone.Click += new System.EventHandler(this.TMS_Pnone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage People";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_FillterBy
            // 
            this.CB_FillterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CB_FillterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FillterBy.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FillterBy.FormattingEnabled = true;
            this.CB_FillterBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNO",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gendor",
            "Phone",
            "Email",
            "Nationality"});
            this.CB_FillterBy.Location = new System.Drawing.Point(185, 269);
            this.CB_FillterBy.Name = "CB_FillterBy";
            this.CB_FillterBy.Size = new System.Drawing.Size(252, 30);
            this.CB_FillterBy.TabIndex = 5;
            this.CB_FillterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FillterBy_SelectedIndexChanged);
            // 
            // TB_FillterBy
            // 
            this.TB_FillterBy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FillterBy.Location = new System.Drawing.Point(443, 269);
            this.TB_FillterBy.Name = "TB_FillterBy";
            this.TB_FillterBy.Size = new System.Drawing.Size(269, 31);
            this.TB_FillterBy.TabIndex = 6;
            this.TB_FillterBy.Visible = false;
            this.TB_FillterBy.TextChanged += new System.EventHandler(this.TB_FillterBy_TextChanged);
            this.TB_FillterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_FillterBy_KeyPress);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(12, 727);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(180, 20);
            this.Label.TabIndex = 8;
            this.Label.Text = ":: Record Numbers :";
            // 
            // L_RecordNumbers
            // 
            this.L_RecordNumbers.AutoSize = true;
            this.L_RecordNumbers.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_RecordNumbers.Location = new System.Drawing.Point(198, 727);
            this.L_RecordNumbers.Name = "L_RecordNumbers";
            this.L_RecordNumbers.Size = new System.Drawing.Size(27, 20);
            this.L_RecordNumbers.TabIndex = 9;
            this.L_RecordNumbers.Text = "##";
            // 
            // L_FillterBy
            // 
            this.L_FillterBy.AutoSize = true;
            this.L_FillterBy.BackColor = System.Drawing.Color.MediumAquamarine;
            this.L_FillterBy.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_FillterBy.ForeColor = System.Drawing.Color.DimGray;
            this.L_FillterBy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.L_FillterBy.ImageIndex = 0;
            this.L_FillterBy.Location = new System.Drawing.Point(11, 272);
            this.L_FillterBy.Name = "L_FillterBy";
            this.L_FillterBy.Size = new System.Drawing.Size(168, 27);
            this.L_FillterBy.TabIndex = 4;
            this.L_FillterBy.Text = "Fillter By :";
            // 
            // B_UpdatePeopleTable
            // 
            this.B_UpdatePeopleTable.BackgroundImage = global::DVLDProject.Properties.Resources.refresh;
            this.B_UpdatePeopleTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_UpdatePeopleTable.Location = new System.Drawing.Point(1376, 232);
            this.B_UpdatePeopleTable.Name = "B_UpdatePeopleTable";
            this.B_UpdatePeopleTable.Size = new System.Drawing.Size(75, 70);
            this.B_UpdatePeopleTable.TabIndex = 7;
            this.B_UpdatePeopleTable.UseVisualStyleBackColor = true;
            this.B_UpdatePeopleTable.Click += new System.EventHandler(this.B_UpdatePeopleTable_Click);
            // 
            // B_AddPerson
            // 
            this.B_AddPerson.BackgroundImage = global::DVLDProject.Properties.Resources.add_friend;
            this.B_AddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_AddPerson.Location = new System.Drawing.Point(1457, 227);
            this.B_AddPerson.Name = "B_AddPerson";
            this.B_AddPerson.Size = new System.Drawing.Size(74, 74);
            this.B_AddPerson.TabIndex = 3;
            this.B_AddPerson.UseVisualStyleBackColor = true;
            this.B_AddPerson.Click += new System.EventHandler(this.B_AddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.group__1_;
            this.pictureBox1.Location = new System.Drawing.Point(563, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // L_UserTitile
            // 
            this.L_UserTitile.AutoSize = true;
            this.L_UserTitile.BackColor = System.Drawing.Color.MediumAquamarine;
            this.L_UserTitile.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_UserTitile.ForeColor = System.Drawing.Color.DimGray;
            this.L_UserTitile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.L_UserTitile.ImageIndex = 0;
            this.L_UserTitile.Location = new System.Drawing.Point(1267, 9);
            this.L_UserTitile.Name = "L_UserTitile";
            this.L_UserTitile.Size = new System.Drawing.Size(90, 27);
            this.L_UserTitile.TabIndex = 11;
            this.L_UserTitile.Text = "User :";
            // 
            // L_UserName
            // 
            this.L_UserName.AutoSize = true;
            this.L_UserName.BackColor = System.Drawing.Color.MediumAquamarine;
            this.L_UserName.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_UserName.ForeColor = System.Drawing.Color.DimGray;
            this.L_UserName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.L_UserName.ImageIndex = 0;
            this.L_UserName.Location = new System.Drawing.Point(1363, 9);
            this.L_UserName.Name = "L_UserName";
            this.L_UserName.Size = new System.Drawing.Size(129, 27);
            this.L_UserName.TabIndex = 12;
            this.L_UserName.Text = "User Name";
            // 
            // Frm_PeopleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 782);
            this.Controls.Add(this.L_UserName);
            this.Controls.Add(this.L_UserTitile);
            this.Controls.Add(this.L_RecordNumbers);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.B_UpdatePeopleTable);
            this.Controls.Add(this.TB_FillterBy);
            this.Controls.Add(this.CB_FillterBy);
            this.Controls.Add(this.L_FillterBy);
            this.Controls.Add(this.B_AddPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_PeopleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_PeopleManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeopleManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_PeopleManagement_FormClosed);
            this.Load += new System.EventHandler(this.Frm_PeopleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PeopleInfo)).EndInit();
            this.CMS_ManagePeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_PeopleInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_AddPerson;
        private System.Windows.Forms.Label L_FillterBy;
        private System.Windows.Forms.ComboBox CB_FillterBy;
        private System.Windows.Forms.TextBox TB_FillterBy;
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
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label L_RecordNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Gendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Email;
        private System.Windows.Forms.Label L_UserTitile;
        private System.Windows.Forms.Label L_UserName;
    }
}