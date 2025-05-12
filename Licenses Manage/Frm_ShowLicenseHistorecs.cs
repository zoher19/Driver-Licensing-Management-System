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

namespace DVLDProject
{
    public partial class Frm_ShowLicenseHistorecs : Form
    {
        private clsBPeople Person;
        private DataTable LocalLicense;
        private DataTable InternationalLicense;
        public Frm_ShowLicenseHistorecs(clsBPeople Person)
        {
            InitializeComponent();
            this.Person = Person;
            int DriverID = clsBDrivers.FindPerson(Person.ID).DriverID;
            LocalLicense=clsBLicenses.GetAllLicenses(DriverID);
            InternationalLicense=clsBInternationalDrivingLicenses.GetAllLicenses(DriverID);
            UC_PersonCard.FillCardInfo(Person);
            if (LocalLicense!=null)
            {
                FullLocalLicenseTable();
                L_Recourd.Text=DGV_LocalLicense.Rows.Count.ToString();
            }
            else
            {
                return;
            }

            if (InternationalLicense!=null)
            {
                FullInternationlTable();

            }
            else
            {
                return;
            }
        }

        private void FullLocalLicenseTable()
        {
            DGV_LocalLicense.Rows.Clear();
            foreach (DataRow dr in LocalLicense.Rows)
            {
                int LicenseID = Convert.ToInt32(dr["LicenseID"]);
                int ApplicationID = Convert.ToInt32(dr["ApplicationID"]);
                int LicenseClassID = Convert.ToInt32(dr["LicenseClass"]);
                string ClassName = clsBLicenseClasses.Find(LicenseClassID).ClassName;
                string IssueDate = Convert.ToDateTime(dr["IssueDate"]).ToShortDateString();
                string ExiprationDate= Convert.ToDateTime(dr["ExpirationDate"]).ToShortDateString();
                bool IsActive = Convert.ToBoolean(dr["IsActive"]);

                DGV_LocalLicense.Rows.Add(LicenseID,ApplicationID,ClassName,IssueDate, ExiprationDate,IsActive);
            }
        }

        private void FullInternationlTable()
        {
            DGV_InternationalLicense.Rows.Clear();  

            foreach(DataRow row in InternationalLicense.Rows)
            {
                int IntLicenseID = Convert.ToInt32(row["InternationalLicenseID"]);
                int AppID = Convert.ToInt32(row["ApplicationID"]);
                int LicenseID = Convert.ToInt32(row["IssuedUsingLocalLicenseID"]);
                string IssueDate = Convert.ToDateTime(row["IssueDate"]).ToShortDateString();
                string ExpirationDate = Convert.ToDateTime(row["ExpirationDate"]).ToShortDateString();

                DGV_InternationalLicense.Rows.Add(IntLicenseID,AppID,LicenseID,IssueDate,ExpirationDate);
            }
        }
        private void Frm_ShowLicenseHistorecs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UC_PersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}
