namespace DVLDProject
{
    partial class UserCard
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
            this.GB_UserInformaion = new System.Windows.Forms.GroupBox();
            this.L_IsActive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.L_UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UC_PersonCard = new DVLDProject.PersonCard();
            this.GB_UserInformaion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_UserInformaion
            // 
            this.GB_UserInformaion.Controls.Add(this.L_IsActive);
            this.GB_UserInformaion.Controls.Add(this.label5);
            this.GB_UserInformaion.Controls.Add(this.L_UserName);
            this.GB_UserInformaion.Controls.Add(this.label2);
            this.GB_UserInformaion.Controls.Add(this.L_UserID);
            this.GB_UserInformaion.Controls.Add(this.label1);
            this.GB_UserInformaion.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_UserInformaion.Location = new System.Drawing.Point(4, 447);
            this.GB_UserInformaion.Name = "GB_UserInformaion";
            this.GB_UserInformaion.Size = new System.Drawing.Size(1099, 81);
            this.GB_UserInformaion.TabIndex = 1;
            this.GB_UserInformaion.TabStop = false;
            this.GB_UserInformaion.Text = "Login Informaiotn";
            // 
            // L_IsActive
            // 
            this.L_IsActive.AutoSize = true;
            this.L_IsActive.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_IsActive.ForeColor = System.Drawing.Color.Black;
            this.L_IsActive.Location = new System.Drawing.Point(611, 31);
            this.L_IsActive.Name = "L_IsActive";
            this.L_IsActive.Size = new System.Drawing.Size(43, 23);
            this.L_IsActive.TabIndex = 5;
            this.L_IsActive.Text = " ##";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(463, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is Active :";
            // 
            // L_UserName
            // 
            this.L_UserName.AutoSize = true;
            this.L_UserName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_UserName.ForeColor = System.Drawing.Color.Black;
            this.L_UserName.Location = new System.Drawing.Point(352, 29);
            this.L_UserName.Name = "L_UserName";
            this.L_UserName.Size = new System.Drawing.Size(43, 23);
            this.L_UserName.TabIndex = 3;
            this.L_UserName.Text = " ##";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(215, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName :";
            // 
            // L_UserID
            // 
            this.L_UserID.AutoSize = true;
            this.L_UserID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_UserID.ForeColor = System.Drawing.Color.Red;
            this.L_UserID.Location = new System.Drawing.Point(124, 30);
            this.L_UserID.Name = "L_UserID";
            this.L_UserID.Size = new System.Drawing.Size(32, 23);
            this.L_UserID.TabIndex = 1;
            this.L_UserID.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID :";
            // 
            // UC_PersonCard
            // 
            this.UC_PersonCard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_PersonCard.Location = new System.Drawing.Point(4, 4);
            this.UC_PersonCard.Margin = new System.Windows.Forms.Padding(4);
            this.UC_PersonCard.Name = "UC_PersonCard";
            this.UC_PersonCard.Size = new System.Drawing.Size(1099, 436);
            this.UC_PersonCard.TabIndex = 2;
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UC_PersonCard);
            this.Controls.Add(this.GB_UserInformaion);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(1143, 553);
            this.Load += new System.EventHandler(this.UserCard_Load);
            this.GB_UserInformaion.ResumeLayout(false);
            this.GB_UserInformaion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GB_UserInformaion;
        private System.Windows.Forms.Label L_UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_IsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_UserName;
        private System.Windows.Forms.Label label2;
        private PersonCard UC_PersonCard;
    }
}
