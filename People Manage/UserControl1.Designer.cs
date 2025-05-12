namespace DVLDProject
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.LB_SetImage = new System.Windows.Forms.LinkLabel();
            this.CB_Country = new System.Windows.Forms.ComboBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.DTP_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.TB_NationalNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_LastName = new System.Windows.Forms.TextBox();
            this.TB_ThirdName = new System.Windows.Forms.TextBox();
            this.TB_SecondName = new System.Windows.Forms.TextBox();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.L_Name = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LB_Remove = new System.Windows.Forms.LinkLabel();
            this.PB_Photo = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RB_Female = new System.Windows.Forms.RadioButton();
            this.RB_Male = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EP_FillPersonInformation = new System.Windows.Forms.ErrorProvider(this.components);
            this.MTB_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_Address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_FillPersonInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_SetImage
            // 
            this.LB_SetImage.AutoSize = true;
            this.LB_SetImage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SetImage.Location = new System.Drawing.Point(906, 177);
            this.LB_SetImage.Name = "LB_SetImage";
            this.LB_SetImage.Size = new System.Drawing.Size(120, 23);
            this.LB_SetImage.TabIndex = 47;
            this.LB_SetImage.TabStop = true;
            this.LB_SetImage.Text = "set Image ";
            // 
            // CB_Country
            // 
            this.CB_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Country.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Country.FormattingEnabled = true;
            this.CB_Country.Location = new System.Drawing.Point(280, 211);
            this.CB_Country.Name = "CB_Country";
            this.CB_Country.Size = new System.Drawing.Size(217, 30);
            this.CB_Country.TabIndex = 45;
            // 
            // TB_Email
            // 
            this.TB_Email.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Email.Location = new System.Drawing.Point(671, 205);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(206, 29);
            this.TB_Email.TabIndex = 43;
            this.TB_Email.TextChanged += new System.EventHandler(this.TB_Email_TextChanged);
            // 
            // DTP_DateOfBirth
            // 
            this.DTP_DateOfBirth.CustomFormat = "";
            this.DTP_DateOfBirth.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DateOfBirth.Location = new System.Drawing.Point(671, 115);
            this.DTP_DateOfBirth.Name = "DTP_DateOfBirth";
            this.DTP_DateOfBirth.Size = new System.Drawing.Size(206, 29);
            this.DTP_DateOfBirth.TabIndex = 36;
            // 
            // TB_NationalNo
            // 
            this.TB_NationalNo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NationalNo.Location = new System.Drawing.Point(239, 117);
            this.TB_NationalNo.Name = "TB_NationalNo";
            this.TB_NationalNo.Size = new System.Drawing.Size(174, 29);
            this.TB_NationalNo.TabIndex = 34;
            this.TB_NationalNo.TextChanged += new System.EventHandler(this.TB_NationalNo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(704, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Third Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Second Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "First Name";
            // 
            // TB_LastName
            // 
            this.TB_LastName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LastName.Location = new System.Drawing.Point(708, 71);
            this.TB_LastName.Name = "TB_LastName";
            this.TB_LastName.Size = new System.Drawing.Size(174, 29);
            this.TB_LastName.TabIndex = 28;
            this.TB_LastName.TextChanged += new System.EventHandler(this.TextBoxes_Chenged);
            // 
            // TB_ThirdName
            // 
            this.TB_ThirdName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ThirdName.Location = new System.Drawing.Point(507, 71);
            this.TB_ThirdName.Name = "TB_ThirdName";
            this.TB_ThirdName.Size = new System.Drawing.Size(174, 29);
            this.TB_ThirdName.TabIndex = 27;
            this.TB_ThirdName.TextChanged += new System.EventHandler(this.TextBoxes_Chenged);
            // 
            // TB_SecondName
            // 
            this.TB_SecondName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SecondName.Location = new System.Drawing.Point(308, 71);
            this.TB_SecondName.Name = "TB_SecondName";
            this.TB_SecondName.Size = new System.Drawing.Size(174, 29);
            this.TB_SecondName.TabIndex = 26;
            this.TB_SecondName.TextChanged += new System.EventHandler(this.TextBoxes_Chenged);
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FirstName.Location = new System.Drawing.Point(101, 71);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(174, 29);
            this.TB_FirstName.TabIndex = 25;
            this.TB_FirstName.TextChanged += new System.EventHandler(this.TextBoxes_Chenged);
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name.Location = new System.Drawing.Point(3, 71);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(76, 23);
            this.L_Name.TabIndex = 24;
            this.L_Name.Text = "Name :";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "letter.png");
            this.imageList1.Images.SetKeyName(1, "call.png");
            this.imageList1.Images.SetKeyName(2, "person_girl.png");
            this.imageList1.Images.SetKeyName(3, "person_boy.png");
            this.imageList1.Images.SetKeyName(4, "id-card.png");
            this.imageList1.Images.SetKeyName(5, "male-and-female.png");
            this.imageList1.Images.SetKeyName(6, "web.png");
            this.imageList1.Images.SetKeyName(7, "calendar.png");
            this.imageList1.Images.SetKeyName(8, "close.png");
            this.imageList1.Images.SetKeyName(9, "diskette (1).png");
            // 
            // LB_Remove
            // 
            this.LB_Remove.AutoSize = true;
            this.LB_Remove.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Remove.LinkColor = System.Drawing.Color.Red;
            this.LB_Remove.Location = new System.Drawing.Point(928, 211);
            this.LB_Remove.Name = "LB_Remove";
            this.LB_Remove.Size = new System.Drawing.Size(65, 23);
            this.LB_Remove.TabIndex = 48;
            this.LB_Remove.TabStop = true;
            this.LB_Remove.Text = "Rmove";
            // 
            // PB_Photo
            // 
            this.PB_Photo.Image = global::DVLDProject.Properties.Resources.person_boy;
            this.PB_Photo.Location = new System.Drawing.Point(888, 71);
            this.PB_Photo.Name = "PB_Photo";
            this.PB_Photo.Size = new System.Drawing.Size(170, 103);
            this.PB_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Photo.TabIndex = 46;
            this.PB_Photo.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.ImageIndex = 6;
            this.label10.ImageList = this.imageList1;
            this.label10.Location = new System.Drawing.Point(3, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 23);
            this.label10.TabIndex = 44;
            this.label10.Text = "   Nationality Country :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.ImageIndex = 0;
            this.label9.ImageList = this.imageList1;
            this.label9.Location = new System.Drawing.Point(531, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "   Email :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.ImageIndex = 1;
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(531, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 40;
            this.label8.Text = "   Phone :";
            // 
            // RB_Female
            // 
            this.RB_Female.AutoSize = true;
            this.RB_Female.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Female.ForeColor = System.Drawing.Color.Blue;
            this.RB_Female.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RB_Female.ImageIndex = 2;
            this.RB_Female.ImageList = this.imageList1;
            this.RB_Female.Location = new System.Drawing.Point(252, 162);
            this.RB_Female.Name = "RB_Female";
            this.RB_Female.Size = new System.Drawing.Size(111, 25);
            this.RB_Female.TabIndex = 39;
            this.RB_Female.Text = "   Female";
            this.RB_Female.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RB_Female.UseVisualStyleBackColor = true;
            // 
            // RB_Male
            // 
            this.RB_Male.AutoSize = true;
            this.RB_Male.Checked = true;
            this.RB_Male.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Male.ForeColor = System.Drawing.Color.Blue;
            this.RB_Male.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RB_Male.ImageIndex = 3;
            this.RB_Male.ImageList = this.imageList1;
            this.RB_Male.Location = new System.Drawing.Point(140, 162);
            this.RB_Male.Name = "RB_Male";
            this.RB_Male.Size = new System.Drawing.Size(93, 25);
            this.RB_Male.TabIndex = 38;
            this.RB_Male.TabStop = true;
            this.RB_Male.Text = "   Male";
            this.RB_Male.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RB_Male.UseVisualStyleBackColor = true;
            this.RB_Male.CheckedChanged += new System.EventHandler(this.RB_Male_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.ImageIndex = 5;
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "   Gendor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImageIndex = 7;
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new System.Drawing.Point(443, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "   Date OF Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImageIndex = 4;
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(3, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "   National Number :";
            // 
            // EP_FillPersonInformation
            // 
            this.EP_FillPersonInformation.ContainerControl = this;
            // 
            // MTB_Phone
            // 
            this.MTB_Phone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTB_Phone.Location = new System.Drawing.Point(671, 161);
            this.MTB_Phone.Mask = "0000000000";
            this.MTB_Phone.Name = "MTB_Phone";
            this.MTB_Phone.Size = new System.Drawing.Size(206, 31);
            this.MTB_Phone.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(3, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 23);
            this.label11.TabIndex = 50;
            this.label11.Text = "Address :";
            // 
            // TB_Address
            // 
            this.TB_Address.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Address.Location = new System.Drawing.Point(118, 254);
            this.TB_Address.Multiline = true;
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(764, 55);
            this.TB_Address.TabIndex = 51;
            this.TB_Address.TextChanged += new System.EventHandler(this.TB_Address_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_Address);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MTB_Phone);
            this.Controls.Add(this.LB_Remove);
            this.Controls.Add(this.LB_SetImage);
            this.Controls.Add(this.PB_Photo);
            this.Controls.Add(this.CB_Country);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RB_Female);
            this.Controls.Add(this.RB_Male);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTP_DateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_NationalNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_LastName);
            this.Controls.Add(this.TB_ThirdName);
            this.Controls.Add(this.TB_SecondName);
            this.Controls.Add(this.TB_FirstName);
            this.Controls.Add(this.L_Name);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1066, 321);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_FillPersonInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LB_SetImage;
        private System.Windows.Forms.PictureBox PB_Photo;
        private System.Windows.Forms.ComboBox CB_Country;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RB_Female;
        private System.Windows.Forms.RadioButton RB_Male;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTP_DateOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_NationalNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_LastName;
        private System.Windows.Forms.TextBox TB_ThirdName;
        private System.Windows.Forms.TextBox TB_SecondName;
        private System.Windows.Forms.TextBox TB_FirstName;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel LB_Remove;
        private System.Windows.Forms.ErrorProvider EP_FillPersonInformation;
        private System.Windows.Forms.MaskedTextBox MTB_Phone;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label label11;
    }
}
