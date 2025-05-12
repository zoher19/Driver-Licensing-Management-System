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
    public partial class Frm_AddNewLocalDrivingLicense : Form
    {
        public delegate void AddNewLocal(DataTable dataTable);
        public event AddNewLocal DataBack;

        private clsBPeople Person;
        private clsBUsers User;
        private clsBApplications Applications;
        private clsBLocalDrivingLicenseApplications LocalDrivingLicenseApplications;
        public Frm_AddNewLocalDrivingLicense()
        {
            InitializeComponent();
            
        }

        public Frm_AddNewLocalDrivingLicense(clsBUsers User)
        {
            InitializeComponent();
            this.User= User;
            TC_AddLocalDrivingLicense.TabPages[1].Enabled = false;
            FillLicenseClasses();
            L_ApplicationDate.Text="   " +DateTime.Now.ToShortDateString();
            L_CreatedByUser.Text=this.User.Username;
            L_Fees.Text=clsBApplicationTypes.Find(1).ApplicationFees.ToString() +" $";
        }

        private void FillLicenseClasses()
        {
            DataTable dt = clsBLicenseClasses.GetAllLicenseClasses();

            foreach (DataRow dr in dt.Rows)
            {
                CB_LicenseClass.Items.Add(dr["ClassName"].ToString());
            }
        }

        private void AddNewLocalDrivingLicense_Load(object sender, EventArgs e)
        {

        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            if (UC_PersonCard.Person != null)
            {
               int PersonID=UC_PersonCard.Person.ID;
               Person = clsBPeople.Find(PersonID);

                if (Person != null)
                {
                    TC_AddLocalDrivingLicense.TabPages[1].Enabled = true;
                    TC_AddLocalDrivingLicense.SelectedIndex = 1;

                }
                else
                {
                    MessageBox.Show("This Person is not exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TC_AddLocalDrivingLicense.TabPages[1].Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Where is person", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TC_AddLocalDrivingLicense.TabPages[1].Enabled = false;
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddApplications()
        {
            this.Applications=new clsBApplications();

            Applications.ApplicationStatus = 1;
            // 1 =new ,2=completed,3=canseld
            Applications.ApplicantPersonID=this.Person.ID;
            Applications.ApplicationDate=DateTime.Now;
            Applications.LastStatusDate=DateTime.Now;
            Applications.ApplicationTypeID=1;
            Applications.PaidFees=clsBApplicationTypes.Find(1).ApplicationFees;
            Applications.CreatedByUserID=this.User.UserID;

            if (!Applications.Save())
            {
                MessageBox.Show("This Application is wrong..Try Again","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddLocalDrivingApplication()
        {
            this.LocalDrivingLicenseApplications=new clsBLocalDrivingLicenseApplications();

            this.LocalDrivingLicenseApplications.ApplicationID=this.Applications.ApplicationID;
            this.LocalDrivingLicenseApplications.LicenseClassID=clsBLicenseClasses.Find(CB_LicenseClass.Text).LicenseClassID;

            if (!this.LocalDrivingLicenseApplications.Save())
            {
                MessageBox.Show("This LocalApplication is wrong..Try Again", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsThereAnyApplications()
        {
            
            DataTable LocalDrivingApplication=clsBLocalDrivingLicenseApplications.GetAllApplications();

            foreach (DataRow dr in LocalDrivingApplication.Rows)
            {
                clsBApplications Application = clsBApplications.Find(Convert.ToInt32(dr["ApplicationID"]));
                if (Application.ApplicantPersonID==this.Person.ID)
                {
                    if ((Convert.ToInt32(dr["LicenseClassID"]) == clsBLicenseClasses.Find(CB_LicenseClass.SelectedItem.ToString()).LicenseClassID && !(Application.ApplicationStatus == 3)))
                        return true;
                }
                
            }
            return false;   
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            if(CB_LicenseClass.SelectedIndex == -1)
            {
                return;
            }

            if(!IsThereAnyApplications())
            {
                AddApplications();
                AddLocalDrivingApplication();
                L_ApplicationID.Text=this.LocalDrivingLicenseApplications.ID.ToString();
                DataBack?.Invoke(clsBLocalDrivingLicenseApplications.GetAllApplications());
                this.Close();
                MessageBox.Show("Your Request is under review","Confirm Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is an active Request ...", "Wrong Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







    }
}
