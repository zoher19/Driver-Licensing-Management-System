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
    public partial class Frm_UpdateApplicationTypes : Form
    {
        public delegate void UpdateApplicationTypesEventHandler(DataTable dataTable);
        public UpdateApplicationTypesEventHandler UpdateApplicationTypes;

        clsBApplicationTypes Applications;
        public Frm_UpdateApplicationTypes(clsBApplicationTypes application)
        {
            InitializeComponent();
            this.Applications = application;
            if (this.Applications != null )
            {
                TB_Tilte.Text=this.Applications.ApplicationTypeTitle;
                TB_Fees.Text=this.Applications.ApplicationFees.ToString();
            }
        }

        private void Frm_UpdateApplicationTypes_Load(object sender, EventArgs e)
        {

        }

        private void TB_Tilte_TextChanged(object sender, EventArgs e)
        {
            if(TB_Tilte.Text == string.Empty || TB_Tilte.Text.Length < 2)
            {
                errorProvider1.SetError(TB_Tilte, "Please enter a Correct Title");
            }
            else
            {
                errorProvider1.SetError(TB_Tilte, string.Empty);
            }
        }

        private void TB_Fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;
            }
        }

        private void TB_Fees_TextChanged(object sender, EventArgs e)
        {
            if (TB_Fees.Text==string.Empty)
            {
                errorProvider1.SetError(TB_Fees, "Please enter a Correct Fees");
            }
            else
            {
                errorProvider1.SetError(TB_Fees, string.Empty);
            }
        }

        private bool IsThereAnyError()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if(errorProvider1.GetError(control) != string.Empty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            if(!IsThereAnyError())
            {
                if(MessageBox.Show($"Are you sure of update Application Type for this ID = {this.Applications.ApplicationTypeID}","Confirted sure",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Applications.ApplicationTypeTitle=TB_Tilte.Text;
                    Applications.ApplicationFees=Convert.ToDecimal(TB_Fees.Text);
                    if (Applications.Save())
                    {
                        MessageBox.Show("Update is done ..Thank You","Successfully prccess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        UpdateApplicationTypes?.Invoke(clsBApplicationTypes.GetAllApplicationTypes());
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
                MessageBox.Show("Please enter all failed in correct form", "Failed prccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
