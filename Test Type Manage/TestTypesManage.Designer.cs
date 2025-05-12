namespace DVLDProject
{
    partial class Frm_TestTypesManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TestTypesManage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_TestTypes = new System.Windows.Forms.DataGridView();
            this.C_TestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TestTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_Edit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TMS_UpdateTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.B_Refresh = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.B_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TestTypes)).BeginInit();
            this.CMS_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.testing;
            this.pictureBox1.Location = new System.Drawing.Point(506, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(317, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mange Test Types";
            // 
            // DGV_TestTypes
            // 
            this.DGV_TestTypes.AllowUserToAddRows = false;
            this.DGV_TestTypes.AllowUserToDeleteRows = false;
            this.DGV_TestTypes.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TestTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_TestID,
            this.C_TestTitle,
            this.C_Description,
            this.C_Fees});
            this.DGV_TestTypes.Location = new System.Drawing.Point(3, 253);
            this.DGV_TestTypes.MultiSelect = false;
            this.DGV_TestTypes.Name = "DGV_TestTypes";
            this.DGV_TestTypes.ReadOnly = true;
            this.DGV_TestTypes.RowHeadersWidth = 51;
            this.DGV_TestTypes.RowTemplate.ContextMenuStrip = this.CMS_Edit;
            this.DGV_TestTypes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_TestTypes.RowTemplate.Height = 24;
            this.DGV_TestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TestTypes.Size = new System.Drawing.Size(1173, 300);
            this.DGV_TestTypes.TabIndex = 2;
            // 
            // C_TestID
            // 
            this.C_TestID.HeaderText = "Test ID";
            this.C_TestID.MinimumWidth = 6;
            this.C_TestID.Name = "C_TestID";
            this.C_TestID.ReadOnly = true;
            this.C_TestID.Width = 125;
            // 
            // C_TestTitle
            // 
            this.C_TestTitle.HeaderText = "Title";
            this.C_TestTitle.MinimumWidth = 6;
            this.C_TestTitle.Name = "C_TestTitle";
            this.C_TestTitle.ReadOnly = true;
            this.C_TestTitle.Width = 225;
            // 
            // C_Description
            // 
            this.C_Description.HeaderText = "Description";
            this.C_Description.MinimumWidth = 6;
            this.C_Description.Name = "C_Description";
            this.C_Description.ReadOnly = true;
            this.C_Description.Width = 349;
            // 
            // C_Fees
            // 
            this.C_Fees.HeaderText = "Fees";
            this.C_Fees.MinimumWidth = 6;
            this.C_Fees.Name = "C_Fees";
            this.C_Fees.ReadOnly = true;
            this.C_Fees.Width = 125;
            // 
            // CMS_Edit
            // 
            this.CMS_Edit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_Edit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_UpdateTypes});
            this.CMS_Edit.Name = "CMS_Edit";
            this.CMS_Edit.Size = new System.Drawing.Size(217, 42);
            // 
            // TMS_UpdateTypes
            // 
            this.TMS_UpdateTypes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_UpdateTypes.Image = global::DVLDProject.Properties.Resources.application__1_;
            this.TMS_UpdateTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_UpdateTypes.Name = "TMS_UpdateTypes";
            this.TMS_UpdateTypes.Size = new System.Drawing.Size(216, 38);
            this.TMS_UpdateTypes.Text = "Update Type";
            this.TMS_UpdateTypes.Click += new System.EventHandler(this.TMS_UpdateTypes_Click);
            // 
            // B_Refresh
            // 
            this.B_Refresh.BackgroundImage = global::DVLDProject.Properties.Resources.refresh;
            this.B_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Refresh.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.B_Refresh.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.B_Refresh.ImageIndex = 1;
            this.B_Refresh.Location = new System.Drawing.Point(1095, 194);
            this.B_Refresh.Name = "B_Refresh";
            this.B_Refresh.Size = new System.Drawing.Size(57, 53);
            this.B_Refresh.TabIndex = 9;
            this.B_Refresh.UseVisualStyleBackColor = true;
            this.B_Refresh.Click += new System.EventHandler(this.B_Refresh_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Close.ImageIndex = 0;
            this.B_Close.ImageList = this.imageList1;
            this.B_Close.Location = new System.Drawing.Point(987, 559);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(165, 48);
            this.B_Close.TabIndex = 10;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // Frm_TestTypesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 606);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Refresh);
            this.Controls.Add(this.DGV_TestTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_TestTypesManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestTypesManage";
            this.Load += new System.EventHandler(this.Frm_TestTypesManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TestTypes)).EndInit();
            this.CMS_Edit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_TestTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TestTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Fees;
        private System.Windows.Forms.ContextMenuStrip CMS_Edit;
        private System.Windows.Forms.ToolStripMenuItem TMS_UpdateTypes;
        private System.Windows.Forms.Button B_Refresh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button B_Close;
    }
}