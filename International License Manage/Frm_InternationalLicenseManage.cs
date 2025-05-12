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
    public partial class Frm_InternationalLicenseManage : Form
    {
        private clsBUsers User;
        private DataTable IntLicesnes;
        public Frm_InternationalLicenseManage(clsBUsers User)
        {
            InitializeComponent();
            this.User = User;
            this.IntLicesnes=clsBInternationalDrivingLicenses.GetAllLicenses();
            Full();
        }

        private void Full()
        {
            DGV_IntLicenses.Rows.Clear();
            foreach(DataRow row in IntLicesnes.Rows)
            {
                int IntLicID = Convert.ToInt32(row["InternationalLicenseID"]);
                int ApplicationID = Convert.ToInt32(row["ApplicationID"]);
                int DriverID = Convert.ToInt32(row["DriverID"]);
                int LicenseID = Convert.ToInt32(row["IssuedUsingLocalLicenseID"]);
                string IssueDate = row["IssueDate"].ToString();
                string ExpirationDate = row["ExpirationDate"].ToString();
                bool IsActive = Convert.ToBoolean(row["IsActive"]);
                
                DGV_IntLicenses.Rows.Add(IntLicID,ApplicationID, DriverID, LicenseID,IssueDate, ExpirationDate,IsActive);
            
            }

            L_Recourds.Text=DGV_IntLicenses.Rows.Count.ToString();
        }

        private void Full(DataTable IntLicesnes)
        {
            this.IntLicesnes=IntLicesnes;
            DGV_IntLicenses.Rows.Clear();
            foreach (DataRow row in this.IntLicesnes.Rows)
            {
                int IntLicID = Convert.ToInt32(row["InternationalLicenseID"]);
                int ApplicationID = Convert.ToInt32(row["ApplicationID"]);
                int DriverID = Convert.ToInt32(row["DriverID"]);
                int LicenseID = Convert.ToInt32(row["IssuedUsingLocalLicenseID"]);
                string IssueDate = row["IssueDate"].ToString();
                string ExpirationDate = row["ExpirationDate"].ToString();
                bool IsActive = Convert.ToBoolean(row["IsActiver"]);

                DGV_IntLicenses.Rows.Add(IntLicID, ApplicationID, DriverID, LicenseID, IssueDate, ExpirationDate, IsActive);

            }

            L_Recourds.Text=DGV_IntLicenses.Rows.Count.ToString();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void B_AddIntLicense_Click(object sender, EventArgs e)
        {
            Frm_InternationalLicenseApplication internationalLicenseApplication=new Frm_InternationalLicenseApplication(User);
            internationalLicenseApplication.DataBack+=Full;
            internationalLicenseApplication.ShowDialog();
        }

        private void TMS_ShowPersonDetails_Click(object sender, EventArgs e)
        {
            int intLicenseID = Convert.ToInt32(DGV_IntLicenses.SelectedRows[0].Cells["C_IntLicense"].Value);
            clsBInternationalDrivingLicenses IntLicense = clsBInternationalDrivingLicenses.Find(intLicenseID);
            Frm_PersonDetails Person = new Frm_PersonDetails(clsBApplications.Find(IntLicense.ApplicationID).ApplicantPersonID);
            Person.ShowDialog();    
        }

        private void TMS_ShowLicenseDetails_Click(object sender, EventArgs e)
        {
            int intLicenseID = Convert.ToInt32(DGV_IntLicenses.SelectedRows[0].Cells["C_IntLicense"].Value);
            clsBInternationalDrivingLicenses IntLicense = clsBInternationalDrivingLicenses.Find(intLicenseID);
            Frm_InternationalLicenseInfo Info = new Frm_InternationalLicenseInfo(IntLicense);
            Info.ShowDialog();

        }

        private void TMS_ShowLicenseHistore_Click(object sender, EventArgs e)
        {
            int intLicenseID = Convert.ToInt32(DGV_IntLicenses.SelectedRows[0].Cells["C_IntLicense"].Value);
            clsBInternationalDrivingLicenses IntLicense = clsBInternationalDrivingLicenses.Find(intLicenseID);
            Frm_ShowLicenseHistorecs licenseHistorecs = new Frm_ShowLicenseHistorecs(clsBPeople.Find(clsBApplications.Find(IntLicense.ApplicationID).ApplicantPersonID));
            licenseHistorecs.ShowDialog();
        }

        private void Frm_InternationalLicenseManage_Load(object sender, EventArgs e)
        {

        }
    }
}
