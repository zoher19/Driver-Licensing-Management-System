using BusinessLayerDVLD;
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
    public partial class IntLicenseCard : UserControl
    {
        public IntLicenseCard()
        {
            InitializeComponent();
        }

        public void LoadData(clsBInternationalDrivingLicenses IntLicense)
        {
            if (IntLicense != null)
            {
                int ID = IntLicense.IssuedUsingLocalLicenseID;
                clsBPeople Person = clsBPeople.Find(clsBDrivers.Find(IntLicense.DriverID).PersonID);
                
                L_Name.Text="   " +Person.FirstName + " "+ Person.SecondName+ " "+ Person.ThirdName+ " "+ Person.LastName;
                L_DateOfBith.Text="   " +Person.DateOfBirth.ToShortDateString();
                L_IsActive.Text="   " + (IntLicense.IsActive ? "Yes" : "No");
                L_IssueDate.Text="   " +IntLicense.IssueDate.ToShortDateString();
                L_ExiprationDate.Text="   " +IntLicense.ExpirationDate.ToShortDateString();
                L_Gendor.Text="   " +Person.Gendor;
                L_DriverID.Text="   " +IntLicense.DriverID.ToString();
                L_NationalNo.Text="   " +Person.NationalNo.ToString();
                L_IntLiceseID.Text="   " +ID.ToString();
            }
            else
            {
                MessageBox.Show("This License is not find..", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GB_InternationalDriverLicense_Enter(object sender, EventArgs e)
        {

        }
    }
}
