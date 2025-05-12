using BusinessLayerDVLD;
using DVLDProject.Properties;
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
    public partial class Frm_VisionTest : Form
    {
        public delegate void NewTable(DataTable table);
        public event NewTable DataBack;

        private clsBLocalDrivingLicenseApplications LocalApplication;
        private clsBUsers User;
        private DataTable Appointmetns;
        public enum enTestType { Vision=1,Writing=2,Street=3 };
        public enTestType TestType = enTestType.Vision;

        private void FullTable()
        {
            DGV_AppointmentDetails.Rows.Clear();
            foreach(DataRow row in Appointmetns.Rows)
            {
                int LocalDrivingLicenseApplicationID = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);
                int TestTypeID = Convert.ToInt32(row["TestTypeID"]);
                if ((LocalDrivingLicenseApplicationID== LocalApplication.ID) && (TestTypeID == Convert.ToInt32(this.TestType)))
                {
                    int AppointmentID = Convert.ToInt32(row["TestAppointmentID"]);
                    string AppointmentDate = Convert.ToDateTime(row["AppointmentDate"]).ToShortDateString();
                    string PaidFees = row["PaidFees"].ToString();
                    bool IsLocked = Convert.ToBoolean(row["IsLocked"]);

                    DGV_AppointmentDetails.Rows.Add(AppointmentID, AppointmentDate, PaidFees, IsLocked);
                }
            }
        }

        private void FullTableInBack(DataTable NewTable)
        {
            this.Appointmetns=NewTable;
            DataBack?.Invoke(clsBLocalDrivingLicenseApplications.GetAllApplications());
            FullTable();
        }
        public Frm_VisionTest(clsBLocalDrivingLicenseApplications LocalApplication, clsBUsers user,int TypeTestID)
        {
            InitializeComponent();
            this.LocalApplication = LocalApplication;
            this.User= user;

            this.TestType = (enTestType)TypeTestID;
            CheckOnTestType();

            UC_LocalApplicationInfo.LoadData(LocalApplication);
            this.Appointmetns=clsBTestAppointments.GetAllTestAppointments();
            FullTable();
            User=user;
        }

        private void Frm_VisionTest_Load(object sender, EventArgs e)
        {

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool DidYouTakeTheTestAndPass()
        {
            foreach (DataRow row in Appointmetns.Rows)
            {
                int LocalDrivingLicenseApplicationID = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);
                int TestTypeID = Convert.ToInt32(row["TestTypeID"]);
                if ((LocalDrivingLicenseApplicationID== LocalApplication.ID) && (TestTypeID == Convert.ToInt32(TestType)))
                {
                    int AppointmentID = Convert.ToInt32(row["TestAppointmentID"]);
                    bool IsLocked = Convert.ToBoolean(row["IsLocked"]);

                    if (IsLocked)
                    {
                        clsBTests Test = clsBTests.FindA(AppointmentID);

                        if (Test != null)
                        {
                            if (Test.TestResult ==  true)
                            {
                                return true;
                            }
                           
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void B_AddAppointment_Click(object sender, EventArgs e)
        {
                if (DidYouTakeTheTestAndPass())
                {
                    MessageBox.Show("You have already passed or this test is not locked..Go to another Test", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    Frm_SchedulTest schedulTest = new Frm_SchedulTest(LocalApplication,User,Convert.ToInt32(this.TestType));
                    schedulTest.DataBack+=FullTableInBack;
                    schedulTest.ShowDialog();
                }
            
            }

        private void TMS_EditAppointment_Click(object sender, EventArgs e)
        {

            int AppID =Convert.ToInt32(DGV_AppointmentDetails.SelectedRows[0].Cells["C_AppointmentID"].Value);
            clsBTestAppointments TestApp = clsBTestAppointments.Find(AppID);
            if (TestApp.IsLocked)
                return;

            Frm_SchedulTest schedulTest = new Frm_SchedulTest(LocalApplication,TestApp,User,Convert.ToInt32(TestType));
            schedulTest.DataBack+=FullTableInBack;
            schedulTest.ShowDialog();
        }

        private void TMS_TakeTest_Click(object sender, EventArgs e)
        {
            int AppID = Convert.ToInt32(DGV_AppointmentDetails.SelectedRows[0].Cells["C_AppointmentID"].Value);
            clsBTestAppointments TestApp = clsBTestAppointments.Find(AppID);

            if (TestApp.IsLocked)
            {
                return;
            }
            Frm_TakeTest Test = new Frm_TakeTest(LocalApplication,TestApp, User);
            Test.DataBake += FullTableInBack;
            Test.ShowDialog();
        }


        private void CheckOnTestType()
        {
            switch (TestType)
            {
                case enTestType.Vision:
                    PB_Title.Image=Resources.vision;
                    L_Title.Text="Vision Test";
                    break;
                case enTestType.Writing:
                    PB_Title.Image=Resources.writing;
                    L_Title.Text="Writing Test";
                    break;
                case enTestType.Street:
                    PB_Title.Image=Resources.drive;
                    L_Title.Text="street Test";
                    break;

            }
        }





    }
}
