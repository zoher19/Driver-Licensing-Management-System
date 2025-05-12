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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void TMS_Application_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application will be here soon...", "Under Mantenance", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void TMS_People_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "People will be here soon...", "Under Mantenance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void TMS_Drivers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drivers will be here soon...", "Under Mantenance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void TMS_Users_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Driver will be here soon...", "Under Mantenance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void TMS_AccountSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accountsetting will be here soon...", "Under Mantenance", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }











    }
}
