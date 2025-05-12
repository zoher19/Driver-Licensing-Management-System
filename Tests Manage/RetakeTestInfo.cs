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
    public partial class RetakeTestInfo : UserControl
    {
        private clsBApplications Applications;
        public RetakeTestInfo()
        {
            InitializeComponent();
        }

        private void FullData(clsBApplications applications,decimal Fees=0)
        {
            this.Applications = applications;
            L_ID.Text=this.Applications.ApplicationID.ToString();
            L_Fees.Text=this.Applications.PaidFees.ToString();
            L_TotalFees.Text=(this.Applications.PaidFees+Fees).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RetakeTestInfo_Load(object sender, EventArgs e)
        {

        }


    }
}
