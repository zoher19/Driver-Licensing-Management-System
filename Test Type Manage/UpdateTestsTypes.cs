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
    public partial class Frm_UpdateTestsTypes : Form
    {
        public delegate void Frm_UpdateTestsTypesEventHandler(DataTable dataTable);
        public event Frm_UpdateTestsTypesEventHandler DataBake;

        private clsBTestTypes Test;
        public Frm_UpdateTestsTypes(clsBTestTypes Test)
        {
            InitializeComponent();
            this.Test = Test;
            FullInfo();
            
        }
        private void FullInfo()
        {
            TB_Title.Text=this.Test.TestTypeTitle;
            TB_Description.Text=this.Test.TestTypeDescription;
            TB_Fees.Text=(this.Test.TestTypeFees).ToString();
        }

        private void TB_Fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_Title_TextChanged(object sender, EventArgs e)
        {
            if (TB_Title.Text == string.Empty || TB_Title.Text.Length<2)
            {
                errorProvider1.SetError(TB_Title, "Please enter  a Title in correct form....");
            }
            else
            {
                errorProvider1.SetError(TB_Title,string.Empty);

            }
        }

        private void TB_Description_TextChanged(object sender, EventArgs e)
        {
            if (TB_Description.Text == string.Empty || TB_Description.Text.Length<2)
            {
                errorProvider1.SetError(TB_Description, "Please enter a Description in correct form....");
            }
            else
            {
                errorProvider1.SetError(TB_Description, string.Empty);

            }
        }

        private void TB_Fees_TextChanged(object sender, EventArgs e)
        {
            if (TB_Fees.Text == string.Empty || TB_Fees.Text.Length<2)
            {
                errorProvider1.SetError(TB_Fees, "Please enter a Description in correct form....");
            }
            else
            {
                errorProvider1.SetError(TB_Fees, string.Empty);

            }
        }

        private void Frm_UpdateTestsTypes_Load(object sender, EventArgs e)
        {

        }

        private bool IsThereAnyError()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (errorProvider1.GetError(control) != string.Empty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            if (!IsThereAnyError())
            {
                if (MessageBox.Show($"Are you sure of update Application Type for this ID = {this.Test.TestTypeID}", "Confirted sure", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Test.TestTypeTitle=TB_Title.Text;
                    Test.TestTypeDescription=TB_Description.Text;
                    Test.TestTypeFees=Convert.ToDecimal(TB_Fees.Text);
                    if (Test.Save())
                    {
                        MessageBox.Show("Update is done ..Thank You", "Successfully prccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBake?.Invoke(clsBTestTypes.GetAllTestTypes());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update is Failed ..Thank You", "Failed prccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter all failed in correct form .....", "Failed prccess", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
