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
    public partial class Frm_Main : Form
    {
        private Form LoginForm;
        private clsBUsers User;
        public Frm_Main(Form form,clsBUsers User)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoginForm = form;
            this.User = User;
         }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
          
        }
        private void CellPeopleMangementForm()
        {
            Frm_PeopleManagement peopleManagement = new Frm_PeopleManagement(this.User.Username);
            peopleManagement.MdiParent = this;
            peopleManagement.Show();
        }

        private void CellUsersManaegemtForm()
        {
            Frm_UserManagement UserManagement = new Frm_UserManagement();
            UserManagement.MdiParent = this;
            UserManagement.Show();
        }
        private void CellDriversManaegemtForm()
        {
           Frm_Driver Driver=new Frm_Driver();
            Driver.MdiParent = this;
            Driver.Show();
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem T = sender as ToolStripMenuItem;
            string name = T.Text;

            if (T == TMS_People)
            {
                CellPeopleMangementForm();
            }
            else if (T == TMS_Users)
            {
                CellUsersManaegemtForm();
            }

            else if (T ==TMS_Dirvers)
            {
                CellDriversManaegemtForm();
            }
        }
        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void TMS_CurrentInfo_Click(object sender, EventArgs e)
        {
            Frm_UserInfo UserInfo = new Frm_UserInfo(User);
            UserInfo.ShowDialog();
        }
        private void TMS_ChangePassword_Click(object sender, EventArgs e)
        {
            Frm_ChangePassword ChangePassword=new Frm_ChangePassword(User);

            ChangePassword.ShowDialog();
        }
        private void TMS_SignOut_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Hide();
        }

        private void TMS_ManageApplicationTypes_Click(object sender, EventArgs e)
        {
            Frm_ManageApp ManageApp=new Frm_ManageApp();

                ManageApp.ShowDialog();

        }

        private void TMS_ManageTestTypes_Click(object sender, EventArgs e)
        {
            Frm_TestTypesManage TestTypeManage= new Frm_TestTypesManage();

            TestTypeManage.ShowDialog();
        }

        private void TMS_NewDrivingLicense_Click(object sender, EventArgs e)
        {
           
        }

        private void TMS_LocalDrivingLicense_Click(object sender, EventArgs e)
        {
            Frm_AddNewLocalDrivingLicense addNewLocalDrivingLicense = new Frm_AddNewLocalDrivingLicense(User);
            addNewLocalDrivingLicense.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TMS_LocalManage_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingApplicationManage LocalLicense = new FrmLocalDrivingApplicationManage(User);
            LocalLicense.ShowDialog();
        }

        private void TMS_InternalDrivingLicense_Click(object sender, EventArgs e)
        {
            Frm_InternationalLicenseApplication In = new Frm_InternationalLicenseApplication(User);
            In.ShowDialog();
        }

        private void TMS_InternationalLicenseManage_Click(object sender, EventArgs e)
        {
           Frm_InternationalLicenseManage _InternationalLicenseManage=new Frm_InternationalLicenseManage(User);
            _InternationalLicenseManage.ShowDialog();
        }

        private void TMS_RenewDrivingLicense_Click(object sender, EventArgs e)
        {
            Frm_RenewLicense Rens = new Frm_RenewLicense(User,1);
            Rens.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_RenewLicense Rens = new Frm_RenewLicense(User, 2);
            Rens.ShowDialog();
        }

        private void TMS_ReleaseLicense_Click_1(object sender, EventArgs e)
        {
            Frm_DetainorRelaseLicense relaseLicense = new Frm_DetainorRelaseLicense(User, 2);
            relaseLicense.MdiParent=this;
            relaseLicense.Show();
        }

        private void TMS_DetainsLecinses_Click(object sender, EventArgs e)
        {

        }

        private void TMS_ManageDetais_Click(object sender, EventArgs e)
        {
            Frm_DetainManagecs detainManagecs=new Frm_DetainManagecs(User);
            detainManagecs.MdiParent=this;
            detainManagecs.Show();
        }

        private void TMS_DetainLicense_Click(object sender, EventArgs e)
        {
            Frm_DetainorRelaseLicense DetainLicense = new Frm_DetainorRelaseLicense(User, 1);
            
            DetainLicense.MdiParent=this;
            DetainLicense.Show();
        }

        private void TMS_ReleaseLicense2_Click(object sender, EventArgs e)
        {
            Frm_DetainorRelaseLicense relaseLicense = new Frm_DetainorRelaseLicense(User, 2);
            relaseLicense.MdiParent=this;
            relaseLicense.Show();
        }
    }
}
