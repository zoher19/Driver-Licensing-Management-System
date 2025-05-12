using BusinessLayerDVLD;
using DVLDProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject
{
    public partial class PersonCard : UserControl
    {
        
        private clsBPeople Person;
        public PersonCard()
        {
            InitializeComponent();
        }
        public void FillCardInfo(clsBPeople Person,bool IsAllowedEdit=true)
        {
            LL_EditPerson.Visible = IsAllowedEdit;
            this.Person = Person;
           

            L_PersonID.Text=Person.ID.ToString();
            L_FullName.Text=Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " "+ Person.LastName;
            L_DateOfBith.Text=Person.DateOfBirth.ToShortDateString();
            L_Gendor.Text=Person.Gendor;
            L_Email.Text=Person.Email;
            L_Phone.Text=Person.Phone;
            L_Address.Text=Person.Address;
            L_NationalityCountry.Text=clsConvertsData.ConvertFromCountryIDToCountryName(Person.NationalityCountryID);
            
            if(Person.ImagePath == string.Empty)
            {
                PB_Photo.Image=Person.Gendor == "Male" ? Resources.person_boy : Resources.person_girl;
            }
            

        }
        private void PersonCard_Load(object sender, EventArgs e)
        {

        }
        private void LL_EditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
           
                Frm_AddorEditPerson editPerson = new Frm_AddorEditPerson(Person.ID,Person.FirstName,
                    Person.SecondName,Person.ThirdName,Person.LastName,
                    Person.NationalNo,Person.DateOfBirth,Person.Gendor,Person.Phone
                    ,Person.Email,Person.Address,Person.NationalityCountryID,Person.ImagePath);

                    editPerson.ShowDialog();
            
        }
    }
}
