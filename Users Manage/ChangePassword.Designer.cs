namespace DVLDProject
{
    partial class Frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_CurrentPassword = new System.Windows.Forms.TextBox();
            this.TB_NewPassword = new System.Windows.Forms.TextBox();
            this.TB_NewPassword2 = new System.Windows.Forms.TextBox();
            this.EP_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.B_ChangePassword = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.B_Close = new System.Windows.Forms.Button();
            this.UC_UserCard = new DVLDProject.UserCard();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 637);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Password     :";
            // 
            // TB_CurrentPassword
            // 
            this.TB_CurrentPassword.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CurrentPassword.Location = new System.Drawing.Point(255, 555);
            this.TB_CurrentPassword.Name = "TB_CurrentPassword";
            this.TB_CurrentPassword.PasswordChar = '*';
            this.TB_CurrentPassword.Size = new System.Drawing.Size(252, 29);
            this.TB_CurrentPassword.TabIndex = 4;
            this.TB_CurrentPassword.TextChanged += new System.EventHandler(this.TB_CurrentPassword_TextChanged);
            // 
            // TB_NewPassword
            // 
            this.TB_NewPassword.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NewPassword.Location = new System.Drawing.Point(255, 593);
            this.TB_NewPassword.Name = "TB_NewPassword";
            this.TB_NewPassword.PasswordChar = '*';
            this.TB_NewPassword.Size = new System.Drawing.Size(252, 29);
            this.TB_NewPassword.TabIndex = 5;
            this.TB_NewPassword.TextChanged += new System.EventHandler(this.TB_NewPassword_TextChanged);
            // 
            // TB_NewPassword2
            // 
            this.TB_NewPassword2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NewPassword2.Location = new System.Drawing.Point(255, 635);
            this.TB_NewPassword2.Name = "TB_NewPassword2";
            this.TB_NewPassword2.PasswordChar = '*';
            this.TB_NewPassword2.Size = new System.Drawing.Size(252, 29);
            this.TB_NewPassword2.TabIndex = 6;
            this.TB_NewPassword2.TextChanged += new System.EventHandler(this.TB_NewPassword2_TextChanged);
            // 
            // EP_Password
            // 
            this.EP_Password.ContainerControl = this;
            // 
            // B_ChangePassword
            // 
            this.B_ChangePassword.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ChangePassword.ForeColor = System.Drawing.Color.Black;
            this.B_ChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_ChangePassword.ImageIndex = 0;
            this.B_ChangePassword.ImageList = this.imageList1;
            this.B_ChangePassword.Location = new System.Drawing.Point(589, 579);
            this.B_ChangePassword.Name = "B_ChangePassword";
            this.B_ChangePassword.Size = new System.Drawing.Size(299, 42);
            this.B_ChangePassword.TabIndex = 7;
            this.B_ChangePassword.Text = "Change Password";
            this.B_ChangePassword.UseVisualStyleBackColor = true;
            this.B_ChangePassword.Click += new System.EventHandler(this.B_ChangePassword_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "reset-password (1).png");
            this.imageList1.Images.SetKeyName(1, "close.png");
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.Black;
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Close.ImageIndex = 1;
            this.B_Close.ImageList = this.imageList1;
            this.B_Close.Location = new System.Drawing.Point(589, 618);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(299, 42);
            this.B_Close.TabIndex = 8;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // UC_UserCard
            // 
            this.UC_UserCard.Location = new System.Drawing.Point(0, 5);
            this.UC_UserCard.Name = "UC_UserCard";
            this.UC_UserCard.Size = new System.Drawing.Size(1230, 553);
            this.UC_UserCard.TabIndex = 9;
            // 
            // Frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 792);
            this.Controls.Add(this.UC_UserCard);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_ChangePassword);
            this.Controls.Add(this.TB_NewPassword2);
            this.Controls.Add(this.TB_NewPassword);
            this.Controls.Add(this.TB_CurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EP_Password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_CurrentPassword;
        private System.Windows.Forms.TextBox TB_NewPassword;
        private System.Windows.Forms.TextBox TB_NewPassword2;
        private System.Windows.Forms.ErrorProvider EP_Password;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_ChangePassword;
        private System.Windows.Forms.ImageList imageList1;
        private UserCard UC_UserCard;
    }
}