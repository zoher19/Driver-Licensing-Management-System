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
    public partial class Frm_InternationalLicenseInfo : Form
    {
        public Frm_InternationalLicenseInfo(clsBInternationalDrivingLicenses IntLicense)
        {
            InitializeComponent();
            UC_IntLicenseCard.LoadData(IntLicense);
        }


        private void Frm_InternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
