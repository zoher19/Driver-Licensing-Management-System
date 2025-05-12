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
    public partial class Frm_DetainorRelaseLicense : Form
    {
       public delegate void NewTable(DataTable table);
       public event NewTable DataBack;
        private enum enType { Detain=1,Release=2};
        private enType Type= enType.Detain;
        private clsBLicenses License;
        private clsBApplications application;
        private bool IsDetain = false;
        private clsBUsers User;
        private clsBDetains Detain;
        public Frm_DetainorRelaseLicense(clsBUsers User,int number)
        {
            InitializeComponent();
            this.User = User;
            Type=(enType)number;
            Title();
        }

        private void Title()
        {
            if (Type == enType.Detain)
            {
                L_Title.Text="Detain License";
            }
            else
            {
                L_Title.Text="Relase License";
            }
        }
        private void findLicenseForRenew1_Load(object sender, EventArgs e)
        {

        }

        private void AddDetain()
        {
            clsBDetains detain= new clsBDetains();  

            detain.DetainDate=DateTime.Now;
            detain.CreatedByUserID=User.UserID;
            detain.LicenseID=License.LicenseID;
            detain.FineFees=150;
            detain.IsReleased=false;

            this.Detain = detain;
            if (!detain.Save())
            {
                MessageBox.Show("This detain is not exist","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);    
           
            }
        }

        private void FullData()
        {
            L_DetainID.Text=this.Detain.DetainID.ToString();
            L_DetainDate.Text=this.Detain.DetainDate.ToShortDateString();
            L_FineFees.Text=this.Detain.FineFees.ToString();
            L_LicenseID.Text=this.Detain.LicenseID.ToString();
            if(application != null)
            {
               L_ApplicationFees.Text=application.PaidFees.ToString();
            }
            else
            {
                L_ApplicationFees.Text="0";
            }

            L_CreatedByUser.Text=User.Username;
        }

        private void AddApplication()
        {
            clsBApplications Application = new clsBApplications();

            Application.ApplicationStatus=1;
            Application.ApplicantPersonID=clsBDrivers.Find(License.DriverID).PersonID;
            Application.ApplicationTypeID=5;
            Application.ApplicationDate=DateTime.Now;
            Application.PaidFees=clsBApplicationTypes.Find(5).ApplicationFees;
            Application.LastStatusDate=DateTime.Now;
            Application.CreatedByUserID=User.UserID;

            if(Application.Save())
            {
                this.application = Application;
            }
            else
            {
                MessageBox.Show("This Application is not exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Frm_DetainorRelaseLicense_Load(object sender, EventArgs e)
        {

        }

        private void L_Title_Click(object sender, EventArgs e)
        {
            
        }

        private void B_Issue_Click(object sender, EventArgs e)
        {
            License=RC_Find.License;
            if(License!=null)
            {
                IsDetain=RC_Find.IsDetain;
            if(Type ==enType.Detain)
              {
                if (!IsDetain && License.IsActive)
                   {
                        if (clsBDetains.FindL(License.LicenseID) == null)
                        {
                            AddDetain();
                            FullData();
                            LL_PersonINfo.Enabled = true;
                            LL_ShowLicense.Enabled = true;
                            LL_ShowLicenseHistore.Enabled = true;
                            DataBack?.Invoke(clsBDetains.GetAllDetains());
                        }
                        else
                        {
                            MessageBox.Show("This License Is Detain..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                else
                   {
                       MessageBox.Show("This License Is Detain..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                   }

              }
            else
            {
                    Detain=clsBDetains.FindL(License.LicenseID);
                    if(Detain != null )
                    {
                        if (!Detain.IsReleased)
                        {
                            AddApplication();
                            Detain.IsReleased = true;
                            Detain.ReleaseApplicationID=application.ApplicationID;
                            Detain.ReleasedByUserID=User.UserID;
                            Detain.ReleaseDate=DateTime.Now;
                            Detain.Save();
                            FullData();
                            MessageBox.Show("Release Detain is done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataBack?.Invoke(clsBDetains.GetAllDetains());
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("this License is not detain..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
              

            }
            else
            {
                MessageBox.Show("Where is license..","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LL_ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_LicenseDetails showlicense=new Frm_LicenseDetails(License);
            showlicense.ShowDialog();
        }

        private void GB_DetainInfo_Enter(object sender, EventArgs e)
        {

        }

        private void LL_ShowLicenseHistore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ShowLicenseHistorecs H = new Frm_ShowLicenseHistorecs(clsBPeople.Find(clsBDrivers.Find(License.DriverID).PersonID));
            H.ShowDialog();
        }

        private void LL_PersonINfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_PersonDetails Person=new Frm_PersonDetails(clsBDrivers.Find(License.DriverID).PersonID);
            Person.ShowDialog();
        }
    }
}
