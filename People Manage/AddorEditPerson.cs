using BusinessLayerDVLD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject
{
    public partial class Frm_AddorEditPerson : Form
    {
        public delegate void Frm_AddorEditPersonDelegate( int PersonID);
        public event Frm_AddorEditPersonDelegate DataBake;
        
        public delegate void NewPeopleTabel(DataTable dt);
        public event NewPeopleTabel DataBakeTable;
        private enum enMode { Add=1,Edit=2};
        private enMode Mode= enMode.Add;
        private int PersonID = 0;
        public Frm_AddorEditPerson()
        {
            InitializeComponent();
            L_Title.Text= "[ Add Person ]";
            L_Title.ForeColor=Color.CornflowerBlue;
            Mode = enMode.Add;
        }
        public Frm_AddorEditPerson(int PersonID,string FirstName,string SecondName,string ThirdName,string LastName,string NationalNo,DateTime DateOfBirth,string Gendor,string Phone,string Email,string Address,int CountryID,string ImagePath)
        {
            InitializeComponent();
            L_Title.Text= "[ Edit Person Info ]";
            L_Title.ForeColor = Color.Green;
            this.PersonID=PersonID;
            L_PersonID.Text="   "+ PersonID.ToString();
            UC_AddEditPerson.LoadData(FirstName, SecondName,ThirdName, LastName, NationalNo,DateOfBirth,Gendor,Phone,Email,Address,CountryID,ImagePath);
            Mode= enMode.Edit;
        }
        private void B_Close_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
        private void Frm_AddorEditPerson_Load(object sender, EventArgs e)
        {

        }
        public bool Save()
        {
            if(Mode== enMode.Add)
            {
                clsBPeople Person= new clsBPeople();
                UC_AddEditPerson.FullPersonInfo(ref Person);
                if(Person.Save())
                {
                    PersonID=Person.ID;
                }
                return PersonID != 0;
            }
            else
            {
                clsBPeople Person=clsBPeople.Find(PersonID);
                UC_AddEditPerson.FullPersonInfo(ref Person);
                return Person.Save();
            }
        }
        public void AddorEditPerson()
        {
            if (UC_AddEditPerson.AreThereNoErrorProviders())
            {
                if (Save())
                {
                    L_PersonID.Text="   " + PersonID.ToString();
                    if (Mode== enMode.Add)
                    {
                        MessageBox.Show("Add Person is Done ...", "Operation success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBake?.Invoke(PersonID);
                        DataBakeTable?.Invoke(clsBPeople.GetAllPeople());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Update Person is Done ...", "Operation success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataBake?.Invoke(PersonID);
                        DataBakeTable?.Invoke(clsBPeople.GetAllPeople());
                        this.Close();
                    }
                    
                }
                else
                {
                    if (Mode== enMode.Add)
                    {
                        MessageBox.Show("Add Person Failed ...", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Update Person Failed ...", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Complete the field collection...", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void B_Save_Click(object sender, EventArgs e)
        {
            AddorEditPerson();
        }

        private void Frm_AddorEditPerson_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.CornflowerBlue);

            pen.Width = 5;
            pen.StartCap=System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap=System.Drawing.Drawing2D.LineCap.Round;
            pen.DashStyle=System.Drawing.Drawing2D.DashStyle.Dash;

            e.Graphics.DrawLine(pen,0, 100, 1500, 100);
        }
    }
}
