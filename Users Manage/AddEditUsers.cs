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
    public partial class Frm_AddEditUsers : Form
    {
        public delegate void AddEditUsers(DataTable dt);
        public event AddEditUsers DataBack;

        private int PersonID = 0;
        private clsBUsers User;
        private enum enMode { AddMode=1, UpdateMode=2};

        private enMode Mode = enMode.AddMode;
        public Frm_AddEditUsers()
        {
            InitializeComponent();
            L_Title.Text="Add User";
            User = new clsBUsers();
            Mode=enMode.AddMode;
        }

        private void FullInformaion(clsBUsers User)
        {
            L_UserID.Text=User.UserID.ToString();
            TB_UserName.Text=User.Username;
            TB_Password.Text=User.Password;
            TB_ConfirmPassword.Text=User.Password;
            CB_IsActive.Checked=User.IsActive;
            UC_PersonCard.Full(clsBPeople.Find(User.PersonID), false);
            Mode =enMode.UpdateMode;
        }
        public Frm_AddEditUsers(clsBUsers User)
        {
            InitializeComponent();
            L_Title.Text="Update User";

            this.User = User;
            FullInformaion(User);
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            if(UC_PersonCard.Person != null)
            {
                PersonID=UC_PersonCard.Person.ID;

               
                if (!clsBUsers.IsUser(PersonID) || Mode==enMode.UpdateMode)
                {
                    TC_AddEditUsers.TabPages[1].Enabled = true;
                    TC_AddEditUsers.SelectedIndex = 1;

                }
                else
                {
                    MessageBox.Show("This Person is User","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    TC_AddEditUsers.TabPages[1].Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Where is person", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TC_AddEditUsers.TabPages[1].Enabled = false;
            }

        }

        private void Frm_AddEditUsers_Load(object sender, EventArgs e)
        {
            TC_AddEditUsers.TabPages[1].Enabled = false;
        }

        private void TB_UserName_TextChanged(object sender, EventArgs e)
        {
            if(TB_UserName.Text==string.Empty)
            {
                EP1.SetError(TB_UserName, "Please enter Username in correct form ....");
            }
            else
            {
                EP1.SetError(TB_UserName, string.Empty);
            }
        }

        private void TB_Password_TextChanged(object sender, EventArgs e)
        {
            if(TB_Password.Text==string.Empty)
            {
                EP1.SetError(TB_Password, "Pleas enter a password in form correct ...");
            }
            else
            {
                EP1.SetError(TB_Password, string.Empty);
            }

            if(TB_Password.Text != TB_ConfirmPassword.Text)
            {
                EP1.SetError(TB_ConfirmPassword, "Password is not equals Confirm Password");
            }
            else
            {
                EP1.SetError(TB_ConfirmPassword, string.Empty);
            }
        }

        private void TB_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (TB_ConfirmPassword.Text==string.Empty)
            {
                EP1.SetError(TB_ConfirmPassword, "Pleas enter a password in form correct ...");
            }
            else
            {
                EP1.SetError(TB_ConfirmPassword, string.Empty);
            }

            if (TB_Password.Text != TB_ConfirmPassword.Text)
            {
                EP1.SetError(TB_ConfirmPassword, "Password is not equals Confirm Password");
            }
            else
            {
                EP1.SetError(TB_ConfirmPassword, string.Empty);
            }
        }

        private bool IsThereAnyError()
        {
            foreach(Control c in this.TC_AddEditUsers.TabPages[1].Controls)
            {
                if(c is TextBox)
                {
                    if(EP1.GetError(c) != string.Empty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void AddUser()
        {
            User.PersonID=UC_PersonCard.Person.ID;
            User.Username=TB_UserName.Text;
            User.Password=TB_Password.Text;
            User.IsActive=CB_IsActive.Checked;
        }

        private void UpdateUser()
        {
            User.Username = TB_UserName.Text;
            User.Password = TB_Password.Text;
            User.IsActive=CB_IsActive.Checked;
        }
        private void B_Save_Click(object sender, EventArgs e)
        {
           if(!IsThereAnyError())
            {
                if (Mode==enMode.AddMode)
                {
                  AddUser();
                }
                else
                {
                    UpdateUser();
                }

                if (User.Save())
                {
                    MessageBox.Show("Save User is done ...", "Success Proccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBack?.Invoke(clsBUsers.GetAllUsers());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Save User is Failed try again letter...", "Failed Proccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter username or password in form correct ...", "Error Proccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RestartSereen()
        {
            TB_UserName.Text=string.Empty;
            TB_Password.Text=string.Empty;
            TB_ConfirmPassword.Text=string.Empty;
            CB_IsActive.Checked=false;
        }
      
        private void UC_PersonCard_Load(object sender, EventArgs e)
        {

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
