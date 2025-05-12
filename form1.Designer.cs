namespace DVLDProject
{
    partial class form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TMS_AccountSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Application = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_People = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Drivers = new System.Windows.Forms.ToolStripMenuItem();
            this.TMS_Users = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMS_Application,
            this.TMS_People,
            this.TMS_Drivers,
            this.TMS_Users,
            this.TMS_AccountSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1506, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TMS_AccountSetting
            // 
            this.TMS_AccountSetting.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_AccountSetting.Image = global::DVLDProject.Properties.Resources.user__1_;
            this.TMS_AccountSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_AccountSetting.Name = "TMS_AccountSetting";
            this.TMS_AccountSetting.Size = new System.Drawing.Size(242, 68);
            this.TMS_AccountSetting.Text = "AccountSetting";
            this.TMS_AccountSetting.Click += new System.EventHandler(this.TMS_AccountSetting_Click);
            // 
            // TMS_Application
            // 
            this.TMS_Application.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_Application.Image = global::DVLDProject.Properties.Resources.apps;
            this.TMS_Application.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Application.Name = "TMS_Application";
            this.TMS_Application.Size = new System.Drawing.Size(220, 68);
            this.TMS_Application.Text = "Applications";
            this.TMS_Application.Click += new System.EventHandler(this.TMS_Application_Click);
            // 
            // TMS_People
            // 
            this.TMS_People.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_People.Image = global::DVLDProject.Properties.Resources.people__1_;
            this.TMS_People.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_People.Name = "TMS_People";
            this.TMS_People.Size = new System.Drawing.Size(154, 68);
            this.TMS_People.Text = "People";
            this.TMS_People.Click += new System.EventHandler(this.TMS_People_Click);
            // 
            // TMS_Drivers
            // 
            this.TMS_Drivers.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_Drivers.Image = global::DVLDProject.Properties.Resources.people;
            this.TMS_Drivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Drivers.Name = "TMS_Drivers";
            this.TMS_Drivers.Size = new System.Drawing.Size(165, 68);
            this.TMS_Drivers.Text = "Drivers";
            this.TMS_Drivers.Click += new System.EventHandler(this.TMS_Drivers_Click);
            // 
            // TMS_Users
            // 
            this.TMS_Users.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMS_Users.Image = global::DVLDProject.Properties.Resources.laptop;
            this.TMS_Users.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TMS_Users.Name = "TMS_Users";
            this.TMS_Users.Size = new System.Drawing.Size(143, 68);
            this.TMS_Users.Text = "Users";
            this.TMS_Users.Click += new System.EventHandler(this.TMS_Users_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 710);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Frm_Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TMS_Application;
        private System.Windows.Forms.ToolStripMenuItem TMS_People;
        private System.Windows.Forms.ToolStripMenuItem TMS_Drivers;
        private System.Windows.Forms.ToolStripMenuItem TMS_Users;
        private System.Windows.Forms.ToolStripMenuItem TMS_AccountSetting;
    }
}

