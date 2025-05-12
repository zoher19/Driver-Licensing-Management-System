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
    public partial class Frm_TakeTest : Form
    {
        public delegate void NewTable(DataTable table);
        public event NewTable DataBake;

        private clsBTestAppointments TestAppointment;
        private clsBLocalDrivingLicenseApplications LocalDrivingLicenseApplication;
        private clsBUsers User;
        public Frm_TakeTest(clsBLocalDrivingLicenseApplications LocalApplication, clsBTestAppointments TestAppointment,clsBUsers User)
        {
            InitializeComponent();
            this.TestAppointment = TestAppointment;
            this.LocalDrivingLicenseApplication = LocalApplication;
            this.User = User;
            FullData();
        }

        public void FullData()
        {
            L_AppID.Text="   " + this.LocalDrivingLicenseApplication.ID.ToString();
            L_ClassName.Text="   " +clsBLicenseClasses.Find(this.LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            L_PasedTests.Text="   "+ HowManySuccessfulTests(this.LocalDrivingLicenseApplication.ID)+"/3";
            L_Fees.Text="   " +clsBApplications.Find(this.LocalDrivingLicenseApplication.ApplicationID).ToString();

        }
        private int HowManySuccessfulTests(int LocalApplicationID)
        {
            int number = 0;
            DataTable TestAppoiments = clsBTestAppointments.GetAllTestAppointments();

            foreach (DataRow row in TestAppoiments.Rows)
            {
                bool IsLoced = Convert.ToBoolean(row["IsLocked"]);
                int LocalDrivingLicenseapplicationID = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);

                if (IsLoced)
                {
                    clsBTests Test = clsBTests.FindA(Convert.ToInt32(row["TestAppointmentID"]));

                    if (Test.TestResult && (LocalDrivingLicenseapplicationID == LocalApplicationID))
                    {
                        number++;
                    }

                }
            }
            return number;
        }

        private void Frm_TakeTest_Load(object sender, EventArgs e)
        {

        }

        public void TakeDate( ref clsBTests Test)
        {
            Test.TestAppointmentID=this.TestAppointment.TestAppointmentID;
            Test.TestResult=RB_Pass.Checked;
            Test.Notes=TB_Note.Text;
            Test.CreatedByUserID=User.UserID;
            TestAppointment.IsLocked=true;
            TestAppointment.Save();
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            clsBTests Test=new clsBTests();
            TakeDate( ref Test );

            if (Test.Save())
            {
                DataBake?.Invoke(clsBTestAppointments.GetAllTestAppointments());
                this.Close();
            }
            else
            {
                MessageBox.Show("Error .. Try again letter","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
