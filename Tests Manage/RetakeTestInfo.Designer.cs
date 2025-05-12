namespace DVLDProject
{
    partial class RetakeTestInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetakeTestInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.L_TotalFees = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.L_ID = new System.Windows.Forms.Label();
            this.L_IDfdf = new System.Windows.Forms.Label();
            this.L_Fees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_TotalFees);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.L_ID);
            this.groupBox1.Controls.Add(this.L_IDfdf);
            this.groupBox1.Controls.Add(this.L_Fees);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retake Test Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // L_TotalFees
            // 
            this.L_TotalFees.AutoSize = true;
            this.L_TotalFees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_TotalFees.ImageIndex = 3;
            this.L_TotalFees.ImageList = this.imageList1;
            this.L_TotalFees.Location = new System.Drawing.Point(370, 39);
            this.L_TotalFees.Name = "L_TotalFees";
            this.L_TotalFees.Size = new System.Drawing.Size(54, 20);
            this.L_TotalFees.TabIndex = 5;
            this.L_TotalFees.Text = "   0$";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Fees :";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_ID.ImageIndex = 8;
            this.L_ID.ImageList = this.imageList1;
            this.L_ID.Location = new System.Drawing.Point(130, 78);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(63, 20);
            this.L_ID.TabIndex = 3;
            this.L_ID.Text = "   N/A";
            // 
            // L_IDfdf
            // 
            this.L_IDfdf.AutoSize = true;
            this.L_IDfdf.Location = new System.Drawing.Point(34, 78);
            this.L_IDfdf.Name = "L_IDfdf";
            this.L_IDfdf.Size = new System.Drawing.Size(90, 20);
            this.L_IDfdf.TabIndex = 2;
            this.L_IDfdf.Text = "R_AppID :";
            // 
            // L_Fees
            // 
            this.L_Fees.AutoSize = true;
            this.L_Fees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_Fees.ImageIndex = 3;
            this.L_Fees.ImageList = this.imageList1;
            this.L_Fees.Location = new System.Drawing.Point(130, 39);
            this.L_Fees.Name = "L_Fees";
            this.L_Fees.Size = new System.Drawing.Size(63, 20);
            this.L_Fees.TabIndex = 1;
            this.L_Fees.Text = "    0$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "R_AppFees :";
            // 
            // RetakeTestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RetakeTestInfo";
            this.Size = new System.Drawing.Size(508, 137);
            this.Load += new System.EventHandler(this.RetakeTestInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label L_TotalFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label L_IDfdf;
        private System.Windows.Forms.Label L_Fees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
