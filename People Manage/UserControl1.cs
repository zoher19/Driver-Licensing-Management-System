using BusinessLayerDVLD;
using DVLDProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDProject
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string NationalNo = "";
        public void LoadData(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth, string Gendor, string Phone, string Email, string Address, int CountryID,string ImagePath)
        {
            TB_NationalNo.Text=NationalNo;

            TB_FirstName.Text=FirstName;
            TB_SecondName.Text=SecondName;
            TB_LastName.Text=LastName; 
            TB_ThirdName.Text=ThirdName; 

            
            if (Gendor == "Male")
                RB_Male.Checked = true;
            else
                RB_Female.Checked = true;

            DTP_DateOfBirth.Value=DateOfBirth;
            CB_Country.Text=clsConvertsData.ConvertFromCountryIDToCountryName(CountryID);

            MTB_Phone.Text=Phone;
            TB_Email.Text=Email;
            TB_Address.Text=Address;

           this.NationalNo = NationalNo;
            EP_FillPersonInformation.SetError(TB_NationalNo, string.Empty);


        }
        private void FillCountries()
        {
            DataTable Countries = clsBCountries.GetAllCountries();
            foreach (DataRow Country in Countries.Rows)
            {
                CB_Country.Items.Add(Country["CountryName"]);
            }
            CB_Country.SelectedItem="Jordan";

        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            DTP_DateOfBirth.MaxDate=DateTime.Now.AddYears(-18);
            FillCountries();

        }
        private void RB_Male_CheckedChanged(object sender, EventArgs e)
        {
            PB_Photo.Image=RB_Male.Checked ? Resources.person_boy : Resources.person_girl;
        }
        private void CheckOnTextBoxes(TextBox T)
        {
            if (T == null)
                return;


            if (T.Text == string.Empty || T.Text.Length <=2)
            {
                EP_FillPersonInformation.SetError(T, "Text must be greater than 2 characters");

            }
            else if (T.Text.Contains(" "))
            {
                EP_FillPersonInformation.SetError(T, "It must not contain ' '");

            }
            else if (Regex.IsMatch(T.Text, @"[\d]+") || Regex.IsMatch(T.Text, @"[\W_]+"))
            {
                EP_FillPersonInformation.SetError(T, "It must not contain on any Symbol or Numbers");
            }
            else
            {
                EP_FillPersonInformation.SetError(T, string.Empty);

            }

        }
        private void TextBoxes_Chenged(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            CheckOnTextBoxes(T);
        }
        private void TB_NationalNo_TextChanged(object sender, EventArgs e)
        {
            if (TB_NationalNo == null)
                return;

            if (clsBPeople.IsExist(TB_NationalNo.Text) &&(this.NationalNo != TB_NationalNo.Text))
            {
                EP_FillPersonInformation.SetError(TB_NationalNo, "This national number is available");
            }
            else if (TB_NationalNo.Text == string.Empty || TB_NationalNo.Text.Length <2)
            {
                EP_FillPersonInformation.SetError(TB_NationalNo, "Text must be greater than 2 characters");

            }
            else if (TB_NationalNo.Text.Contains(" "))
            {
                EP_FillPersonInformation.SetError(TB_NationalNo, "It must not contain ' '");
            }
            else if (Regex.IsMatch(TB_NationalNo.Text, @"[\W_]"))
            {
                EP_FillPersonInformation.SetError(TB_NationalNo, "It must not contain on any Symbol");
            }
            else
            {
                EP_FillPersonInformation.SetError(TB_NationalNo, string.Empty);
            }
        }
        private void TB_Email_TextChanged(object sender, EventArgs e)
        {
            if (TB_Email == null) return;

            if (TB_Email.Text==string.Empty)
            {
                EP_FillPersonInformation.SetError(TB_Email, string.Empty);
                return;
            }


            if (TB_Email.Text.Length < 11)
            {
                EP_FillPersonInformation.SetError(TB_Email, "Text must be greater than 11 characters");
            }
            else if (TB_NationalNo.Text.Contains(" "))
            {
                EP_FillPersonInformation.SetError(TB_Email, "It must not contain ' '");
            }
            else if (!TB_Email.Text.Contains("@gmail.com"))
            {
                EP_FillPersonInformation.SetError(TB_Email, "It must contain on \"@gmail.com\"");
            }
            else
            {
                EP_FillPersonInformation.SetError(TB_Email, string.Empty);
            }


        }
        private void TB_Address_TextChanged(object sender, EventArgs e)
        {
            if (TB_Address.Text==string.Empty)
            {
                EP_FillPersonInformation.SetError(TB_Address, "Where is Address ??!!");
            }
            else if (TB_Address.Text.Length<=2 || TB_Address.Text[0]==' ')
            {
                EP_FillPersonInformation.SetError(TB_Address, "It must be greater than 2 charecters");
            }
            else
            {
                EP_FillPersonInformation.SetError(TB_Address, string.Empty);
            }
        }
        public void FullPersonInfo(ref clsBPeople Person)
        {
            Person.NationalNo = TB_NationalNo.Text;
            Person.FirstName = TB_FirstName.Text;
            Person.SecondName = TB_SecondName.Text;
            Person.ThirdName = TB_ThirdName.Text;
            Person.LastName = TB_LastName.Text;
            Person.Phone=MTB_Phone.Text;
            Person.Gendor=RB_Male.Checked ? "Male" : "Female";
            Person.Email = TB_Email.Text;
            Person.Address = TB_Address.Text;
            Person.NationalityCountryID=clsConvertsData.ConvertFromCountryNameToCountryID(CB_Country.Text);
            
        }

        public bool AreThereNoErrorProviders()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if(EP_FillPersonInformation.GetError(control)!=string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void DefultValue()
        {
            RB_Male.Checked = true;
            TB_FirstName.Text=string.Empty;
            TB_SecondName.Text=string.Empty;
            TB_ThirdName.Text=string.Empty;
            TB_LastName.Text=string.Empty;
            TB_NationalNo.Text=string.Empty;    
            TB_Email.Text=string.Empty;
            TB_Address.Text=string.Empty;
            MTB_Phone.Text=string.Empty;
            DTP_DateOfBirth.Value=DTP_DateOfBirth.MaxDate;
            CB_Country.SelectedItem="Jordan";
        }
        

       
    }
}
