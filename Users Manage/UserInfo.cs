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
    public partial class Frm_UserInfo : Form
    {
        private clsBUsers User;
        public Frm_UserInfo(clsBUsers User)
        {
            InitializeComponent();
            this.User = User;

            UC_UserCard.FillCardInfo(User);
        }
        

        private void Frm_UserInfo_Load(object sender, EventArgs e)
        {

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
