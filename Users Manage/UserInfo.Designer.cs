namespace DVLDProject
{
    partial class Frm_UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UserInfo));
            this.B_Close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UC_UserCard = new DVLDProject.UserCard();
            this.SuspendLayout();
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Close.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.B_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_Close.ImageIndex = 0;
            this.B_Close.ImageList = this.imageList1;
            this.B_Close.Location = new System.Drawing.Point(844, 508);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(214, 49);
            this.B_Close.TabIndex = 1;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close.png");
            // 
            // UC_UserCard
            // 
            this.UC_UserCard.Location = new System.Drawing.Point(1, -2);
            this.UC_UserCard.Name = "UC_UserCard";
            this.UC_UserCard.Size = new System.Drawing.Size(1395, 516);
            this.UC_UserCard.TabIndex = 0;
            // 
            // Frm_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 569);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.UC_UserCard);
            this.Name = "Frm_UserInfo";
            this.Text = "User Info";
            this.Load += new System.EventHandler(this.Frm_UserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserCard UC_UserCard;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.ImageList imageList1;
    }
}