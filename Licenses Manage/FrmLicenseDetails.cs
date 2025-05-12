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
    public partial class Frm_LicenseDetails : Form
    {
        public Frm_LicenseDetails(clsBLicenses licenses)
        {
            InitializeComponent();
            UC_DriverLicenseInfo.LoadData(licenses);
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
