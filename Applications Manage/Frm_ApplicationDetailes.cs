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
    public partial class Frm_ApplicationDetailes : Form
    {
        public Frm_ApplicationDetailes(clsBLocalDrivingLicenseApplications LocalDrivingLicense)
        {
            InitializeComponent();
            UC_ApplicationInfo.LoadData(LocalDrivingLicense);
            
        }

        private void Frm_ApplicationDetailes_Load(object sender, EventArgs e)
        {

        }
    }
}
