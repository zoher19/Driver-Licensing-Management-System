namespace DVLDProject
{
    partial class Frm_RenewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RenewLicense));
            this.L_Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.L_RenwedLicenseID = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.L_OldLicenseID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_CreatedByUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_StatusDate = new System.Windows.Forms.Label();
            this.LL_PersonINfo = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.L_Date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.L_Applicant = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.L_Fees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.L_Type = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.L_Status = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LL_ShowLicense = new System.Windows.Forms.LinkLabel();
            this.LL_ShowLicenseHistore = new System.Windows.Forms.LinkLabel();
            this.B_Issue = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.GB_ReplacementFor = new System.Windows.Forms.GroupBox();
            this.RB_DemagedLicense = new System.Windows.Forms.RadioButton();
            this.RB_LostLicense = new System.Windows.Forms.RadioButton();
            this.UC_FindLicenseRenew = new DVLDProject.FindLicenseForRenew();
            this.groupBox1.SuspendLayout();
            this.GB_ReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Title.Location = new System.Drawing.Point(93, 12);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(362, 55);
            this.L_Title.TabIndex = 0;
            this.L_Title.Text = "Renew Lciense";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_RenwedLicenseID);
            this.groupBox1.Controls.Add(this.LL_ShowLicense);
            this.groupBox1.Controls.Add(this.LL_ShowLicenseHistore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.L_OldLicenseID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.L_CreatedByUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.L_StatusDate);
            this.groupBox1.Controls.Add(this.LL_PersonINfo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.L_Date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.L_Applicant);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.L_Fees);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.L_Type);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.L_Status);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.L_ID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 545);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info";
            // 
            // L_RenwedLicenseID
            // 
            this.L_RenwedLicenseID.AutoSize = true;
            this.L_RenwedLicenseID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_RenwedLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_RenwedLicenseID.ImageIndex = 4;
            this.L_RenwedLicenseID.ImageList = this.imageList1;
            this.L_RenwedLicenseID.Location = new System.Drawing.Point(889, 172);
            this.L_RenwedLicenseID.Name = "L_RenwedLicenseID";
            this.L_RenwedLicenseID.Size = new System.Drawing.Size(65, 23);
            this.L_RenwedLicenseID.TabIndex = 42;
            this.L_RenwedLicenseID.Text = "   ##";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "profile.png");
            this.imageList1.Images.SetKeyName(1, "user (5).png");
            this.imageList1.Images.SetKeyName(2, "charge.png");
            this.imageList1.Images.SetKeyName(3, "schedule.png");
            this.imageList1.Images.SetKeyName(4, "face-scan.png");
            this.imageList1.Images.SetKeyName(5, "writing.png");
            this.imageList1.Images.SetKeyName(6, "license.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(705, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "New License ID :";
            // 
            // L_OldLicenseID
            // 
            this.L_OldLicenseID.AutoSize = true;
            this.L_OldLicenseID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_OldLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_OldLicenseID.ImageIndex = 4;
            this.L_OldLicenseID.ImageList = this.imageList1;
            this.L_OldLicenseID.Location = new System.Drawing.Point(889, 135);
            this.L_OldLicenseID.Name = "L_OldLicenseID";
            this.L_OldLicenseID.Size = new System.Drawing.Size(65, 23);
            this.L_OldLicenseID.TabIndex = 40;
            this.L_OldLicenseID.Text = "   ##";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(705, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Old License ID :";
            // 
            // L_CreatedByUser
            // 
            this.L_CreatedByUser.AutoSize = true;
            this.L_CreatedByUser.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CreatedByUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_CreatedByUser.ImageIndex = 1;
            this.L_CreatedByUser.ImageList = this.imageList1;
            this.L_CreatedByUser.Location = new System.Drawing.Point(889, 100);
            this.L_CreatedByUser.Name = "L_CreatedByUser";
            this.L_CreatedByUser.Size = new System.Drawing.Size(65, 23);
            this.L_CreatedByUser.TabIndex = 38;
            this.L_CreatedByUser.Text = "   ##";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID:";
            // 
            // L_StatusDate
            // 
            this.L_StatusDate.AutoSize = true;
            this.L_StatusDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_StatusDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_StatusDate.ImageIndex = 3;
            this.L_StatusDate.ImageList = this.imageList1;
            this.L_StatusDate.Location = new System.Drawing.Point(889, 57);
            this.L_StatusDate.Name = "L_StatusDate";
            this.L_StatusDate.Size = new System.Drawing.Size(65, 23);
            this.L_StatusDate.TabIndex = 37;
            this.L_StatusDate.Text = "   ##";
            // 
            // LL_PersonINfo
            // 
            this.LL_PersonINfo.AutoSize = true;
            this.LL_PersonINfo.Enabled = false;
            this.LL_PersonINfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_PersonINfo.Location = new System.Drawing.Point(582, 230);
            this.LL_PersonINfo.Name = "LL_PersonINfo";
            this.LL_PersonINfo.Size = new System.Drawing.Size(186, 23);
            this.LL_PersonINfo.TabIndex = 31;
            this.LL_PersonINfo.TabStop = true;
            this.LL_PersonINfo.Text = "View Person Info";
            this.LL_PersonINfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_PersonINfo_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Status:";
            // 
            // L_Date
            // 
            this.L_Date.AutoSize = true;
            this.L_Date.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Date.ImageIndex = 3;
            this.L_Date.ImageList = this.imageList1;
            this.L_Date.Location = new System.Drawing.Point(889, 18);
            this.L_Date.Name = "L_Date";
            this.L_Date.Size = new System.Drawing.Size(65, 23);
            this.L_Date.TabIndex = 36;
            this.L_Date.Text = "   ##";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Type:";
            // 
            // L_Applicant
            // 
            this.L_Applicant.AutoSize = true;
            this.L_Applicant.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Applicant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Applicant.ImageIndex = 0;
            this.L_Applicant.ImageList = this.imageList1;
            this.L_Applicant.Location = new System.Drawing.Point(136, 190);
            this.L_Applicant.Name = "L_Applicant";
            this.L_Applicant.Size = new System.Drawing.Size(65, 23);
            this.L_Applicant.TabIndex = 35;
            this.L_Applicant.Text = "   ##";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fees:";
            // 
            // L_Fees
            // 
            this.L_Fees.AutoSize = true;
            this.L_Fees.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Fees.ImageIndex = 2;
            this.L_Fees.ImageList = this.imageList1;
            this.L_Fees.Location = new System.Drawing.Point(136, 145);
            this.L_Fees.Name = "L_Fees";
            this.L_Fees.Size = new System.Drawing.Size(65, 23);
            this.L_Fees.TabIndex = 34;
            this.L_Fees.Text = "   ##";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Applicant:";
            // 
            // L_Type
            // 
            this.L_Type.AutoSize = true;
            this.L_Type.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Type.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Type.ImageIndex = 6;
            this.L_Type.ImageList = this.imageList1;
            this.L_Type.Location = new System.Drawing.Point(114, 100);
            this.L_Type.Name = "L_Type";
            this.L_Type.Size = new System.Drawing.Size(65, 23);
            this.L_Type.TabIndex = 33;
            this.L_Type.Text = "   ##";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(826, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Date:";
            // 
            // L_Status
            // 
            this.L_Status.AutoSize = true;
            this.L_Status.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Status.ImageIndex = 5;
            this.L_Status.ImageList = this.imageList1;
            this.L_Status.Location = new System.Drawing.Point(136, 57);
            this.L_Status.Name = "L_Status";
            this.L_Status.Size = new System.Drawing.Size(65, 23);
            this.L_Status.TabIndex = 32;
            this.L_Status.Text = "   ##";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(749, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Status Date:";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_ID.ImageIndex = 4;
            this.L_ID.ImageList = this.imageList1;
            this.L_ID.Location = new System.Drawing.Point(136, 18);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(65, 23);
            this.L_ID.TabIndex = 23;
            this.L_ID.Text = "   ##";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(705, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Created By User:";
            // 
            // LL_ShowLicense
            // 
            this.LL_ShowLicense.AutoSize = true;
            this.LL_ShowLicense.Enabled = false;
            this.LL_ShowLicense.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_ShowLicense.Location = new System.Drawing.Point(10, 233);
            this.LL_ShowLicense.Name = "LL_ShowLicense";
            this.LL_ShowLicense.Size = new System.Drawing.Size(142, 23);
            this.LL_ShowLicense.TabIndex = 44;
            this.LL_ShowLicense.TabStop = true;
            this.LL_ShowLicense.Text = "Show License";
            this.LL_ShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_ShowLicense_LinkClicked);
            // 
            // LL_ShowLicenseHistore
            // 
            this.LL_ShowLicenseHistore.AutoSize = true;
            this.LL_ShowLicenseHistore.Enabled = false;
            this.LL_ShowLicenseHistore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_ShowLicenseHistore.Location = new System.Drawing.Point(245, 233);
            this.LL_ShowLicenseHistore.Name = "LL_ShowLicenseHistore";
            this.LL_ShowLicenseHistore.Size = new System.Drawing.Size(230, 23);
            this.LL_ShowLicenseHistore.TabIndex = 43;
            this.LL_ShowLicenseHistore.TabStop = true;
            this.LL_ShowLicenseHistore.Text = "Show License Histore";
            this.LL_ShowLicenseHistore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_ShowLicenseHistore_LinkClicked);
            // 
            // B_Issue
            // 
            this.B_Issue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Issue.Location = new System.Drawing.Point(961, 807);
            this.B_Issue.Name = "B_Issue";
            this.B_Issue.Size = new System.Drawing.Size(171, 41);
            this.B_Issue.TabIndex = 3;
            this.B_Issue.Text = "Issue";
            this.B_Issue.UseVisualStyleBackColor = true;
            this.B_Issue.Click += new System.EventHandler(this.B_Issue_Click);
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.Location = new System.Drawing.Point(792, 807);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(163, 41);
            this.B_Close.TabIndex = 4;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // GB_ReplacementFor
            // 
            this.GB_ReplacementFor.Controls.Add(this.RB_LostLicense);
            this.GB_ReplacementFor.Controls.Add(this.RB_DemagedLicense);
            this.GB_ReplacementFor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ReplacementFor.Location = new System.Drawing.Point(815, 12);
            this.GB_ReplacementFor.Name = "GB_ReplacementFor";
            this.GB_ReplacementFor.Size = new System.Drawing.Size(263, 131);
            this.GB_ReplacementFor.TabIndex = 45;
            this.GB_ReplacementFor.TabStop = false;
            this.GB_ReplacementFor.Text = "Replacement Fro";
            // 
            // RB_DemagedLicense
            // 
            this.RB_DemagedLicense.AutoSize = true;
            this.RB_DemagedLicense.Checked = true;
            this.RB_DemagedLicense.Location = new System.Drawing.Point(51, 33);
            this.RB_DemagedLicense.Name = "RB_DemagedLicense";
            this.RB_DemagedLicense.Size = new System.Drawing.Size(149, 22);
            this.RB_DemagedLicense.TabIndex = 0;
            this.RB_DemagedLicense.TabStop = true;
            this.RB_DemagedLicense.Text = "Damaged License";
            this.RB_DemagedLicense.UseVisualStyleBackColor = true;
            // 
            // RB_LostLicense
            // 
            this.RB_LostLicense.AutoSize = true;
            this.RB_LostLicense.Location = new System.Drawing.Point(51, 70);
            this.RB_LostLicense.Name = "RB_LostLicense";
            this.RB_LostLicense.Size = new System.Drawing.Size(125, 22);
            this.RB_LostLicense.TabIndex = 1;
            this.RB_LostLicense.Text = "Lost License";
            this.RB_LostLicense.UseVisualStyleBackColor = true;
            // 
            // UC_FindLicenseRenew
            // 
            this.UC_FindLicenseRenew.Location = new System.Drawing.Point(12, 67);
            this.UC_FindLicenseRenew.Name = "UC_FindLicenseRenew";
            this.UC_FindLicenseRenew.Size = new System.Drawing.Size(957, 500);
            this.UC_FindLicenseRenew.TabIndex = 1;
            // 
            // Frm_RenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 880);
            this.Controls.Add(this.GB_ReplacementFor);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Issue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UC_FindLicenseRenew);
            this.Controls.Add(this.L_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_RenewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_RenewLicense";
            this.Load += new System.EventHandler(this.Frm_RenewLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_ReplacementFor.ResumeLayout(false);
            this.GB_ReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Title;
        private FindLicenseForRenew UC_FindLicenseRenew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label L_CreatedByUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_StatusDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_Date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label L_Applicant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label L_Fees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label L_Type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label L_Status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel LL_PersonINfo;
        private System.Windows.Forms.LinkLabel LL_ShowLicense;
        private System.Windows.Forms.LinkLabel LL_ShowLicenseHistore;
        private System.Windows.Forms.Label L_RenwedLicenseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label L_OldLicenseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Issue;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.GroupBox GB_ReplacementFor;
        private System.Windows.Forms.RadioButton RB_LostLicense;
        private System.Windows.Forms.RadioButton RB_DemagedLicense;
    }
}