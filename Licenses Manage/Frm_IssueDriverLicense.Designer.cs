namespace DVLDProject
{
    partial class Frm_IssueDriverLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IssueDriverLicense));
            this.L_Note = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Notes = new System.Windows.Forms.TextBox();
            this.B_Close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.B_Issue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UC_LocalApplicationInfo = new DVLDProject.ApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Note
            // 
            this.L_Note.AutoSize = true;
            this.L_Note.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Note.Location = new System.Drawing.Point(76, 540);
            this.L_Note.Name = "L_Note";
            this.L_Note.Size = new System.Drawing.Size(90, 27);
            this.L_Note.TabIndex = 1;
            this.L_Note.Text = "Note :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "*";
            // 
            // TB_Notes
            // 
            this.TB_Notes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Notes.Location = new System.Drawing.Point(186, 540);
            this.TB_Notes.Multiline = true;
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(585, 132);
            this.TB_Notes.TabIndex = 3;
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.BlueViolet;
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Close.ImageIndex = 1;
            this.B_Close.ImageList = this.imageList1;
            this.B_Close.Location = new System.Drawing.Point(940, 678);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(203, 49);
            this.B_Close.TabIndex = 4;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "driving-license (2).png");
            this.imageList1.Images.SetKeyName(1, "close.png");
            // 
            // B_Issue
            // 
            this.B_Issue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Issue.ForeColor = System.Drawing.Color.BlueViolet;
            this.B_Issue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Issue.ImageIndex = 0;
            this.B_Issue.ImageList = this.imageList1;
            this.B_Issue.Location = new System.Drawing.Point(940, 618);
            this.B_Issue.Name = "B_Issue";
            this.B_Issue.Size = new System.Drawing.Size(203, 54);
            this.B_Issue.TabIndex = 5;
            this.B_Issue.Text = "Issue";
            this.B_Issue.UseVisualStyleBackColor = true;
            this.B_Issue.Click += new System.EventHandler(this.B_Issue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.driving_license1;
            this.pictureBox1.Location = new System.Drawing.Point(1148, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UC_LocalApplicationInfo
            // 
            this.UC_LocalApplicationInfo.Location = new System.Drawing.Point(12, 2);
            this.UC_LocalApplicationInfo.Name = "UC_LocalApplicationInfo";
            this.UC_LocalApplicationInfo.Size = new System.Drawing.Size(1265, 493);
            this.UC_LocalApplicationInfo.TabIndex = 0;
            // 
            // Frm_IssueDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_Issue);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.TB_Notes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Note);
            this.Controls.Add(this.UC_LocalApplicationInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_IssueDriverLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driver License {Frist Time}";
            this.Load += new System.EventHandler(this.Frm_IssueDriverLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApplicationInfo UC_LocalApplicationInfo;
        private System.Windows.Forms.Label L_Note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Notes;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_Issue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}