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
    public partial class Frm_DetainManagecs : Form
    {
        private DataTable TDetain;
        private clsBUsers User;

        public Frm_DetainManagecs(clsBUsers user)
        {
            InitializeComponent();
            TDetain=clsBDetains.GetAllDetains();
            User=user;
            fullTable();
        }

        private void fullTable()
        {
            DGV_Detain.Rows.Clear();
            foreach(DataRow row in TDetain.Rows)
            {
                int DetainID = Convert.ToInt32(row["DetainID"]);
                int LicenseID = Convert.ToInt32(row["LicenseID"]);
                decimal FineFees = Convert.ToDecimal(row["FineFees"]);
                string DetainDate = Convert.ToDateTime(row["DetainDate"]).ToShortDateString();
                bool IsReleased = Convert.ToBoolean(row["IsReleased"]);
                string ReleaseDate;
                int AppID;
                if (IsReleased)
                {
                    ReleaseDate = Convert.ToDateTime(row["ReleaseDate"]).ToString();
                    AppID = Convert.ToInt32(row["ReleaseApplicationID"]);
                }
                else
                {
                    ReleaseDate="00/00/0000";
                    AppID=-1;
                }


                clsBPeople Person = clsBPeople.Find(clsBDrivers.Find(clsBLicenses.Find(LicenseID).DriverID).PersonID);
                string NationalNO = Person.NationalNo;
                string FullName = Person.FirstName + " "+ Person.SecondName + " "+ Person.ThirdName+ " "+ Person.LastName;

                DGV_Detain.Rows.Add(DetainID, LicenseID, DetainDate, IsReleased, FineFees, ReleaseDate, NationalNO, FullName,
                    AppID);
            }
            L_Recourds.Text=DGV_Detain.Rows.Count.ToString();
        }

        private void fullTable(DataTable dt)
        {
            TDetain=dt;
            fullTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_Detain_Click(object sender, EventArgs e)
        {
            Frm_DetainorRelaseLicense DetainLicense =new Frm_DetainorRelaseLicense(User, 1);
            DetainLicense.DataBack+=fullTable;
            DetainLicense.ShowDialog();
        }

        private void TMS_ShowPersonDetails_Click(object sender, EventArgs e)
        {
            int DriverID= clsBLicenses.Find(Convert.ToInt32(DGV_Detain.SelectedRows[0].Cells["C_LicenseID"].Value)).DriverID;
            int PersonID = clsBDrivers.Find(DriverID).PersonID;

            Frm_PersonDetails Person = new Frm_PersonDetails(PersonID);
            Person.ShowDialog();
        }

        private void ShowLicenseDetails_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(DGV_Detain.SelectedRows[0].Cells["C_LicenseID"].Value);
            Frm_LicenseDetails License = new Frm_LicenseDetails(clsBLicenses.Find(LicenseID));
            License.ShowDialog();
        }

        private void TMS_ShowLicenseHistoreDetails_Click(object sender, EventArgs e)
        {
            int DriverID = clsBLicenses.Find(Convert.ToInt32(DGV_Detain.SelectedRows[0].Cells["C_LicenseID"].Value)).DriverID;
            int PersonID = clsBDrivers.Find(DriverID).PersonID;

            Frm_ShowLicenseHistorecs H = new Frm_ShowLicenseHistorecs(clsBPeople.Find(PersonID));
            H.ShowDialog();

        }

        private void TMS_ReleaseLicense_Click(object sender, EventArgs e)
        {
            Frm_DetainorRelaseLicense DetainLicense = new Frm_DetainorRelaseLicense(User, 2);
            DetainLicense.DataBack+=fullTable;
            DetainLicense.ShowDialog();
        }


    }
}
