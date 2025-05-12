namespace DVLDProject
{
    partial class Frm_AddorEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddorEditPerson));
            this.L_Title = new System.Windows.Forms.Label();
            this.B_Close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.B_Save = new System.Windows.Forms.Button();
            this.L_PersonID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UC_AddEditPerson = new DVLDProject.UserControl1();
            this.SuspendLayout();
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Title.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.L_Title.Location = new System.Drawing.Point(336, 56);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(388, 55);
            this.L_Title.TabIndex = 1;
            this.L_Title.Text = "[ Add Person ]";
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.DodgerBlue;
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Close.ImageKey = "close.png";
            this.B_Close.ImageList = this.imageList1;
            this.B_Close.Location = new System.Drawing.Point(576, 452);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(171, 43);
            this.B_Close.TabIndex = 55;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "diskette (1).png");
            // 
            // B_Save
            // 
            this.B_Save.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Save.ForeColor = System.Drawing.Color.DodgerBlue;
            this.B_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Save.ImageIndex = 1;
            this.B_Save.ImageList = this.imageList1;
            this.B_Save.Location = new System.Drawing.Point(753, 452);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(168, 43);
            this.B_Save.TabIndex = 54;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // L_PersonID
            // 
            this.L_PersonID.AutoSize = true;
            this.L_PersonID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PersonID.ForeColor = System.Drawing.Color.Black;
            this.L_PersonID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.L_PersonID.ImageIndex = 1;
            this.L_PersonID.ImageList = this.imageList1;
            this.L_PersonID.Location = new System.Drawing.Point(167, 140);
            this.L_PersonID.Name = "L_PersonID";
            this.L_PersonID.Size = new System.Drawing.Size(76, 23);
            this.L_PersonID.TabIndex = 57;
            this.L_PersonID.Text = "   N/A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(39, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 23);
            this.label12.TabIndex = 56;
            this.label12.Text = "Person ID :";
            // 
            // UC_AddEditPerson
            // 
            this.UC_AddEditPerson.Location = new System.Drawing.Point(43, 140);
            this.UC_AddEditPerson.Name = "UC_AddEditPerson";
            this.UC_AddEditPerson.Size = new System.Drawing.Size(1055, 322);
            this.UC_AddEditPerson.TabIndex = 0;
            // 
            // Frm_AddorEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 583);
            this.Controls.Add(this.L_PersonID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.UC_AddEditPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_AddorEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/EditPerson";
            this.Load += new System.EventHandler(this.Frm_AddorEditPerson_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_AddorEditPerson_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 UC_AddEditPerson;
        private System.Windows.Forms.Label L_Title;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label L_PersonID;
        private System.Windows.Forms.Label label12;
    }
}