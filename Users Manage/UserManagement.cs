using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject
{
    public partial class Frm_UserManagement : Form
    {
        private DataTable dt_Users;
        public Frm_UserManagement()
        {
            InitializeComponent();
            dt_Users=clsBUsers.GetAllUsers();
            FullData();
        }

        private void FullDataAfterAddUpdate(DataTable dt)
        {
            this.dt_Users=dt;
            FullData();
        }
        private void FullData()
        {
           
            DGV_Users.Rows.Clear();
            if (dt_Users!=null)
            {
               
                foreach (DataRow User in dt_Users.Rows)
                {
                   int UserID = Convert.ToInt32(User["UserID"]);
                   int PersonID = Convert.ToInt32(User["PersonID"]);
                   clsBPeople Person = clsBPeople.Find(PersonID);
                   string FullName = Person.FirstName + " " + Person.SecondName + " " +Person.ThirdName + " " + Person.LastName;
                   string Username = User["UserName"].ToString();
                   bool IsActive = Convert.ToBoolean(User["IsActive"]);

                    DGV_Users.Rows.Add(UserID,PersonID,FullName,Username,IsActive);

                }
            }

           L_Records.Text=DGV_Users.Rows.Count.ToString();
        }
        private void CB_FillterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_FillterBy.Visible=(CB_FillterBy.SelectedItem != "None" && CB_FillterBy.SelectedItem != "IsActive");
            CB_IssActive.Visible=(CB_FillterBy.SelectedItem == "IsActive");
        }
        private void Frm_UserManagement_Load(object sender, EventArgs e)
        {
            CB_FillterBy.SelectedItem="None";
            CB_IssActive.SelectedItem="None";
        } 
        private void TB_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB_FillterBy.SelectedItem == "UserID" || CB_FillterBy.SelectedItem == "PersonID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void TB_FillterBy_TextChanged(object sender, EventArgs e)
        {
            string FillterBy = CB_FillterBy.SelectedItem.ToString();
            string Value = TB_FillterBy.Text;

            if (Value != string.Empty)
            {
                DataTable dt = clsConvertsData.FilterBy(clsBUsers.GetAllUsers(), FillterBy, Value);

                if (dt != null)
                {
                    dt_Users=dt;
                }
                else
                {
                    MessageBox.Show("Please try again ......this is error", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dt_Users=clsBUsers.GetAllUsers();
                FullData();
            }

            if (dt_Users.Rows.Count > 0)
            {
                FullData();
            }
            else
            {
                dt_Users=clsBUsers.GetAllUsers();
                FullData();
            }

            //L_RecordNumbers.Text=" #" + DGV_PeopleInfo.Rows.Count.ToString();
        }

        private void CB_IISActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable IsActiveUsers=new DataTable();

            if(CB_IssActive.SelectedIndex ==1) 
            {
                IsActiveUsers = clsConvertsData.FilterBy(clsBUsers.GetAllUsers(), "IsActive","true");
            }
            else if(CB_IssActive.SelectedIndex ==2)
            {
                IsActiveUsers = clsConvertsData.FilterBy(clsBUsers.GetAllUsers(), "IsActive", "False");

            }
            
            if (IsActiveUsers != null)
            {
                
                    if (CB_IssActive.SelectedIndex!=0)
                    {
                        dt_Users=IsActiveUsers;
                       
                    }
                    else
                    {
                        dt_Users=clsBUsers.GetAllUsers() ;
                       
                    }
                
                
            }
            else
            {
                MessageBox.Show("Please try again ......this is error", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
            }


            FullData();
        }

        private void TMS_ShowDetails_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(DGV_Users.SelectedRows[0].Cells["C_UserID"].Value);
            clsBUsers User = clsBUsers.Find(UserID);
            Frm_UserInfo UserInfo=new Frm_UserInfo(User);

            UserInfo.ShowDialog();
        }

        private void TMS_Delete_Click(object sender, EventArgs e)
        {
            int UserID= Convert.ToInt32(DGV_Users.SelectedRows[0].Cells["C_UserID"].Value);

            if (MessageBox.Show($"Are you sure of delete user with ID = {UserID}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsBUsers.Delete(UserID))
                {
                    MessageBox.Show($"User with ID ={UserID} is Deleted", "success proccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FullDataAfterAddUpdate(clsBUsers.GetAllUsers());
                }
               else
                {
                    MessageBox.Show($"User with ID ={UserID} Cannot be deleted", "Failed proccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void B_UpdatePeopleTable_Click(object sender, EventArgs e)
        {
            dt_Users=clsBUsers.GetAllUsers();
            FullData();
        }

        private void AddUserClick()
        {
            Frm_AddEditUsers AddUsers = new Frm_AddEditUsers();
            AddUsers.DataBack+=FullDataAfterAddUpdate;
             AddUsers.ShowDialog();
        }

        private void B_AddUsers_Click(object sender, EventArgs e)
        {
            AddUserClick();
        }

        private void TMS_Edit_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(DGV_Users.SelectedRows[0].Cells["C_UserID"].Value);

            Frm_AddEditUsers editUsers = new Frm_AddEditUsers(clsBUsers.Find(UserID));
            editUsers.DataBack+=FullDataAfterAddUpdate;
            editUsers.ShowDialog();
        }

        private void TMS_AddNewPerson_Click(object sender, EventArgs e)
        {
            AddUserClick();
        }

        private void TMS_ChangePassword_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(DGV_Users.SelectedRows[0].Cells["C_UserID"].Value);

            Frm_ChangePassword changePassword = new Frm_ChangePassword(clsBUsers.Find(UserID));
            changePassword.ShowDialog();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
