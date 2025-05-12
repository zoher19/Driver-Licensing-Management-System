namespace DVLDProject
{
    partial class Frm_AddNewLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddNewLocalDrivingLicense));
            this.TC_AddLocalDrivingLicense = new System.Windows.Forms.TabControl();
            this.TP_PersonInfo = new System.Windows.Forms.TabPage();
            this.B_Next = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UC_PersonCard = new DVLDProject.PersonCardAndFind();
            this.TP_ApplicationInfo = new System.Windows.Forms.TabPage();
            this.B_Save = new System.Windows.Forms.Button();
            this.L_CreatedByUser = new System.Windows.Forms.Label();
            this.ll = new System.Windows.Forms.Label();
            this.L_Fees = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_LicenseClass = new System.Windows.Forms.ComboBox();
            this.L_ApplicationDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_ApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TC_AddLocalDrivingLicense.SuspendLayout();
            this.TP_PersonInfo.SuspendLayout();
            this.TP_ApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_AddLocalDrivingLicense
            // 
            this.TC_AddLocalDrivingLicense.Controls.Add(this.TP_PersonInfo);
            this.TC_AddLocalDrivingLicense.Controls.Add(this.TP_ApplicationInfo);
            this.TC_AddLocalDrivingLicense.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC_AddLocalDrivingLicense.Location = new System.Drawing.Point(2, 142);
            this.TC_AddLocalDrivingLicense.Name = "TC_AddLocalDrivingLicense";
            this.TC_AddLocalDrivingLicense.SelectedIndex = 0;
            this.TC_AddLocalDrivingLicense.Size = new System.Drawing.Size(1074, 604);
            this.TC_AddLocalDrivingLicense.TabIndex = 0;
            // 
            // TP_PersonInfo
            // 
            this.TP_PersonInfo.Controls.Add(this.B_Next);
            this.TP_PersonInfo.Controls.Add(this.UC_PersonCard);
            this.TP_PersonInfo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_PersonInfo.Location = new System.Drawing.Point(4, 31);
            this.TP_PersonInfo.Name = "TP_PersonInfo";
            this.TP_PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_PersonInfo.Size = new System.Drawing.Size(1066, 569);
            this.TP_PersonInfo.TabIndex = 0;
            this.TP_PersonInfo.Text = "Person Info";
            this.TP_PersonInfo.UseVisualStyleBackColor = true;
            // 
            // B_Next
            // 
            this.B_Next.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Next.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.B_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Next.ImageIndex = 3;
            this.B_Next.ImageList = this.imageList1;
            this.B_Next.Location = new System.Drawing.Point(857, 517);
            this.B_Next.Name = "B_Next";
            this.B_Next.Size = new System.Drawing.Size(200, 45);
            this.B_Next.TabIndex = 3;
            this.B_Next.Text = "Next";
            this.B_Next.UseVisualStyleBackColor = true;
            this.B_Next.Click += new System.EventHandler(this.B_Next_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "calendar.png");
            this.imageList1.Images.SetKeyName(1, "close.png");
            this.imageList1.Images.SetKeyName(2, "diskette (1).png");
            this.imageList1.Images.SetKeyName(3, "next-button.png");
            // 
            // UC_PersonCard
            // 
            this.UC_PersonCard.Location = new System.Drawing.Point(6, 3);
            this.UC_PersonCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UC_PersonCard.Name = "UC_PersonCard";
            this.UC_PersonCard.Person = null;
            this.UC_PersonCard.Size = new System.Drawing.Size(1064, 559);
            this.UC_PersonCard.TabIndex = 0;
            // 
            // TP_ApplicationInfo
            // 
            this.TP_ApplicationInfo.Controls.Add(this.B_Save);
            this.TP_ApplicationInfo.Controls.Add(this.L_CreatedByUser);
            this.TP_ApplicationInfo.Controls.Add(this.ll);
            this.TP_ApplicationInfo.Controls.Add(this.L_Fees);
            this.TP_ApplicationInfo.Controls.Add(this.label6);
            this.TP_ApplicationInfo.Controls.Add(this.CB_LicenseClass);
            this.TP_ApplicationInfo.Controls.Add(this.L_ApplicationDate);
            this.TP_ApplicationInfo.Controls.Add(this.label4);
            this.TP_ApplicationInfo.Controls.Add(this.label3);
            this.TP_ApplicationInfo.Controls.Add(this.L_ApplicationID);
            this.TP_ApplicationInfo.Controls.Add(this.label2);
            this.TP_ApplicationInfo.Location = new System.Drawing.Point(4, 31);
            this.TP_ApplicationInfo.Name = "TP_ApplicationInfo";
            this.TP_ApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_ApplicationInfo.Size = new System.Drawing.Size(1066, 569);
            this.TP_ApplicationInfo.TabIndex = 1;
            this.TP_ApplicationInfo.Text = "Application Info";
            this.TP_ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // B_Save
            // 
            this.B_Save.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Save.ForeColor = System.Drawing.Color.Black;
            this.B_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Save.ImageIndex = 2;
            this.B_Save.ImageList = this.imageList1;
            this.B_Save.Location = new System.Drawing.Point(590, 264);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(149, 45);
            this.B_Save.TabIndex = 6;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // L_CreatedByUser
            // 
            this.L_CreatedByUser.AutoSize = true;
            this.L_CreatedByUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CreatedByUser.Location = new System.Drawing.Point(350, 286);
            this.L_CreatedByUser.Name = "L_CreatedByUser";
            this.L_CreatedByUser.Size = new System.Drawing.Size(32, 23);
            this.L_CreatedByUser.TabIndex = 9;
            this.L_CreatedByUser.Text = "##";
            this.L_CreatedByUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll.Location = new System.Drawing.Point(77, 286);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(241, 23);
            this.ll.TabIndex = 8;
            this.ll.Text = "Created By User     :";
            this.ll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_Fees
            // 
            this.L_Fees.AutoSize = true;
            this.L_Fees.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fees.Location = new System.Drawing.Point(350, 235);
            this.L_Fees.Name = "L_Fees";
            this.L_Fees.Size = new System.Drawing.Size(65, 23);
            this.L_Fees.TabIndex = 7;
            this.L_Fees.Text = "0.0 $";
            this.L_Fees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Application Fees    :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_LicenseClass
            // 
            this.CB_LicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_LicenseClass.FormattingEnabled = true;
            this.CB_LicenseClass.Location = new System.Drawing.Point(361, 176);
            this.CB_LicenseClass.Name = "CB_LicenseClass";
            this.CB_LicenseClass.Size = new System.Drawing.Size(378, 30);
            this.CB_LicenseClass.TabIndex = 5;
            // 
            // L_ApplicationDate
            // 
            this.L_ApplicationDate.AutoSize = true;
            this.L_ApplicationDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ApplicationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_ApplicationDate.ImageIndex = 0;
            this.L_ApplicationDate.ImageList = this.imageList1;
            this.L_ApplicationDate.Location = new System.Drawing.Point(339, 128);
            this.L_ApplicationDate.Name = "L_ApplicationDate";
            this.L_ApplicationDate.Size = new System.Drawing.Size(76, 23);
            this.L_ApplicationDate.TabIndex = 4;
            this.L_ApplicationDate.Text = "   ###";
            this.L_ApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "License Class       :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Application Date    :";
            // 
            // L_ApplicationID
            // 
            this.L_ApplicationID.AutoSize = true;
            this.L_ApplicationID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ApplicationID.Location = new System.Drawing.Point(339, 71);
            this.L_ApplicationID.Name = "L_ApplicationID";
            this.L_ApplicationID.Size = new System.Drawing.Size(76, 23);
            this.L_ApplicationID.TabIndex = 1;
            this.L_ApplicationID.Text = "   N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L Application ID  :";
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Close.ImageIndex = 1;
            this.B_Close.ImageList = this.imageList1;
            this.B_Close.Location = new System.Drawing.Point(863, 752);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(200, 45);
            this.B_Close.TabIndex = 4;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(126, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Local Driving License Application";
            // 
            // Frm_AddNewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 802);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.TC_AddLocalDrivingLicense);
            this.Name = "Frm_AddNewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewLocalDrivingLicense";
            this.Load += new System.EventHandler(this.AddNewLocalDrivingLicense_Load);
            this.TC_AddLocalDrivingLicense.ResumeLayout(false);
            this.TP_PersonInfo.ResumeLayout(false);
            this.TP_ApplicationInfo.ResumeLayout(false);
            this.TP_ApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TC_AddLocalDrivingLicense;
        private System.Windows.Forms.TabPage TP_PersonInfo;
        private System.Windows.Forms.TabPage TP_ApplicationInfo;
        private PersonCardAndFind UC_PersonCard;
        private System.Windows.Forms.Button B_Next;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_CreatedByUser;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.Label L_Fees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_LicenseClass;
        private System.Windows.Forms.Label L_ApplicationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_ApplicationID;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.ImageList imageList1;
    }
}