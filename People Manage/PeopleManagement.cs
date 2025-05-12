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
    public partial class Frm_PeopleManagement : Form
    {
        private DataTable dt_People;
        private string UserName;
        public Frm_PeopleManagement(string UserName)
        {
            InitializeComponent();
            dt_People=clsBPeople.GetAllPeople();
            Full();
            this.UserName=UserName;
            L_UserName.Text=UserName;
        }

        private void FullDataAfterUpdateorAdd(DataTable dt)
        {
            this.dt_People=dt;
            Full();
        }
        private  void Full()
        {
            DGV_PeopleInfo.Rows.Clear();
            foreach (DataRow Person in dt_People.Rows)
            {
                int ID = Convert.ToInt32(Person["PersonID"]);
                string NationalNo = Person["NationalNo"].ToString();
                string FirstName = Person["FirstName"].ToString();
                string SecondName = Person["SecondName"].ToString();
                string ThirdName = Person["ThirdName"].ToString()==string.Empty ? "" : Person["ThirdName"].ToString() ;
                string LastName = Person["LastName"].ToString();
                string Gender = Convert.ToSByte(Person["Gendor"]) == 1 ? "Female" : "Male";
                string DateOfBirth = Person["DateOfBirth"].ToString();
                string Nationality = clsConvertsData.ConvertFromCountryIDToCountryName(Convert.ToInt32(Person["NationalityCountryID"]));
                string Phone = Person["Phone"].ToString();
                string Email = Person["Email"].ToString() == string.Empty ? "" : Person["Email"].ToString();

                DGV_PeopleInfo.Rows.Add(ID,NationalNo, FirstName, SecondName, ThirdName, LastName, Gender,DateOfBirth,Nationality, Phone, Email);

            }
        }
        private void Frm_PeopleManagement_Load(object sender, EventArgs e)
        {
            L_RecordNumbers.Text=" #" + DGV_PeopleInfo.Rows.Count.ToString();
            CB_FillterBy.SelectedIndex=0;
        }
        private void B_AddPerson_Click(object sender, EventArgs e)
        {
            Frm_AddorEditPerson Addperson = new Frm_AddorEditPerson();
            Addperson.DataBakeTable+=FullDataAfterUpdateorAdd;
            Addperson.ShowDialog();
        }
        private void TMS_AddNewPerson_Click(object sender, EventArgs e)
        {
            Frm_AddorEditPerson Addperson = new Frm_AddorEditPerson();
            Addperson.DataBakeTable+=FullDataAfterUpdateorAdd;
            Addperson.ShowDialog();
        }
        private void TMS_Edit_Click(object sender, EventArgs e)
        {
             int PersonID = Convert.ToInt32(DGV_PeopleInfo.SelectedRows[0].Cells["C_PersonID"].Value);
            clsBPeople Person = clsBPeople.Find(PersonID);

            if (Person != null)
            {
                Frm_AddorEditPerson editPerson = new Frm_AddorEditPerson(PersonID, Person.FirstName, Person.SecondName, Person.ThirdName, Person.LastName, Person.NationalNo, Person.DateOfBirth,
                    Person.Gendor, Person.Phone, Person.Email, Person.Address, Person.NationalityCountryID, Person.ImagePath);
                editPerson.DataBakeTable+=FullDataAfterUpdateorAdd;
                editPerson.ShowDialog();
            }
            else
            {
                MessageBox.Show("This name does not exist ...Please try again","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);  
            }
                
        }

        private void B_UpdatePeopleTable_Click(object sender, EventArgs e)
        {
            dt_People=clsBPeople.GetAllPeople();
            Full();
            L_RecordNumbers.Text=" #" + DGV_PeopleInfo.Rows.Count.ToString();
        }

        private void TMS_Delete_Click(object sender, EventArgs e)
        {
            int PersonID =Convert.ToInt32(DGV_PeopleInfo.SelectedRows[0].Cells["C_PersonID"].Value);

            if (MessageBox.Show($"Are you sure of delete Person with ID = {PersonID}", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
            {
                if (clsBPeople.DeletePerson(PersonID))
                {
                    MessageBox.Show($"Person with ID = {PersonID} deleted", "Deleted Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Deleted person with ID = {PersonID} is failed", "Deleted Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dt_People=clsBPeople.GetAllPeople();
            Full();
        }

        private void TMS_SendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be here soon.....","Coming soon",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void TMS_Pnone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will be here soon.....", "Coming soon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void TMS_ShowDetails_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(DGV_PeopleInfo.SelectedRows[0].Cells["C_PersonID"].Value);

            Frm_PersonDetails personDetails = new Frm_PersonDetails(PersonID);
            personDetails.ShowDialog();
        }

        //Fillter on datagridview
        private void CB_FillterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_FillterBy.Visible=!(CB_FillterBy.SelectedIndex == 0 || CB_FillterBy.SelectedIndex==-1);
            TB_FillterBy.Focus();
        }
        private void TB_FillterBy_TextChanged(object sender, EventArgs e)
        {
            string FillterBy=CB_FillterBy.SelectedItem.ToString();
            string Value = TB_FillterBy.Text;

            if (FillterBy == "Nationality")
            {
                Value = clsConvertsData.ConvertFromCountryNameToCountryID(TB_FillterBy.Text).ToString();
                FillterBy="NationalityCountryID";
            }

            if(FillterBy == "Gendor")
            {
                Value = (TB_FillterBy.Text=="Male") ? "0" : "1";
            }

            if (TB_FillterBy.Text != string.Empty)
            {
                DataTable dt = clsConvertsData.FilterBy(clsBPeople.GetAllPeople(), FillterBy, Value);

                if(dt != null)
                {
                    dt_People=dt;
                }
                else
                {
                    MessageBox.Show("Please try again ......this is error", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dt_People=clsBPeople.GetAllPeople();
                Full();
            }

                if (dt_People.Rows.Count > 0)
                {
                    Full();
                }
                else
                {
                    dt_People=clsBPeople.GetAllPeople();
                    Full();
                }

            L_RecordNumbers.Text=" #" + DGV_PeopleInfo.Rows.Count.ToString();

        }
        private void TB_FillterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(CB_FillterBy.SelectedItem.ToString() == "PersonID" || CB_FillterBy.SelectedItem.ToString() == "Phone")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
           
        }

        private void Frm_PeopleManagement_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }

}
