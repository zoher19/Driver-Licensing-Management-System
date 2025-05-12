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
    public partial class FindLicenseForRenew : UserControl
    {
        public bool IsDetain;
        public clsBLicenses License;

       
        public FindLicenseForRenew()
        {
            InitializeComponent();
        }

        private void TB_LicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled=true; }
        }

        private void B_Find_Click(object sender, EventArgs e)
        {
            if (TB_LicenseID.Text == string.Empty)
                return;

            int LicenseID = Convert.ToInt32(TB_LicenseID.Text);
            clsBLicenses License = clsBLicenses.Find(LicenseID);

            if (License != null)
            {
                    this.License=License;
                    UC_DriverLicenseInfo.LoadData(License);
                    IsDetain=UC_DriverLicenseInfo.IsDetain;
            }
            else
            {
                MessageBox.Show("This License is not exist ...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindLicenseForRenew_Load(object sender, EventArgs e)
        {

        }
    }
}
