using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject
{
    public partial class Frm_RenewLicense : Form
    {
        private clsBLicenses License;
        private clsBLicenses NewLicense;
        private clsBUsers User;
        private clsBApplications application;
        private enum enType { Renew=1,Replacement=2};
        private enType Type=enType.Renew;
        public Frm_RenewLicense(clsBUsers User,int number)
        {
            InitializeComponent();
            this.User = User;
            if(number > 0  && number <=2)
            {
                Type=(enType)(number);
                Title();
            }
         
        }

        public void Title()
        {
            if(Type==enType.Renew)
            {
                L_Title.Text="Renew License";
                GB_ReplacementFor.Visible=false;
            }
            else
            {
                L_Title.Text="Replacement License";
                GB_ReplacementFor.Visible=true;
            }
        }

        private void Frm_RenewLicense_Load(object sender, EventArgs e)
        {

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        public void AddApplication()
        {
            application=new clsBApplications();
            application.ApplicationStatus=2;
            application.ApplicationDate=DateTime.Now;
            application.LastStatusDate=DateTime.Now;
           application.ApplicantPersonID=clsBDrivers.Find(License.DriverID).PersonID;
            application.CreatedByUserID=User.UserID;

            if(Type == enType.Renew)
            {
                application.ApplicationTypeID=2;
                application.PaidFees=clsBApplicationTypes.Find(application.ApplicationTypeID).ApplicationFees;
            }
            else
            {
                if(RB_DemagedLicense.Checked)
                {
                    application.ApplicationTypeID=4;
                }
                else if(RB_LostLicense.Checked)
                {
                    application.ApplicationTypeID=3;
                }
            }

            application.PaidFees=clsBApplicationTypes.Find(application.ApplicationTypeID).ApplicationFees;
            if (!application.Save())
            {
                MessageBox.Show("Application is not exist ...","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
       
        public void FullApplication()
        {
            L_ID.Text="   "+application.ApplicationID.ToString();
            L_Date.Text="   "+application.ApplicationDate.ToString();
            L_CreatedByUser.Text="   "+User.Username;
            L_Fees.Text="   "+application.PaidFees.ToString();
            L_StatusDate.Text="   "+application.LastStatusDate.ToString();
            L_Type.Text="   "+clsBApplicationTypes.Find(application.ApplicationTypeID).ApplicationTypeTitle;
            clsBPeople person= clsBPeople.Find(application.ApplicantPersonID);
            L_Applicant.Text="   "+person.FirstName + " "+person.SecondName + " "+person.ThirdName + " "+person.LastName;
            L_OldLicenseID.Text="   "+this.License.LicenseID.ToString();



        }

        public clsBLicenses AddLicense()
        {
            clsBLicenses Nlicense = new clsBLicenses();

            Nlicense.IsActive = true;
            Nlicense.IssueDate=DateTime.Now;
            clsBLicenseClasses LicenseClass = clsBLicenseClasses.Find(this.License.LicenseClass);
            Nlicense.LicenseClass=this.License.LicenseClass;
            Nlicense.ExpirationDate=DateTime.Now.AddYears(LicenseClass.MinimumAllowedAge);
            Nlicense.ApplicationID=application.ApplicationID;
            Nlicense.DriverID=this.License.DriverID;
            Nlicense.CreatedByUserID=User.UserID;
            Nlicense.PaidFees=this.License.PaidFees;
            
            
            if (Type == enType.Renew)
            {
                Nlicense.IssueReason=2;
            }
            else
            {
                if (RB_DemagedLicense.Checked)
                {
                    Nlicense.IssueReason=4;
                }
                else if (RB_LostLicense.Checked)
                {
                    Nlicense.IssueReason=3;
                }
            }

            if (Nlicense.Save())
            {
                NewLicense= Nlicense;
            }

            return NewLicense;

        }

        private void B_Issue_Click(object sender, EventArgs e)
        {
            License= UC_FindLicenseRenew.License;
            if (License == null)
            {
                MessageBox.Show("License is not exist ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(Type == enType.Renew)
                if (License.IssueDate >= License.ExpirationDate && !UC_FindLicenseRenew.IsDetain && License.IsActive)
                {
                    License.IsActive=false;
                    License.Save();
                    AddApplication();
                    FullApplication();
                    if (AddLicense() != null)
                    {
                        MessageBox.Show("Renew Licesne is done...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LL_PersonINfo.Enabled=true;
                        LL_ShowLicense.Enabled=true;
                        LL_ShowLicenseHistore.Enabled=true;
                        L_RenwedLicenseID.Text="   "+NewLicense.LicenseID.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Renew Licesne is Failed...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("This Licene is valid...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (!UC_FindLicenseRenew.IsDetain && License.IsActive)
                    {
                        License.IsActive=false;
                        License.Save();
                        AddApplication();
                        FullApplication();
                        if (AddLicense() != null)
                        {
                            MessageBox.Show("Replacement Licesne is done...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LL_PersonINfo.Enabled=true;
                            LL_ShowLicense.Enabled=true;
                            LL_ShowLicenseHistore.Enabled=true;
                            L_RenwedLicenseID.Text="   "+NewLicense.LicenseID.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Replacement Licesne is Failed...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("This Licene is valid...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }

        private void LL_PersonINfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_PersonDetails person=new Frm_PersonDetails(application.ApplicantPersonID);
            person.ShowDialog();
        }

        private void LL_ShowLicenseHistore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ShowLicenseHistorecs H=new Frm_ShowLicenseHistorecs(clsBPeople.Find(application.ApplicantPersonID));
            H.ShowDialog();
        }

        private void LL_ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_LicenseDetails License = new Frm_LicenseDetails(NewLicense);

            License.ShowDialog();
        }
    }
}
