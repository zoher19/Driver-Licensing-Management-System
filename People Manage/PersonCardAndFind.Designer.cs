namespace DVLDProject
{
    partial class PersonCardAndFind
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
            this.GB_Search = new System.Windows.Forms.GroupBox();
            this.B_Find = new System.Windows.Forms.Button();
            this.B_Add = new System.Windows.Forms.Button();
            this.TB_FindBy = new System.Windows.Forms.TextBox();
            this.CB_FindBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UC_PersonCard = new DVLDProject.PersonCard();
            this.GB_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Search
            // 
            this.GB_Search.Controls.Add(this.B_Find);
            this.GB_Search.Controls.Add(this.B_Add);
            this.GB_Search.Controls.Add(this.TB_FindBy);
            this.GB_Search.Controls.Add(this.CB_FindBy);
            this.GB_Search.Controls.Add(this.label1);
            this.GB_Search.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Search.Location = new System.Drawing.Point(3, 4);
            this.GB_Search.Name = "GB_Search";
            this.GB_Search.Size = new System.Drawing.Size(989, 100);
            this.GB_Search.TabIndex = 1;
            this.GB_Search.TabStop = false;
            this.GB_Search.Text = "Search Person ";
            // 
            // B_Find
            // 
            this.B_Find.BackgroundImage = global::DVLDProject.Properties.Resources.user__2_1;
            this.B_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Find.Location = new System.Drawing.Point(646, 28);
            this.B_Find.Name = "B_Find";
            this.B_Find.Size = new System.Drawing.Size(56, 50);
            this.B_Find.TabIndex = 4;
            this.B_Find.UseVisualStyleBackColor = true;
            this.B_Find.Click += new System.EventHandler(this.B_Find_Click);
            // 
            // B_Add
            // 
            this.B_Add.BackgroundImage = global::DVLDProject.Properties.Resources.add_friend;
            this.B_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Add.Location = new System.Drawing.Point(708, 28);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(50, 50);
            this.B_Add.TabIndex = 3;
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // TB_FindBy
            // 
            this.TB_FindBy.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FindBy.Location = new System.Drawing.Point(365, 41);
            this.TB_FindBy.Name = "TB_FindBy";
            this.TB_FindBy.Size = new System.Drawing.Size(249, 29);
            this.TB_FindBy.TabIndex = 2;
            this.TB_FindBy.Visible = false;
            this.TB_FindBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_FindBy_KeyPress);
            // 
            // CB_FindBy
            // 
            this.CB_FindBy.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CB_FindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FindBy.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FindBy.FormattingEnabled = true;
            this.CB_FindBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo"});
            this.CB_FindBy.Location = new System.Drawing.Point(132, 40);
            this.CB_FindBy.Name = "CB_FindBy";
            this.CB_FindBy.Size = new System.Drawing.Size(227, 30);
            this.CB_FindBy.TabIndex = 1;
            this.CB_FindBy.SelectedIndexChanged += new System.EventHandler(this.CB_FindBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By :";
            // 
            // UC_PersonCard
            // 
            this.UC_PersonCard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_PersonCard.Location = new System.Drawing.Point(0, 111);
            this.UC_PersonCard.Margin = new System.Windows.Forms.Padding(4);
            this.UC_PersonCard.Name = "UC_PersonCard";
            this.UC_PersonCard.Size = new System.Drawing.Size(992, 354);
            this.UC_PersonCard.TabIndex = 0;
            // 
            // PersonCardAndFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GB_Search);
            this.Controls.Add(this.UC_PersonCard);
            this.Name = "PersonCardAndFind";
            this.Size = new System.Drawing.Size(1277, 514);
            this.Load += new System.EventHandler(this.PersonCardAndFind_Load);
            this.GB_Search.ResumeLayout(false);
            this.GB_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonCard UC_PersonCard;
        private System.Windows.Forms.GroupBox GB_Search;
        private System.Windows.Forms.TextBox TB_FindBy;
        private System.Windows.Forms.ComboBox CB_FindBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Find;
        private System.Windows.Forms.Button B_Add;
    }
}
