using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDProject
{
    public partial class FindLicense : UserControl
    {
       
        public clsBLicenses License { get; private set; }
        public clsBApplications application { get; private set; }
        private clsBUsers User;
        public bool IsDetain{get;private set;}
        public FindLicense()
        {
            InitializeComponent();
        }
        public void LoadData(clsBUsers User)
        {
            this.User=User;
        }
        private void TB_LicenseID_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void TB_LicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled=true; }
        }
        private void B_Find_Click(object sender, EventArgs e)
        {
            if (TB_LicenseID.Text == string.Empty)
                return;

            int LicenseID = Convert.ToInt32(TB_LicenseID.Text);
            clsBLicenses License = clsBLicenses.Find(LicenseID);

            if (License != null)
            {
                if (License.LicenseClass == 3 && License.IsActive)
                {
                    this.License=License;
                    UC_DriverLicenseInfo.LoadData(License);
                    IsDetain=UC_DriverLicenseInfo.IsDetain;
                    int RequestID = IsThereARequest();
                    if (RequestID > 0)
                    {
                        this.application=clsBApplications.Find(RequestID);
                        UC_Application.LoadDataApp(this.application);
                    }
                    else
                    {

                        if (AddApplication())
                        {
                            UC_Application.LoadDataApp(application);
                        }
                        else
                        {
                            MessageBox.Show("Add Application is failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("This License Cannot be an International License", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("This License is not exist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private int IsThereARequest()
        {
            DataTable dt=clsBApplications.GetAllApplications();
            clsBPeople Person = clsBPeople.Find(clsBDrivers.Find(License.DriverID).PersonID);
            foreach (DataRow dr in dt.Rows)
            {
                int PersonID = Convert.ToInt32(dr["ApplicantPersonID"]);
                int Status = Convert.ToInt32(dr["ApplicationStatus"]);
                int AppType = Convert.ToInt32(dr["ApplicationTypeID"]);
                if(Person.ID == PersonID && (Status == 1 || Status ==2) && AppType==6)
                {
                    return Convert.ToInt32(dr["ApplicationID"]);
                }
            }

            return 0;
        }
        private bool AddApplication()
        {
         
                if (License!=null && User != null)
                {
                    application=new clsBApplications();
                    application.ApplicationStatus=1;
                    application.ApplicationTypeID=6;
                    application.ApplicantPersonID=clsBDrivers.Find(License.DriverID).PersonID;
                    application.ApplicationDate=DateTime.Now;
                    application.LastStatusDate=DateTime.Now;
                    application.CreatedByUserID=User.UserID;
                    application.PaidFees=clsBApplicationTypes.Find(6).ApplicationFees;
                    return application.Save();
                }
                else
                {
                    return false;
                }
            

        }
        private void FindLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
