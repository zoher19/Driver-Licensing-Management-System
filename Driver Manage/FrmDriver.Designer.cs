namespace DVLDProject
{
    partial class Frm_Driver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGV_Drivers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_FiltterBy = new System.Windows.Forms.ComboBox();
            this.TB_FiltterBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.L_Recourd = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.C_DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Drivers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(554, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver Manage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.chauffeur;
            this.pictureBox1.Location = new System.Drawing.Point(585, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DGV_Drivers
            // 
            this.DGV_Drivers.AllowUserToAddRows = false;
            this.DGV_Drivers.AllowUserToDeleteRows = false;
            this.DGV_Drivers.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Drivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Drivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_DriverID,
            this.C_PersonID,
            this.C_NationalNo,
            this.C_FullName,
            this.C_Date});
            this.DGV_Drivers.Location = new System.Drawing.Point(2, 353);
            this.DGV_Drivers.MultiSelect = false;
            this.DGV_Drivers.Name = "DGV_Drivers";
            this.DGV_Drivers.ReadOnly = true;
            this.DGV_Drivers.RowHeadersWidth = 51;
            this.DGV_Drivers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Drivers.RowTemplate.Height = 24;
            this.DGV_Drivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Drivers.Size = new System.Drawing.Size(1361, 342);
            this.DGV_Drivers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(12, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fillter By :";
            // 
            // CB_FiltterBy
            // 
            this.CB_FiltterBy.BackColor = System.Drawing.Color.RoyalBlue;
            this.CB_FiltterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FiltterBy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FiltterBy.FormattingEnabled = true;
            this.CB_FiltterBy.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID"});
            this.CB_FiltterBy.Location = new System.Drawing.Point(172, 308);
            this.CB_FiltterBy.Name = "CB_FiltterBy";
            this.CB_FiltterBy.Size = new System.Drawing.Size(265, 31);
            this.CB_FiltterBy.TabIndex = 4;
            this.CB_FiltterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FiltterBy_SelectedIndexChanged);
            // 
            // TB_FiltterBy
            // 
            this.TB_FiltterBy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FiltterBy.Location = new System.Drawing.Point(473, 308);
            this.TB_FiltterBy.Name = "TB_FiltterBy";
            this.TB_FiltterBy.Size = new System.Drawing.Size(238, 31);
            this.TB_FiltterBy.TabIndex = 5;
            this.TB_FiltterBy.Visible = false;
            this.TB_FiltterBy.TextChanged += new System.EventHandler(this.TB_FiltterBy_TextChanged);
            this.TB_FiltterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_FiltterBy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(12, 711);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recourd =#";
            // 
            // L_Recourd
            // 
            this.L_Recourd.AutoSize = true;
            this.L_Recourd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Recourd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.L_Recourd.Location = new System.Drawing.Point(122, 711);
            this.L_Recourd.Name = "L_Recourd";
            this.L_Recourd.Size = new System.Drawing.Size(32, 23);
            this.L_Recourd.TabIndex = 7;
            this.L_Recourd.Text = "##";
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.RoyalBlue;
            this.B_Close.Location = new System.Drawing.Point(1154, 711);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(200, 47);
            this.B_Close.TabIndex = 8;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // C_DriverID
            // 
            this.C_DriverID.HeaderText = "DriverID";
            this.C_DriverID.MinimumWidth = 6;
            this.C_DriverID.Name = "C_DriverID";
            this.C_DriverID.ReadOnly = true;
            this.C_DriverID.Width = 125;
            // 
            // C_PersonID
            // 
            this.C_PersonID.HeaderText = "PersonID";
            this.C_PersonID.MinimumWidth = 6;
            this.C_PersonID.Name = "C_PersonID";
            this.C_PersonID.ReadOnly = true;
            this.C_PersonID.Width = 125;
            // 
            // C_NationalNo
            // 
            this.C_NationalNo.HeaderText = "NationalNo";
            this.C_NationalNo.MinimumWidth = 6;
            this.C_NationalNo.Name = "C_NationalNo";
            this.C_NationalNo.ReadOnly = true;
            this.C_NationalNo.Width = 125;
            // 
            // C_FullName
            // 
            this.C_FullName.HeaderText = "Full Name";
            this.C_FullName.MinimumWidth = 6;
            this.C_FullName.Name = "C_FullName";
            this.C_FullName.ReadOnly = true;
            this.C_FullName.Width = 300;
            // 
            // C_Date
            // 
            this.C_Date.HeaderText = "Date";
            this.C_Date.MinimumWidth = 6;
            this.C_Date.Name = "C_Date";
            this.C_Date.ReadOnly = true;
            this.C_Date.Width = 200;
            // 
            // Frm_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 770);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.L_Recourd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_FiltterBy);
            this.Controls.Add(this.CB_FiltterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Drivers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver List";
            this.Load += new System.EventHandler(this.Frm_Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Drivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Drivers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_FiltterBy;
        private System.Windows.Forms.TextBox TB_FiltterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_Recourd;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Date;
    }
}