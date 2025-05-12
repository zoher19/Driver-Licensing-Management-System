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
    public partial class Frm_IssueDriverLicense : Form
    {
        private clsBLocalDrivingLicenseApplications LocalDrivingLicenseApplications;
        private clsBUsers User;
        public Frm_IssueDriverLicense(clsBLocalDrivingLicenseApplications localDrivingLicenseApplications,clsBUsers User)
        {
            InitializeComponent();
            this.LocalDrivingLicenseApplications = localDrivingLicenseApplications;
            this.User=User;
            UC_LocalApplicationInfo.LoadData(LocalDrivingLicenseApplications);
        }

        private void Frm_IssueDriverLicense_Load(object sender, EventArgs e)
        {

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDriver(ref int DriverID)
        {
            clsBPeople Person = clsBPeople.Find(clsBApplications.Find(this.LocalDrivingLicenseApplications.ApplicationID).ApplicantPersonID);
            clsBDrivers Driver = clsBDrivers.FindPerson(Person.ID);

            if (Driver == null)
            {
                Driver=new clsBDrivers();
                Driver.CreatedByUserID = User.UserID;
                Driver.CreatedDate = DateTime.Now;
                Driver.PersonID=Person.ID;
                if (Driver.Save())
                {
                    DriverID=Driver.DriverID;
                }
            }
            else
            {
                DriverID=Driver.DriverID;
                return;
            }
        }

        private void AddLicense()
        {
            int DriverID = 0;
            AddDriver(ref DriverID);

            if(DriverID > 0)
            {
                clsBLicenses License= new clsBLicenses();
                clsBLicenseClasses LicenseClass = clsBLicenseClasses.Find(this.LocalDrivingLicenseApplications.LicenseClassID);

                License.DriverID = DriverID;
                License.ApplicationID=this.LocalDrivingLicenseApplications.ApplicationID;
                License.LicenseClass=LicenseClass.LicenseClassID;
                License.PaidFees=LicenseClass.ClassFees;
                License.IssueReason=1;
                License.CreatedByUserID= User.UserID;
                License.Notes=TB_Notes.Text;
                License.IssueDate=DateTime.Now;
                License.ExpirationDate=License.IssueDate.AddYears(LicenseClass.MinimumAllowedAge);
                License.IsActive=License.ExpirationDate > License.IssueDate;

                if(License.Save())
                {
                    MessageBox.Show($"The license has been created successfullly [ ID = {License.LicenseID} ]", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An Error occurred while creating the license .Try again later","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("There is an error adding the driver.Try again...", "Driver Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void B_Issue_Click(object sender, EventArgs e)
        {
            AddLicense();
        }
    }
}
