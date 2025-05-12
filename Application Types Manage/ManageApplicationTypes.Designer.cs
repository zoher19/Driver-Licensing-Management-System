namespace DVLDProject
{
    partial class Frm_ManageApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManageApp));
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_ApplicationsType = new System.Windows.Forms.DataGridView();
            this.C_ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS_Edit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.B_Close = new System.Windows.Forms.Button();
            this.B_Refresh = new System.Windows.Forms.Button();
            this.TMS_UpdateTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ApplicationsType)).BeginInit();
            this.CMS_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(126, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Application";
            // 
            // DGV_ApplicationsType
            // 
            this.DGV_ApplicationsType.AllowUserToAddRows = false;
            this.DGV_ApplicationsType.AllowUserToDeleteRows = false;
            this.DGV_ApplicationsType.BackgroundColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ApplicationsType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_ApplicationsType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ApplicationsType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ApplicationID,
            this.C_Title,
            this.C_Fees});
            this.DGV_ApplicationsType.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_ApplicationsType.Location = new System.Drawing.Point(-4, 314);
            this.DGV_ApplicationsType.MultiSelect = false;
            this.DGV_ApplicationsType.Name = "DGV_ApplicationsType";
            this.DGV_ApplicationsType.ReadOnly = true;
            this.DGV_ApplicationsType.RowHeadersWidth = 51;
            this.DGV_ApplicationsType.RowTemplate.ContextMenuStrip = this.CMS_Edit;
            this.DGV_ApplicationsType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_ApplicationsType.RowTemplate.Height = 24;
            this.DGV_ApplicationsType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ApplicationsType.Size = new System.Drawing.Size(831, 336);
            this.DGV_ApplicationsType.TabIndex = 2;
            // 
            // C_ApplicationID
            // 
            this.C_ApplicationID.HeaderText = "Application ID";
            this.C_ApplicationID.MinimumWidth = 6;
            this.C_ApplicationID.Name = "C_ApplicationID";
            this.C_ApplicationID.ReadOnly = true;
            this.C_ApplicationID.Width = 160;
            // 
            // C_Title
            // 
            this.C_Title.HeaderText = "Title";
            this.C_Title.MinimumWidth = 6;
            this.C_Title.Name = "C_Title";
            this.C_Title.ReadOnly = true;
            this.C_Title.Width = 300;
            // 
            // C_Fees
            // 
            this.C_Fees.HeaderText = "Fees $";
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
            this.B_Close.Location = new System.Drawing.Point(662, 656);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(165, 48);
            this.B_Close.TabIndex = 9;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // B_Refresh
            // 
            this.B_Refresh.BackgroundImage = global::DVLDProject.Properties.Resources.refresh;
            this.B_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Refresh.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.B_Refresh.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.B_Refresh.ImageIndex = 1;
            this.B_Refresh.Location = new System.Drawing.Point(770, 255);
            this.B_Refresh.Name = "B_Refresh";
            this.B_Refresh.Size = new System.Drawing.Size(57, 53);
            this.B_Refresh.TabIndex = 8;
            this.B_Refresh.UseVisualStyleBackColor = true;
            this.B_Refresh.Click += new System.EventHandler(this.B_Refresh_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDProject.Properties.Resources.risk_management;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_ManageApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 705);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Refresh);
            this.Controls.Add(this.DGV_ApplicationsType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_ManageApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageApplicationTypes";
            this.Load += new System.EventHandler(this.Frm_ManageApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ApplicationsType)).EndInit();
            this.CMS_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_ApplicationsType;
        private System.Windows.Forms.ContextMenuStrip CMS_Edit;
        private System.Windows.Forms.ToolStripMenuItem TMS_UpdateTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Fees;
        private System.Windows.Forms.Button B_Refresh;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.ImageList imageList1;
    }
}