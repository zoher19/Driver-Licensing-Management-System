using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject
{
    public partial class Frm_InternationalLicenseApplication : Form
    {
        public delegate void NewTable(DataTable table);
        public event NewTable DataBack;

        private clsBLicenses License;
        private clsBUsers User;
        private clsBApplications application;
        private clsBInternationalDrivingLicenses IntLicense;
           public Frm_InternationalLicenseApplication(clsBUsers user)
        {
            InitializeComponent();
            this.User=user;
            UC_FindLicense.LoadData(this.User);
           
        }

        
            private void Frm_InternationalLicenseApplication_Load(object sender, EventArgs e)
            {

            }

            

            private void B_Issue_Click(object sender, EventArgs e)
            {
            License=UC_FindLicense.License;
            application=UC_FindLicense.application;

            if(License != null && application != null)
            {
                if (!UC_FindLicense.IsDetain)
                {
                    if (!clsBInternationalDrivingLicenses.IsExistLicense(License.LicenseID))
                    {
                        clsBInternationalDrivingLicenses ILicense=new clsBInternationalDrivingLicenses();
                        ILicense.ApplicationID=application.ApplicationID;
                        ILicense.IssuedUsingLocalLicenseID=License.LicenseID;
                        ILicense.DriverID=License.DriverID;
                        ILicense.IsActive=true;
                        ILicense.CreatedByUserID=User.UserID;
                        ILicense.IssueDate=DateTime.Now;
                        ILicense.ExpirationDate=DateTime.Now.AddYears(1);

                        if (ILicense.Save())
                        {
                            MessageBox.Show("Add International License is done...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            IntLicense=ILicense;
                            LL_ShowIntLicenseInfo.Enabled=true;
                            application.ApplicationStatus=2;
                            application.Save();
                            DataBack?.Invoke(clsBInternationalDrivingLicenses.GetAllLicenses());

                        }
                        else
                        {
                            MessageBox.Show("Add International License is Failed...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("International License for this license is exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("This license is detain...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Where Is License ?!.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

            private void UC_ApplicationInfo_Load(object sender, EventArgs e)
            {

            }

            private void B_Close_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            

            private void LL_ShowLicenseHistore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                License=UC_FindLicense.License;
                if (License != null)
                {
                    clsBDrivers Driver = clsBDrivers.Find(License.DriverID);
                    if (Driver != null)
                    {
                        Frm_ShowLicenseHistorecs licenseHistorecs = new Frm_ShowLicenseHistorecs(clsBPeople.Find(Driver.PersonID));
                        licenseHistorecs.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No License ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No License ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }

             private void LL_ShowIntLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_InternationalLicenseInfo ShowIntLicneseInfo = new Frm_InternationalLicenseInfo(IntLicense);
            ShowIntLicneseInfo.ShowDialog();
        }
    }

    }
