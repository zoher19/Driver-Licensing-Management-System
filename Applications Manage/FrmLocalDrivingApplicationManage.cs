using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject
{
    public partial class FrmLocalDrivingApplicationManage : Form
    {
        private DataTable LocalDivingApplications;
        private clsBApplications application;
        private clsBUsers User;
        public FrmLocalDrivingApplicationManage()
        {
            InitializeComponent();
        }
        public FrmLocalDrivingApplicationManage(clsBUsers User)
        {
            InitializeComponent();
            this.User = User;
            this.LocalDivingApplications=clsBLocalDrivingLicenseApplications.GetAllApplications();
            FullDataInDataGridView();
            L_RecordsN.Text=DGV_Applications.Rows.Count.ToString();

                       
        }

        private int HowManySuccessfulTests(int LocalApplicationID)
        {
            int number = 0;
            DataTable TestAppoiments=clsBTestAppointments.GetAllTestAppointments();

            foreach(DataRow row in TestAppoiments.Rows)
            {
                bool IsLoced = Convert.ToBoolean(row["IsLocked"]);
                int LocalDrivingLicenseapplicationID = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);

                if (IsLoced)
                {
                     clsBTests Test = clsBTests.FindA(Convert.ToInt32(row["TestAppointmentID"]));

                        if (Test != null)
                        if (Test.TestResult && (LocalDrivingLicenseapplicationID == LocalApplicationID))
                        {
                            number++;
                        }
                    
                }
            }
            ChangStatus(number);
          
            return number;
        }
        public void FullDataInDataGridView()
        {
           
            DGV_Applications.Rows.Clear();

            foreach(DataRow row in LocalDivingApplications.Rows)
            {     
                int ApplicationID = Convert.ToInt32(row["ApplicationID"]);
                clsBApplications applications = clsBApplications.Find(ApplicationID);
                this.application=applications;

                int PersonID = applications.ApplicantPersonID;
                clsBPeople Person = clsBPeople.Find(PersonID);

                int L_D_LAppID = Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]);
                string DivingLicense = clsBLicenseClasses.Find(Convert.ToInt32(row["LicenseClassID"])).ClassName.ToString();
                string NationalNo = Person.NationalNo;
                string FullName = Person.FirstName + " " +Person.SecondName + " " + Person.ThirdName+" "+ Person.LastName;
                string ApplicationDate=applications.ApplicationDate.ToShortDateString();
                string PassedResult = HowManySuccessfulTests(L_D_LAppID).ToString();
                string Status = _StatusString(applications.ApplicationStatus);

                DGV_Applications.Rows.Add(L_D_LAppID, DivingLicense, NationalNo, FullName, ApplicationDate, PassedResult, Status);

                
            }

          
            
        }

        public void FullDataInDataGridView(DataTable localDrivingLicenseApplications)
        {
            this.LocalDivingApplications=localDrivingLicenseApplications;
            FullDataInDataGridView();
        }
        private string _StatusString(int number)
        {
            switch(number)
            {
                case 1:
                    return "New";
                case 2:
                    return "Completed";
                    case 3:
                    return "Cancelled";
                
            }
            return "cancel";
        }

        private void ChangStatus(int number)
        {
           if(number ==3)
            application.ApplicationStatus=Convert.ToByte(2);

            if (!application.Save())
            {
                MessageBox.Show("Error Message in change status","Message",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        private void B_AddNewLocalApplication_Click(object sender, EventArgs e)
        {
            Frm_AddNewLocalDrivingLicense localDrivingLicense=new Frm_AddNewLocalDrivingLicense(User);
            localDrivingLicense.DataBack+=FullDataInDataGridView;
            localDrivingLicense.ShowDialog();
        }
        private void CB_FillterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_FillterBy.Visible=CB_FillterBy.SelectedItem.ToString()!="None" && (CB_FillterBy.SelectedItem.ToString()!="Status");
            TB_FillterBy.Focus();
            CB_Status.Visible=CB_FillterBy.SelectedItem.ToString()=="Status";
        }
        private void TB_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CB_FillterBy.SelectedItem.ToString()== "L_D_LAppID")
            {
                if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
                { 
                    e.Handled=true;
                }
            }
        }

        private void FrmLocalDrivingApplicationManage_Load(object sender, EventArgs e)
        {
            CB_FillterBy.SelectedItem="None";
            CB_Status.SelectedItem="None";
           
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_FillterBy_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void CMS_ProccessOnLocalDrivingLicense_Opening(object sender, CancelEventArgs e)
        {
            string Status = DGV_Applications.SelectedRows[0].Cells["C_Status"].Value.ToString();
            if(Status == "Completed" || Status == "Cancelled")
            {
                TMS_DeleteApp.Enabled=false;
                TMS_EditAplication.Enabled=false;  
                TMS_CancelApp.Enabled=false;
                TMS_SchdueTests.Enabled=false;
                


            }
            else
            {
                TMS_DeleteApp.Enabled=true;
                TMS_EditAplication.Enabled=true;
                TMS_CancelApp.Enabled=true;
                TMS_SchdueTests.Enabled=true;


            }
           
           
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);

            clsBLicenses License = clsBLicenses.FindA(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID).ApplicationID);
            if(License != null)
            {
                
                TMS_ShowLicense.Enabled=true;
                TMS_IssueDrivingLicenseFT.Enabled=false;
                
            }
            else
            {
                
                TMS_ShowLicense.Enabled=false;
                if(Status == "Completed")
                    TMS_IssueDrivingLicenseFT.Enabled=true;

            }

            TMS_ShowPersonLicenseHistore.Enabled=TMS_ShowLicense.Enabled;
            
        
        }

        private void TMS_DeleteApp_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure of deleted this application","Confirme message",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);
                int ApplciationID = clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID).ApplicationID;


                if (clsBLocalDrivingLicenseApplications.Delete(LocalApplicaionID))
                {
                    if (clsBApplications.Delete(ApplciationID)) 
                    MessageBox.Show($"Delete Local Application with ID = {LocalApplicaionID} is done", "Successully proccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("this Local Application is connect with test or completed ..","Failed Proccess",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.LocalDivingApplications=clsBLocalDrivingLicenseApplications.GetAllApplications();
            FullDataInDataGridView();


        }

        private void TMS_CancelApp_Click(object sender, EventArgs e)
        {
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);

            clsBApplications application = clsBApplications.Find(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID).ApplicationID);
            application.ApplicationStatus=3;
            if (!application.Save())
            {
                MessageBox.Show("Convert status for this application is failed ,try again please","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.LocalDivingApplications=clsBLocalDrivingLicenseApplications.GetAllApplications();
            FullDataInDataGridView();
        }

        private void TMS_ShowApplicationDetails_Click(object sender, EventArgs e)
        {
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);

            Frm_ApplicationDetailes applicationDetailes = new Frm_ApplicationDetailes(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID));
            applicationDetailes.ShowDialog();
        }

        private void TMS_SchdueTests_Click(object sender, EventArgs e)
        {
          DataTable TestAppointments=clsBTestAppointments.GetAllTestAppointments();
          int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);

            foreach (DataRow Appointment in TestAppointments.Rows)
            {
                if (LocalApplicaionID == Convert.ToInt32(Appointment["LocalDrivingLicenseApplicationID"]))
                {
                    int AppointmentID = Convert.ToInt32(Appointment["TestAppointmentID"]);
                    bool IsLocked = Convert.ToBoolean(Appointment["IsLocked"]);
                    if (IsLocked)
                    {
                        clsBTests Test = clsBTests.FindA(AppointmentID);
                        int TestTypeID = Convert.ToInt32(Appointment["TestTypeID"]);
                        if (TestTypeID == 1)
                        {
                            if (Test.TestResult)
                            {
                                TMS_VisionTest.Enabled=false;
                                TMS_WrittenTest.Enabled=true;
                                TMS_StreetTest.Enabled=false;
                            }
                        }
                        else if(TestTypeID == 2)
                        {
                            if (Test.TestResult)
                            {
                                TMS_VisionTest.Enabled=false;
                                TMS_WrittenTest.Enabled=false;
                                TMS_StreetTest.Enabled=true;
                            }
                        }
                        else if(TestTypeID == 3)
                        {
                            if (Test.TestResult)
                            {
                                TMS_VisionTest.Enabled=false;
                                TMS_WrittenTest.Enabled=false;
                                TMS_StreetTest.Enabled=false;
                            }
                        }
                      
                    }
                }
                
            }
        }

        private void TMS_VisionTest_Click(object sender, EventArgs e)
        {
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);
            Frm_VisionTest VisionTest = new Frm_VisionTest(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID),User,1);
            VisionTest.DataBack+=FullDataInDataGridView;
            VisionTest.ShowDialog();
        }

        private void TMS_WrittenTest_Click(object sender, EventArgs e)
        {
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);
            Frm_VisionTest VisionTest = new Frm_VisionTest(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID), User, 2);
            VisionTest.DataBack+=FullDataInDataGridView;
            VisionTest.ShowDialog();
        }

        private void TMS_StreetTest_Click(object sender, EventArgs e)
        {
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);
            Frm_VisionTest VisionTest = new Frm_VisionTest(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID), User, 3);
            VisionTest.DataBack+=FullDataInDataGridView;
            VisionTest.ShowDialog();
        }

        private void TMS_IssueDrivingLicenseFT_Click(object sender, EventArgs e)
        {
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);

            Frm_IssueDriverLicense issueDriverLicense = new Frm_IssueDriverLicense(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID),User);

            issueDriverLicense.ShowDialog();
        }

        private void TMS_ShowLicense_Click(object sender, EventArgs e)
        {
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);
            clsBLicenses license = clsBLicenses.FindA(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID).ApplicationID);
            if(license != null)
            {
                Frm_LicenseDetails licenseDetails = new Frm_LicenseDetails(license);
                licenseDetails.ShowDialog();
            }
        }

        private void TMS_ShowPersonLicenseHistore_Click(object sender, EventArgs e)
        {
            int LocalApplicaionID = Convert.ToInt32(DGV_Applications.SelectedRows[0].Cells["C_AppID"].Value);
            clsBApplications App = clsBApplications.Find(clsBLocalDrivingLicenseApplications.Find(LocalApplicaionID).ApplicationID);

            Frm_ShowLicenseHistorecs LicenseHistore = new Frm_ShowLicenseHistorecs(clsBPeople.Find(App.ApplicantPersonID));
            LicenseHistore.ShowDialog();
        }
    }
}
