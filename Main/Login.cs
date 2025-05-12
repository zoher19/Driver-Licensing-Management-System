using BusinessLayerDVLD;
using DVLDProject.Properties;
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
    public partial class Login : Form
    {
        private clsBUsers User=new clsBUsers();
        public Login()
        {
            InitializeComponent();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            if (User ==null)
                return;

            if (!User.IsActive)
            {
                MessageBox.Show("This User is not Active ","Not Active",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

            if(!IsThereAnyError())
            {
                Frm_Main main = new Frm_Main(this, User);
                this.Hide();

                main.Show();
            }
            else
            {
                MessageBox.Show("Please enter username and password in form currect.. ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            EP_LoginError.SetError(TB_UserName, "Please enter a username ....");
            EP_LoginError.SetError(TB_Password, "Please enter a password ....");
        }

        private void B_Show_Click(object sender, EventArgs e)
        {
          
            
        }

        private void TB_UserName_TextChanged(object sender, EventArgs e)
        {
            User=clsBUsers.Find(TB_UserName.Text);  

            if (User == null)
            {
                EP_LoginError.SetError(TB_UserName, "This Username is not exist...Try again please..");
            }
            else
            {
                EP_LoginError.SetError(TB_UserName,string.Empty);

                if (TB_Password.Text != User.Password)
                {
                    EP_LoginError.SetError(TB_Password, "This Password is not exist...Try again please..");
                }
                else
                {
                    EP_LoginError.SetError(TB_Password, string.Empty);
                }
            }
        }

        private void TB_Password_TextChanged(object sender, EventArgs e)
        {
            if(User != null)
            {
                if (TB_Password.Text != User.Password)
                    {
                        EP_LoginError.SetError(TB_Password, "This Password is not exist...Try again please..");
                    }
                    else
                    {
                        EP_LoginError.SetError(TB_Password, string.Empty);
            }
            }
            
        }

        private bool IsThereAnyError()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if(EP_LoginError.GetError(control) != string.Empty) 
                    {
                        return true ;   
                    }
                }
            }

            return false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (TB_Password.PasswordChar != '\0')
            {
                TB_Password.PasswordChar='\0';
                pictureBox4.Image=Resources.seen;
            }
            else
            {
                TB_Password.PasswordChar='*';
                
                pictureBox4.Image=Resources.hide__1_;
            }

        }
    }
}
