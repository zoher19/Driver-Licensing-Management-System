namespace DVLDProject
{
    partial class Frm_AddEditUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddEditUsers));
            this.L_Title = new System.Windows.Forms.Label();
            this.TC_AddEditUsers = new System.Windows.Forms.TabControl();
            this.TP_Person = new System.Windows.Forms.TabPage();
            this.B_Next = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UC_PersonCard = new DVLDProject.PersonCardAndFind();
            this.TP_UserInfo = new System.Windows.Forms.TabPage();
            this.CB_IsActive = new System.Windows.Forms.CheckBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.TB_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.EP1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TC_AddEditUsers.SuspendLayout();
            this.TP_Person.SuspendLayout();
            this.TP_UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.L_Title.Location = new System.Drawing.Point(343, 9);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(294, 70);
            this.L_Title.TabIndex = 0;
            this.L_Title.Text = "Add User";
            // 
            // TC_AddEditUsers
            // 
            this.TC_AddEditUsers.Controls.Add(this.TP_Person);
            this.TC_AddEditUsers.Controls.Add(this.TP_UserInfo);
            this.TC_AddEditUsers.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC_AddEditUsers.Location = new System.Drawing.Point(2, 82);
            this.TC_AddEditUsers.Name = "TC_AddEditUsers";
            this.TC_AddEditUsers.SelectedIndex = 0;
            this.TC_AddEditUsers.Size = new System.Drawing.Size(1106, 551);
            this.TC_AddEditUsers.TabIndex = 1;
            // 
            // TP_Person
            // 
            this.TP_Person.Controls.Add(this.B_Next);
            this.TP_Person.Controls.Add(this.UC_PersonCard);
            this.TP_Person.Location = new System.Drawing.Point(4, 27);
            this.TP_Person.Name = "TP_Person";
            this.TP_Person.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Person.Size = new System.Drawing.Size(1098, 520);
            this.TP_Person.TabIndex = 0;
            this.TP_Person.Text = "Person Info";
            this.TP_Person.UseVisualStyleBackColor = true;
            // 
            // B_Next
            // 
            this.B_Next.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Next.ForeColor = System.Drawing.Color.Black;
            this.B_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Next.ImageIndex = 0;
            this.B_Next.ImageList = this.imageList1;
            this.B_Next.Location = new System.Drawing.Point(862, 468);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(200, 45);
            this.B_Next.TabIndex = 2;
            this.B_Next.Text = "Next";
            this.B_Next.UseVisualStyleBackColor = true;
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "next-button.png");
            this.imageList1.Images.SetKeyName(1, "close.png");
            this.imageList1.Images.SetKeyName(2, "diskette (1).png");
            this.imageList1.Images.SetKeyName(3, "id-card.png");
            // 
            // UC_PersonCard
            // 
            this.UC_PersonCard.Location = new System.Drawing.Point(6, 0);
            this.UC_PersonCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UC_PersonCard.Name = "UC_PersonCard";
            this.UC_PersonCard.Person = null;
            this.UC_PersonCard.Size = new System.Drawing.Size(1412, 513);
            this.UC_PersonCard.TabIndex = 0;
            this.UC_PersonCard.Load += new System.EventHandler(this.UC_PersonCard_Load);
            // 
            // TP_UserInfo
            // 
            this.TP_UserInfo.Controls.Add(this.CB_IsActive);
            this.TP_UserInfo.Controls.Add(this.B_Save);
            this.TP_UserInfo.Controls.Add(this.TB_ConfirmPassword);
            this.TP_UserInfo.Controls.Add(this.TB_Password);
            this.TP_UserInfo.Controls.Add(this.TB_UserName);
            this.TP_UserInfo.Controls.Add(this.label4);
            this.TP_UserInfo.Controls.Add(this.label3);
            this.TP_UserInfo.Controls.Add(this.label2);
            this.TP_UserInfo.Controls.Add(this.L_UserID);
            this.TP_UserInfo.Controls.Add(this.label1);
            this.TP_UserInfo.Location = new System.Drawing.Point(4, 27);
            this.TP_UserInfo.Name = "TP_UserInfo";
            this.TP_UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_UserInfo.Size = new System.Drawing.Size(1098, 520);
            this.TP_UserInfo.TabIndex = 1;
            this.TP_UserInfo.Text = "User Info";
            this.TP_UserInfo.UseVisualStyleBackColor = true;
            // 
            // CB_IsActive
            // 
            this.CB_IsActive.AutoSize = true;
            this.CB_IsActive.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_IsActive.Location = new System.Drawing.Point(323, 220);
            this.CB_IsActive.Name = "CB_IsActive";
            this.CB_IsActive.Size = new System.Drawing.Size(142, 27);
            this.CB_IsActive.TabIndex = 8;
            this.CB_IsActive.Text = "IsActive :";
            this.CB_IsActive.UseVisualStyleBackColor = true;
            // 
            // B_Save
            // 
            this.B_Save.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Save.ForeColor = System.Drawing.Color.Black;
            this.B_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Save.ImageIndex = 2;
            this.B_Save.ImageList = this.imageList1;
            this.B_Save.Location = new System.Drawing.Point(665, 152);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(151, 45);
            this.B_Save.TabIndex = 4;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // TB_ConfirmPassword
            // 
            this.TB_ConfirmPassword.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ConfirmPassword.Location = new System.Drawing.Point(282, 172);
            this.TB_ConfirmPassword.Name = "TB_ConfirmPassword";
            this.TB_ConfirmPassword.PasswordChar = '*';
            this.TB_ConfirmPassword.Size = new System.Drawing.Size(219, 27);
            this.TB_ConfirmPassword.TabIndex = 7;
            this.TB_ConfirmPassword.TextChanged += new System.EventHandler(this.TB_ConfirmPassword_TextChanged);
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(282, 132);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(219, 27);
            this.TB_Password.TabIndex = 6;
            this.TB_Password.TextChanged += new System.EventHandler(this.TB_Password_TextChanged);
            // 
            // TB_UserName
            // 
            this.TB_UserName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserName.Location = new System.Drawing.Point(282, 94);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(219, 27);
            this.TB_UserName.TabIndex = 5;
            this.TB_UserName.TextChanged += new System.EventHandler(this.TB_UserName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password         :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName         :";
            // 
            // L_UserID
            // 
            this.L_UserID.AutoSize = true;
            this.L_UserID.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_UserID.ForeColor = System.Drawing.Color.Red;
            this.L_UserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_UserID.ImageIndex = 3;
            this.L_UserID.ImageList = this.imageList1;
            this.L_UserID.Location = new System.Drawing.Point(258, 37);
            this.L_UserID.Name = "L_UserID";
            this.L_UserID.Size = new System.Drawing.Size(90, 27);
            this.L_UserID.TabIndex = 1;
            this.L_UserID.Text = "   N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(123, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.Black;
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Close.ImageIndex = 1;
            this.B_Close.ImageList = this.imageList1;
            this.B_Close.Location = new System.Drawing.Point(868, 635);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(190, 45);
            this.B_Close.TabIndex = 3;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // EP1
            // 
            this.EP1.ContainerControl = this;
            // 
            // Frm_AddEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 692);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.TC_AddEditUsers);
            this.Controls.Add(this.L_Title);
            this.Name = "Frm_AddEditUsers";
            this.Text = "AddEditUsers";
            this.Load += new System.EventHandler(this.Frm_AddEditUsers_Load);
            this.TC_AddEditUsers.ResumeLayout(false);
            this.TP_Person.ResumeLayout(false);
            this.TP_UserInfo.ResumeLayout(false);
            this.TP_UserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Title;
        private System.Windows.Forms.TabControl TC_AddEditUsers;
        private System.Windows.Forms.TabPage TP_Person;
        private System.Windows.Forms.TabPage TP_UserInfo;
        private PersonCardAndFind UC_PersonCard;
        private System.Windows.Forms.Button B_Next;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Label L_UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ConfirmPassword;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider EP1;
        private System.Windows.Forms.CheckBox CB_IsActive;
    }
}