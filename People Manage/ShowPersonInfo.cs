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
    public partial class Frm_PersonDetails : Form
    {
        public Frm_PersonDetails(int PersonID)
        {
            InitializeComponent();
            clsBPeople Person = clsBPeople.Find(PersonID);

            if(Person != null )
            {
                UC_PersonCard.FillCardInfo(Person);
            }
            else
            {
                MessageBox.Show("This is error please try again...","error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Frm_PersonDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
