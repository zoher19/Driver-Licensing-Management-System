namespace DVLDProject
{
    partial class Frm_TakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TakeTest));
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.L_Fees = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_ClassName = new System.Windows.Forms.Label();
            this.L_PasedTests = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_AppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Title = new System.Windows.Forms.Label();
            this.PB_PhotoTitle = new System.Windows.Forms.PictureBox();
            this.B_Close = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.L_TheResult = new System.Windows.Forms.Label();
            this.RB_Pass = new System.Windows.Forms.RadioButton();
            this.RB_Failed = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Note = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PhotoTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP_Date
            // 
            this.DTP_Date.Enabled = false;
            this.DTP_Date.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Date.Location = new System.Drawing.Point(391, 303);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(143, 27);
            this.DTP_Date.TabIndex = 27;
            // 
            // L_Fees
            // 
            this.L_Fees.AutoSize = true;
            this.L_Fees.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Fees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Fees.ImageIndex = 3;
            this.L_Fees.ImageList = this.imageList1;
            this.L_Fees.Location = new System.Drawing.Point(382, 345);
            this.L_Fees.Name = "L_Fees";
            this.L_Fees.Size = new System.Drawing.Size(65, 23);
            this.L_Fees.TabIndex = 26;
            this.L_Fees.Text = "   0$";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "id-card (1).png");
            this.imageList1.Images.SetKeyName(1, "programmer.png");
            this.imageList1.Images.SetKeyName(2, "businessman.png");
            this.imageList1.Images.SetKeyName(3, "coin.png");
            this.imageList1.Images.SetKeyName(4, "calendar (1).png");
            this.imageList1.Images.SetKeyName(5, "approval.png");
            this.imageList1.Images.SetKeyName(6, "check-list.png");
            this.imageList1.Images.SetKeyName(7, "knowledge.png");
            this.imageList1.Images.SetKeyName(8, "member-card.png");
            this.imageList1.Images.SetKeyName(9, "test (3).png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fees :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date :";
            // 
            // L_ClassName
            // 
            this.L_ClassName.AutoSize = true;
            this.L_ClassName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ClassName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_ClassName.ImageIndex = 8;
            this.L_ClassName.ImageList = this.imageList1;
            this.L_ClassName.Location = new System.Drawing.Point(382, 220);
            this.L_ClassName.Name = "L_ClassName";
            this.L_ClassName.Size = new System.Drawing.Size(65, 23);
            this.L_ClassName.TabIndex = 23;
            this.L_ClassName.Text = "   ##";
            // 
            // L_PasedTests
            // 
            this.L_PasedTests.AutoSize = true;
            this.L_PasedTests.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PasedTests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_PasedTests.ImageIndex = 9;
            this.L_PasedTests.ImageList = this.imageList1;
            this.L_PasedTests.Location = new System.Drawing.Point(387, 265);
            this.L_PasedTests.Name = "L_PasedTests";
            this.L_PasedTests.Size = new System.Drawing.Size(76, 23);
            this.L_PasedTests.TabIndex = 22;
            this.L_PasedTests.Text = "   0/3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pased Tess :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Applied For License :";
            // 
            // L_AppID
            // 
            this.L_AppID.AutoSize = true;
            this.L_AppID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_AppID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_AppID.ImageIndex = 0;
            this.L_AppID.ImageList = this.imageList1;
            this.L_AppID.Location = new System.Drawing.Point(382, 177);
            this.L_AppID.Name = "L_AppID";
            this.L_AppID.Size = new System.Drawing.Size(65, 23);
            this.L_AppID.TabIndex = 19;
            this.L_AppID.Text = "   ##";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "D_LAppID :";
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Title.Location = new System.Drawing.Point(209, 99);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(233, 38);
            this.L_Title.TabIndex = 17;
            this.L_Title.Text = "Schedul Test";
            // 
            // PB_PhotoTitle
            // 
            this.PB_PhotoTitle.BackgroundImage = global::DVLDProject.Properties.Resources.vision__1_1;
            this.PB_PhotoTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_PhotoTitle.Location = new System.Drawing.Point(3, 0);
            this.PB_PhotoTitle.Name = "PB_PhotoTitle";
            this.PB_PhotoTitle.Size = new System.Drawing.Size(137, 139);
            this.PB_PhotoTitle.TabIndex = 16;
            this.PB_PhotoTitle.TabStop = false;
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.Turquoise;
            this.B_Close.Location = new System.Drawing.Point(576, 520);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(153, 40);
            this.B_Close.TabIndex = 29;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // B_Save
            // 
            this.B_Save.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Save.ForeColor = System.Drawing.Color.Turquoise;
            this.B_Save.Location = new System.Drawing.Point(573, 474);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(156, 40);
            this.B_Save.TabIndex = 28;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // L_TheResult
            // 
            this.L_TheResult.AutoSize = true;
            this.L_TheResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_TheResult.Location = new System.Drawing.Point(12, 435);
            this.L_TheResult.Name = "L_TheResult";
            this.L_TheResult.Size = new System.Drawing.Size(142, 23);
            this.L_TheResult.TabIndex = 30;
            this.L_TheResult.Text = "The Result :";
            // 
            // RB_Pass
            // 
            this.RB_Pass.AutoSize = true;
            this.RB_Pass.Checked = true;
            this.RB_Pass.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Pass.Location = new System.Drawing.Point(168, 437);
            this.RB_Pass.Name = "RB_Pass";
            this.RB_Pass.Size = new System.Drawing.Size(84, 24);
            this.RB_Pass.TabIndex = 31;
            this.RB_Pass.TabStop = true;
            this.RB_Pass.Text = "Passed";
            this.RB_Pass.UseVisualStyleBackColor = true;
            // 
            // RB_Failed
            // 
            this.RB_Failed.AutoSize = true;
            this.RB_Failed.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Failed.Location = new System.Drawing.Point(265, 437);
            this.RB_Failed.Name = "RB_Failed";
            this.RB_Failed.Size = new System.Drawing.Size(84, 24);
            this.RB_Failed.TabIndex = 32;
            this.RB_Failed.Text = "Failed";
            this.RB_Failed.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Note:";
            // 
            // TB_Note
            // 
            this.TB_Note.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Note.Location = new System.Drawing.Point(104, 481);
            this.TB_Note.Multiline = true;
            this.TB_Note.Name = "TB_Note";
            this.TB_Note.Size = new System.Drawing.Size(354, 83);
            this.TB_Note.TabIndex = 34;
            // 
            // Frm_TakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 576);
            this.Controls.Add(this.TB_Note);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RB_Failed);
            this.Controls.Add(this.RB_Pass);
            this.Controls.Add(this.L_TheResult);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.L_Fees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_ClassName);
            this.Controls.Add(this.L_PasedTests);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_AppID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.PB_PhotoTitle);
            this.Name = "Frm_TakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.Frm_TakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_PhotoTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.Label L_Fees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_ClassName;
        private System.Windows.Forms.Label L_PasedTests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_AppID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Title;
        private System.Windows.Forms.PictureBox PB_PhotoTitle;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label L_TheResult;
        private System.Windows.Forms.RadioButton RB_Pass;
        private System.Windows.Forms.RadioButton RB_Failed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Note;
    }
}