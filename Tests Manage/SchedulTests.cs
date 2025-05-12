using BusinessLayerDVLD;
using DVLDProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDProject
{
    public partial class Frm_SchedulTest : Form
    {
        public delegate void NewTable(DataTable dt);
        public event NewTable DataBack;

        private clsBLocalDrivingLicenseApplications LocalApplication;
        private clsBTestAppointments Appointment;
        private clsBUsers User;
        private enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };
        enTestType TestType= enTestType.VisionTest;

        private enum enMode { AddMode=1,EditMode=2};
        private enMode Mode= enMode.AddMode;
        public Frm_SchedulTest(clsBLocalDrivingLicenseApplications LocalApplication,clsBTestAppointments Appointments,clsBUsers User,int TestT=1)
        {
            InitializeComponent();
            this.LocalApplication=LocalApplication;
            this.User=User;
            this.Appointment=Appointments;
            DTP_Date.Value=Appointments.AppointmentDate;
            TestType=(enTestType)TestT;
            CheckOnTestType();
            FullData();
            Mode=enMode.EditMode;
        }
        public Frm_SchedulTest(clsBLocalDrivingLicenseApplications LocalApplication,clsBUsers User,int TestT=1)
        {
            InitializeComponent();
            this.LocalApplication=LocalApplication;
            this.User=User;
            DTP_Date.MinDate= DateTime.Now;
            TestType=(enTestType)TestT;
            CheckOnTestType();
            FullData();
            Mode=enMode.AddMode;
            
        }

        public void FullData()
        {
            UC_RetakeTest.Enabled=DoesHeHaveAnExam();
            L_AppID.Text="   "+LocalApplication.ID.ToString();
            L_ClassName.Text="   " +clsBLicenseClasses.Find(LocalApplication.LicenseClassID).ClassName;
            L_PasedTests.Text="   "+ HowManySuccessfulTests(LocalApplication.ID)+"/3";
            L_Fees.Text="   " +clsBApplications.Find(LocalApplication.ApplicationID).ToString();
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

                    if(Test != null)
                    if (Test.TestResult && (LocalDrivingLicenseapplicationID == LocalApplicationID))
                    {
                        number++;
                    }

                }
            }
            return number;
        }
        private void Frm_SchedulTest_Load(object sender, EventArgs e)
        {

        }
        private bool DoesHeHaveAnExam()
        {
            DataTable App = clsBTestAppointments.GetAllTestAppointments();
            foreach (DataRow row in App.Rows)
            {
                clsBTestAppointments appointments = clsBTestAppointments.Find(Convert.ToInt32(row["TestAppointmentID"]));
                if (appointments.TestTypeID == Convert.ToInt32(TestType))
                    {
                        clsBTests Test = clsBTests.FindA(appointments.TestAppointmentID);
                        if (Test != null)
                        {
                            if (!Test.TestResult)
                            {
                                return true;
                            }
                        }
                    }
               }
            return false;
        }  
        private void CheckOnTestType()
        {
            switch(TestType)
            {
                case enTestType.VisionTest:
                    PB_PhotoTitle.BackgroundImage=Resources.vision;
                    L_Title.Text="Schedul Vision Test";
                    break;
                case enTestType.WrittenTest:
                    PB_PhotoTitle.BackgroundImage=Resources.writing;
                    L_Title.Text="Schedul Writing Test";
                    break;
                case enTestType.StreetTest:
                    PB_PhotoTitle.BackgroundImage=Resources.drive;
                    L_Title.Text="Schedul street Test";
                    break;

            }
        }

        private void SaveData()
        {
            clsBTestAppointments TestA = new clsBTestAppointments();
            if (Mode ==  enMode.AddMode)
            {
                TakeData(TestA);

            }
            else if(Mode == enMode.EditMode)
            {

                TestA = clsBTestAppointments.Find(this.Appointment.TestAppointmentID);
                if (TestA.IsLocked)
                {
                    MessageBox.Show("This Appointmes is locked you can't edit on it","Message",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                TakeData(TestA);
            }


            if (TestA.Save())
            {
                string AddorEdit = Mode== enMode.AddMode ? "Add" : "Edit";
                MessageBox.Show($"{AddorEdit} Appointment is done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(clsBTestAppointments.GetAllTestAppointments());
                this.Close();
            }
            else
            {
                MessageBox.Show("Add Appointment is Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TakeData(clsBTestAppointments TestA)
        {
            TestA.LocalDrivingLicenseApplicationID = LocalApplication.ID;
            TestA.AppointmentDate= DTP_Date.Value;

            clsBApplications App = clsBApplications.Find(LocalApplication.ApplicationID);
            TestA.PaidFees=App.PaidFees;
            TestA.CreatedByUserID=User.UserID;
            TestA.TestTypeID=Convert.ToInt32(TestType);
            TestA.IsLocked=false;
        }
        
        private void B_Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
