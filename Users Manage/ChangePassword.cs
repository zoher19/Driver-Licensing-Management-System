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
    public partial class Frm_ChangePassword : Form
    {
        private clsBUsers CurrentUser;
        public Frm_ChangePassword(clsBUsers User)
        {
            InitializeComponent();
            this.CurrentUser = User;

            if(CurrentUser != null)
            {
                UC_UserCard.FillCardInfo(User);
            }
            else
            {
                MessageBox.Show("This user is not exist ...","Error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
            TB_CurrentPassword.Focus();
        }


        private void ChangePassword_Load(object sender, EventArgs e)
        {
            EP_Password.SetError(TB_CurrentPassword, "Where is Current Password");
        }

        private void TB_CurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (TB_CurrentPassword.Text == string.Empty)
            {
                EP_Password.SetError(TB_CurrentPassword, "Where is Password ...");
            }
            else if (TB_CurrentPassword.Text != CurrentUser.Password)
            {
                EP_Password.SetError(TB_CurrentPassword, "This password is worng ...");

            }
            
            else
            {
                EP_Password.SetError(TB_CurrentPassword, string.Empty);
            }
        }
        private void TB_NewPassword_TextChanged(object sender, EventArgs e)
        {
            if (TB_NewPassword.Text == string.Empty || TB_NewPassword.Text.Contains(' '))
            {
                EP_Password.SetError(TB_NewPassword, "Where is Password ...");
            }
            else
            {
                EP_Password.SetError(TB_NewPassword, string.Empty);
            }

            if(TB_NewPassword2.Text != TB_NewPassword.Text)
            {
                EP_Password.SetError(TB_NewPassword2, "Please enter a currect password...");
            }
            else
            {
                EP_Password.SetError(TB_NewPassword2, string.Empty);
            }


        }
        private void TB_NewPassword2_TextChanged(object sender, EventArgs e)
        {
            if (TB_NewPassword2.Text == string.Empty || TB_NewPassword2.Text.Contains(' '))
            {
                EP_Password.SetError(TB_NewPassword2, "Where is Password ...");
            }
            else
            {
                EP_Password.SetError(TB_NewPassword2, string.Empty);
                EP_Password.SetError(TB_NewPassword, string.Empty);
            }

            if (TB_NewPassword2.Text != TB_NewPassword.Text)
            {
                EP_Password.SetError(TB_NewPassword2, "Please enter a currect password...");
            }
            else
            {
                EP_Password.SetError(TB_NewPassword2, string.Empty);
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckOnTextBox()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if(EP_Password.GetError(control) != string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void B_ChangePassword_Click(object sender, EventArgs e)
        {
            if(CheckOnTextBox())
            {
               if(MessageBox.Show("Are Sure of change password ??","Confirted Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    this.CurrentUser.Password = TB_NewPassword.Text;

                    if(this.CurrentUser.Save())
                    {
                        MessageBox.Show("Change Password is Done....", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Change Password is Failed.. Try again latter....", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    TB_CurrentPassword.Text=string.Empty;
                    TB_NewPassword.Text=string.Empty;
                    TB_NewPassword2.Text=string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Password in Form currect... ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
