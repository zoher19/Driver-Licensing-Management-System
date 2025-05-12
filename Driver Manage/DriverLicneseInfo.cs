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
    public partial class DriverLicneseInfo : UserControl
    {
        public bool IsDetain { get; private set; }
        public DriverLicneseInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }
        public void LoadData(clsBLicenses License)
        {
            if(License != null)
            {
                int ID = License.LicenseID;
                clsBPeople Person = clsBPeople.Find(clsBDrivers.Find(License.DriverID).PersonID);

                L_Class.Text="   " +clsBLicenseClasses.Find(License.LicenseClass).ClassName;
                L_Name.Text="   " +Person.FirstName + " "+ Person.SecondName+ " "+ Person.ThirdName+ " "+ Person.LastName;
                L_DateOfBith.Text="   " +Person.DateOfBirth.ToShortDateString();
                L_IsActive.Text="   " + (License.IsActive ? "Yes" : "No");
                L_IssueDate.Text="   " +License.IssueDate.ToShortDateString();
                L_ExiprationDate.Text="   " +License.ExpirationDate.ToShortDateString();
                L_Gendor.Text="   " +Person.Gendor;
                L_Notes.Text="   " +(License.Notes == string.Empty ? "No Notes" : License.Notes);
                L_DriverID.Text="   " +License.DriverID.ToString();
                L_NationalNo.Text="   " +Person.NationalNo.ToString();
                IsDetain=clsBDetains.FindL(License.LicenseID) != null;
                L_IsDetained.Text="   " +(IsDetain ? "Yes" : "No");
                L_LicenseID.Text="   " + License.LicenseID.ToString();

               switch(License.IssueReason)
                {
                    case 1:
                        L_IssueResounse.Text="First Time";
                        break;
                    case 2:
                        L_IssueResounse.Text="Renew License";
                        break;
                    case 3:
                        L_IssueResounse.Text="Lost License";
                        break;
                    case 4:
                        L_IssueResounse.Text="Damage License";
                        break;
                }
            }
            else
            {
                MessageBox.Show("This License is not find..","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DriverLicneseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
