namespace DVLDProject
{
    partial class ApplicationInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.L_ClassName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.L_PasedTests = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_AppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UC_AllicationBasicInfo = new DVLDProject.ApplicationBasicInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_ClassName);
            this.groupBox1.Controls.Add(this.L_PasedTests);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.L_AppID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1173, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Applicaion Info :";
            // 
            // L_ClassName
            // 
            this.L_ClassName.AutoSize = true;
            this.L_ClassName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ClassName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_ClassName.ImageIndex = 2;
            this.L_ClassName.ImageList = this.imageList1;
            this.L_ClassName.Location = new System.Drawing.Point(713, 53);
            this.L_ClassName.Name = "L_ClassName";
            this.L_ClassName.Size = new System.Drawing.Size(65, 23);
            this.L_ClassName.TabIndex = 5;
            this.L_ClassName.Text = "   ##";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "face-scan.png");
            this.imageList1.Images.SetKeyName(1, "list.png");
            this.imageList1.Images.SetKeyName(2, "info (1).png");
            // 
            // L_PasedTests
            // 
            this.L_PasedTests.AutoSize = true;
            this.L_PasedTests.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PasedTests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_PasedTests.ImageIndex = 1;
            this.L_PasedTests.ImageList = this.imageList1;
            this.L_PasedTests.Location = new System.Drawing.Point(592, 99);
            this.L_PasedTests.Name = "L_PasedTests";
            this.L_PasedTests.Size = new System.Drawing.Size(76, 23);
            this.L_PasedTests.TabIndex = 4;
            this.L_PasedTests.Text = "   0/3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pased Tess :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Applied For License :";
            // 
            // L_AppID
            // 
            this.L_AppID.AutoSize = true;
            this.L_AppID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AppID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_AppID.ImageIndex = 0;
            this.L_AppID.ImageList = this.imageList1;
            this.L_AppID.Location = new System.Drawing.Point(167, 53);
            this.L_AppID.Name = "L_AppID";
            this.L_AppID.Size = new System.Drawing.Size(65, 23);
            this.L_AppID.TabIndex = 1;
            this.L_AppID.Text = "   ##";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "D_LAppID :";
            // 
            // UC_AllicationBasicInfo
            // 
            this.UC_AllicationBasicInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_AllicationBasicInfo.Location = new System.Drawing.Point(3, 178);
            this.UC_AllicationBasicInfo.Name = "UC_AllicationBasicInfo";
            this.UC_AllicationBasicInfo.Size = new System.Drawing.Size(1173, 312);
            this.UC_AllicationBasicInfo.TabIndex = 1;
            // 
            // ApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UC_AllicationBasicInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "ApplicationInfo";
            this.Size = new System.Drawing.Size(1179, 493);
            this.Load += new System.EventHandler(this.ApplicationInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label L_ClassName;
        private System.Windows.Forms.Label L_PasedTests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_AppID;
        private ApplicationBasicInfo UC_AllicationBasicInfo;
    }
}
