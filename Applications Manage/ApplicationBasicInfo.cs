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
using static System.Net.Mime.MediaTypeNames;

namespace DVLDProject
{
    public partial class ApplicationBasicInfo : UserControl
    {
        private clsBApplications application;
        public ApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void LoadDataApp(clsBApplications application)
        {
            this.application = application;
            FullDataApp();
        }
        public void FullDataApp()
        {
            L_ID.Text="   "+application.ApplicationID.ToString();
            L_Status.Text="   "+ConvertStatusToString(application.ApplicationStatus);
            L_Fees.Text="   "+application.PaidFees.ToString();
            L_CreatedByUser.Text="   " + clsBUsers.Find(application.CreatedByUserID).Username;
            L_Date.Text="   "+application.ApplicationDate.ToShortDateString();
            L_StatusDate.Text="   " + application.LastStatusDate.ToShortDateString();
            clsBPeople Person = clsBPeople.Find(application.ApplicantPersonID);
            L_Applicant.Text="   "+Person.FirstName + " "+Person.SecondName +  " "+Person.ThirdName + " "+Person.LastName;
            L_Type.Text="   "+clsBApplicationTypes.Find(application.ApplicationTypeID).ApplicationTypeTitle;
        }
        private void ApplicationBasicInfo_Load(object sender, EventArgs e)
        {

        }

        private string ConvertStatusToString(int numberStatus)
        {
            switch (numberStatus)
            {
                case 1:
                    return "New";
                case 2:
                    return "Completed";

                case 3:
                    return "Cancel";
            }
            return "Cansel";
        }

        private void LL_PersonINfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_PersonDetails Person = new Frm_PersonDetails(application.ApplicantPersonID);

            Person.ShowDialog();
        }

        private void GB_ApplicationBasicInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
