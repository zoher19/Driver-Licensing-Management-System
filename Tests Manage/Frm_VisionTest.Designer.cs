namespace DVLDProject
{
    partial class Frm_VisionTest
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
            this.L_Title = new System.Windows.Forms.Label();
            this.DGV_AppointmentDetails = new System.Windows.Forms.DataGridView();
            this.C_AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_IsLoced = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TMS_EditAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TMS_TakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_Rcords = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.B_AddAppointment = new System.Windows.Forms.Button();
            this.PB_Title = new System.Windows.Forms.PictureBox();
            this.UC_LocalApplicationInfo = new DVLDProject.ApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AppointmentDetails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Title.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.L_Title.Location = new System.Drawing.Point(699, 67);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(310, 55);
            this.L_Title.TabIndex = 1;
            this.L_Title.Text = "Vision Test";
            // 
            // DGV_AppointmentDetails
            // 
            this.DGV_AppointmentDetails.AllowUserToAddRows = false;
            this.DGV_AppointmentDetails.AllowUserToDeleteRows = false;
            this.DGV_AppointmentDetails.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_AppointmentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_AppointmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AppointmentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_AppointmentID,
            this.C_AppointmentDate,
            this.C_PaidFees,
            this.C_IsLoced});
            this.DGV_AppointmentDetails.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_AppointmentDetails.Location = new System.Drawing.Point(16, 635);
            this.DGV_AppointmentDetails.Name = "DGV_AppointmentDetails";
            this.DGV_AppointmentDetails.RowHeadersWidth = 51;
            this.DGV_AppointmentDetails.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_AppointmentDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_AppointmentDetails.RowTemplate.Height = 24;
            this.DGV_AppointmentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AppointmentDetails.Size = new System.Drawing.Size(1208, 182);
            this.DGV_AppointmentDetails.TabIndex = 3;
            // 
            // C_AppointmentID
            // 
            this.C_AppointmentID.HeaderText = "Appointment ID";
            this.C_AppointmentID.MinimumWidth = 6;
            this.C_AppointmentID.Name = "C_AppointmentID";
            this.C_AppointmentID.ReadOnly = true;
            this.C_AppointmentID.Width = 150;
            // 
            // C_AppointmentDate
            // 
            this.C_AppointmentDate.HeaderText = "Appointment Date";
            this.C_AppointmentDate.MinimumWidth = 6;
            this.C_AppointmentDate.Name = "C_AppointmentDate";
            this.C_AppointmentDate.ReadOnly = true;
            this.C_AppointmentDate.Width = 150;
            // 
            // C_PaidFees
            // 
            this.C_PaidFees.HeaderText = "PaidFees";
            this.C_PaidFees.MinimumWidth = 6;
            this.C_PaidFees.Name = "C_PaidFees";
            this.C_PaidFees.ReadOnly = true;
            this.C_PaidFees.Width = 125;
            // 
            // C_IsLoced
            // 
            this.C_IsLoced.HeaderText = "Is Loced";
            this.C_IsLoced.MinimumWidth = 6;
            this.C_IsLoced.Name = "C_IsLoced";
            this.C_IsLoced.ReadOnly = true;
            this.C_IsLoced.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_EditAppointment,
            this.toolStripMenuItem1,
            this.TMS_TakeTest});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 86);
            // 
            // TMS_EditAppointment
            // 
            this.TMS_EditAppointment.Image = global::DVLDProject.Properties.Resources.renewal2;
            this.TMS_EditAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TMS_EditAppointment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_EditAppointment.Name = "TMS_EditAppointment";
            this.TMS_EditAppointment.Size = new System.Drawing.Size(247, 38);
            this.TMS_EditAppointment.Text = "Edit Appointments";
            this.TMS_EditAppointment.Click += new System.EventHandler(this.TMS_EditAppointment_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(244, 6);
            // 
            // TMS_TakeTest
            // 
            this.TMS_TakeTest.Image = global::DVLDProject.Properties.Resources.write2;
            this.TMS_TakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_TakeTest.Name = "TMS_TakeTest";
            this.TMS_TakeTest.Size = new System.Drawing.Size(247, 38);
            this.TMS_TakeTest.Text = "Take Test";
            this.TMS_TakeTest.Click += new System.EventHandler(this.TMS_TakeTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(12, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Appointments :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(12, 820);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Records :";
            // 
            // L_Rcords
            // 
            this.L_Rcords.AutoSize = true;
            this.L_Rcords.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Rcords.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.L_Rcords.Location = new System.Drawing.Point(128, 820);
            this.L_Rcords.Name = "L_Rcords";
            this.L_Rcords.Size = new System.Drawing.Size(30, 22);
            this.L_Rcords.TabIndex = 7;
            this.L_Rcords.Text = "##";
            // 
            // B_Close
            // 
            this.B_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.B_Close.Location = new System.Drawing.Point(1243, 778);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(177, 39);
            this.B_Close.TabIndex = 8;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // B_AddAppointment
            // 
            this.B_AddAppointment.BackgroundImage = global::DVLDProject.Properties.Resources.calendar__2_;
            this.B_AddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_AddAppointment.Location = new System.Drawing.Point(1149, 572);
            this.B_AddAppointment.Name = "B_AddAppointment";
            this.B_AddAppointment.Size = new System.Drawing.Size(75, 57);
            this.B_AddAppointment.TabIndex = 5;
            this.B_AddAppointment.UseVisualStyleBackColor = true;
            this.B_AddAppointment.Click += new System.EventHandler(this.B_AddAppointment_Click);
            // 
            // PB_Title
            // 
            this.PB_Title.Image = global::DVLDProject.Properties.Resources.vision__1_;
            this.PB_Title.Location = new System.Drawing.Point(492, -1);
            this.PB_Title.Name = "PB_Title";
            this.PB_Title.Size = new System.Drawing.Size(144, 123);
            this.PB_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Title.TabIndex = 0;
            this.PB_Title.TabStop = false;
            // 
            // UC_LocalApplicationInfo
            // 
            this.UC_LocalApplicationInfo.Location = new System.Drawing.Point(-2, 125);
            this.UC_LocalApplicationInfo.Name = "UC_LocalApplicationInfo";
            this.UC_LocalApplicationInfo.Size = new System.Drawing.Size(1293, 493);
            this.UC_LocalApplicationInfo.TabIndex = 2;
            // 
            // Frm_VisionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 864);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.L_Rcords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_AddAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_AppointmentDetails);
            this.Controls.Add(this.UC_LocalApplicationInfo);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.PB_Title);
            this.Name = "Frm_VisionTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_VisionTest";
            this.Load += new System.EventHandler(this.Frm_VisionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AppointmentDetails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Title;
        private System.Windows.Forms.Label L_Title;
        private ApplicationInfo UC_LocalApplicationInfo;
        private System.Windows.Forms.DataGridView DGV_AppointmentDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_AddAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn C_IsLoced;
        private System.Windows.Forms.Label L_Rcords;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TMS_EditAppointment;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TMS_TakeTest;
    }
}