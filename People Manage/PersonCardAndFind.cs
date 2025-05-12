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
    public partial class PersonCardAndFind : UserControl
    {
        public clsBPeople Person { get; set; }
        public PersonCardAndFind()
        {
            InitializeComponent();
        }

        public void Full(int PersonID)
        {
            Person=clsBPeople.Find(PersonID);
            if (Person != null)
            {
                CB_FindBy.SelectedItem="PersonID";
                TB_FindBy.Text=Person.ID.ToString();
                UC_PersonCard.FillCardInfo(Person);
            }
        }

        public void Full(clsBPeople Person,bool VisiableFindBy=true)
        {
            this.Person=Person;
            if (this.Person != null)
            {
                CB_FindBy.SelectedItem="PersonID";
                TB_FindBy.Text=Person.ID.ToString();
                UC_PersonCard.FillCardInfo(Person);
                GB_Search.Enabled=VisiableFindBy;
            }
        }
        private void TB_FindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB_FindBy.SelectedItem == "PersonID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void CB_FindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_FindBy.Text=string.Empty;
            TB_FindBy.Visible =CB_FindBy.SelectedItem != "None";
        }
        private void B_Find_Click(object sender, EventArgs e)
        {
            if (TB_FindBy.Text==string.Empty)
                return;

           Person=clsBPeople.Find(TB_FindBy.Text);
            if(CB_FindBy.SelectedItem=="PersonID")
            {
                Person=clsBPeople.Find(Convert.ToInt32(TB_FindBy.Text));
            }
            else if (CB_FindBy.SelectedItem=="NationalNo")
            {
                Person=clsBPeople.Find(TB_FindBy.Text);
            }

            if(Person != null)
            {
                UC_PersonCard.FillCardInfo(Person);

            }
            else
            {
                MessageBox.Show("This Person is not exist ...", "ErrorMessage",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            Frm_AddorEditPerson AddPerson=new Frm_AddorEditPerson();

            AddPerson.DataBake+=Full;

            AddPerson.ShowDialog(); 
        }

        private void PersonCardAndFind_Load(object sender, EventArgs e)
        {

        }
    }
}
