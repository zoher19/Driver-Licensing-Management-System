namespace DVLDProject
{
    partial class Frm_DetainorRelaseLicense
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
            this.GB_DetainInfo = new System.Windows.Forms.GroupBox();
            this.LL_ShowLicense = new System.Windows.Forms.LinkLabel();
            this.LL_ShowLicenseHistore = new System.Windows.Forms.LinkLabel();
            this.L_FineFees = new System.Windows.Forms.Label();
            this.LL_PersonINfo = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.L_CreatedByUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.L_LicenseID = new System.Windows.Forms.Label();
            this.L_ApplicationFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_DetainDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_DetainID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.B_Issue = new System.Windows.Forms.Button();
            this.L_Title = new System.Windows.Forms.Label();
            this.RC_Find = new DVLDProject.FindLicenseForRenew();
            this.GB_DetainInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_DetainInfo
            // 
            this.GB_DetainInfo.Controls.Add(this.LL_ShowLicense);
            this.GB_DetainInfo.Controls.Add(this.LL_ShowLicenseHistore);
            this.GB_DetainInfo.Controls.Add(this.L_FineFees);
            this.GB_DetainInfo.Controls.Add(this.LL_PersonINfo);
            this.GB_DetainInfo.Controls.Add(this.label6);
            this.GB_DetainInfo.Controls.Add(this.label4);
            this.GB_DetainInfo.Controls.Add(this.L_CreatedByUser);
            this.GB_DetainInfo.Controls.Add(this.label5);
            this.GB_DetainInfo.Controls.Add(this.L_LicenseID);
            this.GB_DetainInfo.Controls.Add(this.L_ApplicationFees);
            this.GB_DetainInfo.Controls.Add(this.label3);
            this.GB_DetainInfo.Controls.Add(this.L_DetainDate);
            this.GB_DetainInfo.Controls.Add(this.label2);
            this.GB_DetainInfo.Controls.Add(this.L_DetainID);
            this.GB_DetainInfo.Controls.Add(this.label1);
            this.GB_DetainInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DetainInfo.Location = new System.Drawing.Point(3, 525);
            this.GB_DetainInfo.Name = "GB_DetainInfo";
            this.GB_DetainInfo.Size = new System.Drawing.Size(985, 180);
            this.GB_DetainInfo.TabIndex = 2;
            this.GB_DetainInfo.TabStop = false;
            this.GB_DetainInfo.Text = "Detain Info";
            this.GB_DetainInfo.Enter += new System.EventHandler(this.GB_DetainInfo_Enter);
            // 
            // LL_ShowLicense
            // 
            this.LL_ShowLicense.AutoSize = true;
            this.LL_ShowLicense.Enabled = false;
            this.LL_ShowLicense.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_ShowLicense.Location = new System.Drawing.Point(9, 154);
            this.LL_ShowLicense.Name = "LL_ShowLicense";
            this.LL_ShowLicense.Size = new System.Drawing.Size(142, 23);
            this.LL_ShowLicense.TabIndex = 47;
            this.LL_ShowLicense.TabStop = true;
            this.LL_ShowLicense.Text = "Show License";
            this.LL_ShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_ShowLicense_LinkClicked);
            // 
            // LL_ShowLicenseHistore
            // 
            this.LL_ShowLicenseHistore.AutoSize = true;
            this.LL_ShowLicenseHistore.Enabled = false;
            this.LL_ShowLicenseHistore.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_ShowLicenseHistore.Location = new System.Drawing.Point(244, 154);
            this.LL_ShowLicenseHistore.Name = "LL_ShowLicenseHistore";
            this.LL_ShowLicenseHistore.Size = new System.Drawing.Size(230, 23);
            this.LL_ShowLicenseHistore.TabIndex = 46;
            this.LL_ShowLicenseHistore.TabStop = true;
            this.LL_ShowLicenseHistore.Text = "Show License Histore";
            this.LL_ShowLicenseHistore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_ShowLicenseHistore_LinkClicked);
            // 
            // L_FineFees
            // 
            this.L_FineFees.AutoSize = true;
            this.L_FineFees.Location = new System.Drawing.Point(619, 122);
            this.L_FineFees.Name = "L_FineFees";
            this.L_FineFees.Size = new System.Drawing.Size(40, 18);
            this.L_FineFees.TabIndex = 11;
            this.L_FineFees.Text = "  ##";
            // 
            // LL_PersonINfo
            // 
            this.LL_PersonINfo.AutoSize = true;
            this.LL_PersonINfo.Enabled = false;
            this.LL_PersonINfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LL_PersonINfo.Location = new System.Drawing.Point(581, 151);
            this.LL_PersonINfo.Name = "LL_PersonINfo";
            this.LL_PersonINfo.Size = new System.Drawing.Size(186, 23);
            this.LL_PersonINfo.TabIndex = 45;
            this.LL_PersonINfo.TabStop = true;
            this.LL_PersonINfo.Text = "View Person Info";
            this.LL_PersonINfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_PersonINfo_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fine Fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "License ID :";
            // 
            // L_CreatedByUser
            // 
            this.L_CreatedByUser.AutoSize = true;
            this.L_CreatedByUser.Location = new System.Drawing.Point(619, 80);
            this.L_CreatedByUser.Name = "L_CreatedByUser";
            this.L_CreatedByUser.Size = new System.Drawing.Size(40, 18);
            this.L_CreatedByUser.TabIndex = 9;
            this.L_CreatedByUser.Text = "  ##";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Created By User  :";
            // 
            // L_LicenseID
            // 
            this.L_LicenseID.AutoSize = true;
            this.L_LicenseID.Location = new System.Drawing.Point(619, 35);
            this.L_LicenseID.Name = "L_LicenseID";
            this.L_LicenseID.Size = new System.Drawing.Size(40, 18);
            this.L_LicenseID.TabIndex = 7;
            this.L_LicenseID.Text = "  ##";
            // 
            // L_ApplicationFees
            // 
            this.L_ApplicationFees.AutoSize = true;
            this.L_ApplicationFees.Location = new System.Drawing.Point(195, 101);
            this.L_ApplicationFees.Name = "L_ApplicationFees";
            this.L_ApplicationFees.Size = new System.Drawing.Size(40, 18);
            this.L_ApplicationFees.TabIndex = 6;
            this.L_ApplicationFees.Text = "  ##";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Application Fees :";
            // 
            // L_DetainDate
            // 
            this.L_DetainDate.AutoSize = true;
            this.L_DetainDate.Location = new System.Drawing.Point(192, 68);
            this.L_DetainDate.Name = "L_DetainDate";
            this.L_DetainDate.Size = new System.Drawing.Size(40, 18);
            this.L_DetainDate.TabIndex = 3;
            this.L_DetainDate.Text = "  ##";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detain Date :";
            // 
            // L_DetainID
            // 
            this.L_DetainID.AutoSize = true;
            this.L_DetainID.Location = new System.Drawing.Point(192, 35);
            this.L_DetainID.Name = "L_DetainID";
            this.L_DetainID.Size = new System.Drawing.Size(40, 18);
            this.L_DetainID.TabIndex = 1;
            this.L_DetainID.Text = "  ##";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain ID :";
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.Location = new System.Drawing.Point(636, 721);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(163, 41);
            this.B_Close.TabIndex = 49;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // B_Issue
            // 
            this.B_Issue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Issue.Location = new System.Drawing.Point(805, 721);
            this.B_Issue.Name = "B_Issue";
            this.B_Issue.Size = new System.Drawing.Size(171, 41);
            this.B_Issue.TabIndex = 48;
            this.B_Issue.Text = "Issue";
            this.B_Issue.UseVisualStyleBackColor = true;
            this.B_Issue.Click += new System.EventHandler(this.B_Issue_Click);
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Title.Location = new System.Drawing.Point(355, 20);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(240, 33);
            this.L_Title.TabIndex = 50;
            this.L_Title.Text = "Detaine License";
            this.L_Title.Click += new System.EventHandler(this.L_Title_Click);
            // 
            // RC_Find
            // 
            this.RC_Find.Location = new System.Drawing.Point(3, 56);
            this.RC_Find.Name = "RC_Find";
            this.RC_Find.Size = new System.Drawing.Size(944, 463);
            this.RC_Find.TabIndex = 3;
            this.RC_Find.Load += new System.EventHandler(this.findLicenseForRenew1_Load);
            // 
            // Frm_DetainorRelaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 774);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Issue);
            this.Controls.Add(this.RC_Find);
            this.Controls.Add(this.GB_DetainInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_DetainorRelaseLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_DetainorRelaseLicense";
            this.Load += new System.EventHandler(this.Frm_DetainorRelaseLicense_Load);
            this.GB_DetainInfo.ResumeLayout(false);
            this.GB_DetainInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_DetainInfo;
        private System.Windows.Forms.Label L_FineFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label L_CreatedByUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_LicenseID;
        private System.Windows.Forms.Label L_ApplicationFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_DetainDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_DetainID;
        private System.Windows.Forms.Label label1;
        private FindLicenseForRenew RC_Find;
        private System.Windows.Forms.LinkLabel LL_ShowLicense;
        private System.Windows.Forms.LinkLabel LL_ShowLicenseHistore;
        private System.Windows.Forms.LinkLabel LL_PersonINfo;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_Issue;
        private System.Windows.Forms.Label L_Title;
    }
}