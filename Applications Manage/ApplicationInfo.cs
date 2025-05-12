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
    public partial class ApplicationInfo : UserControl
    {
        clsBLocalDrivingLicenseApplications LocalApplication;
        clsBApplications application;
        public ApplicationInfo()
        {
            InitializeComponent();
            
        }

        public void LoadData(clsBLocalDrivingLicenseApplications LocalApplication)
        {
            this.LocalApplication = LocalApplication;
            application=clsBApplications.Find(LocalApplication.ApplicationID);
            FullData();
        }
        public void FullData()
        {
            L_AppID.Text="   " + LocalApplication.ID.ToString();
            L_ClassName.Text="   " + clsBLicenseClasses.Find(LocalApplication.LicenseClassID).ClassName;
            L_PasedTests.Text="   " + HowManySuccessfulTests(LocalApplication.ID) + "/3";

            UC_AllicationBasicInfo.LoadDataApp(application);
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
        private void GB_ApplicationBasicInfo_Enter(object sender, EventArgs e)
        {

        }

       

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void UC_AllicationBasicInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
