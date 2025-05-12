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
    public partial class Frm_Driver : Form
    {
        private DataTable DT_Driver;
        public Frm_Driver()
        {
            InitializeComponent();
            CB_FiltterBy.Text="None";
            DT_Driver=clsBDrivers.GetAllDrivers();
            FullDataInTable();
        }

        private void FullDataInTable()
        {
            DGV_Drivers.Rows.Clear();

            foreach (DataRow dr in DT_Driver.Rows)
            {
                int DriverID = Convert.ToInt32(dr["DriverID"]);
                int PersonID = Convert.ToInt32(dr["PersonID"]);
                clsBPeople Person = clsBPeople.Find(PersonID);

                string NationalNo = Person.NationalNo;
                string FullName = Person.FirstName + " "+ Person.SecondName + " " + Person.ThirdName + " "+ Person.LastName;
                string Date = Convert.ToDateTime(dr["CreatedDate"]).ToShortDateString();

                DGV_Drivers.Rows.Add(DriverID, PersonID, NationalNo, FullName, Date);

            }
            L_Recourd.Text=DGV_Drivers.Rows.Count.ToString();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Driver_Load(object sender, EventArgs e)
        {

        }

        private void CB_FiltterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_FiltterBy.Visible=CB_FiltterBy.SelectedItem != "None";
        }

        private void TB_FiltterBy_TextChanged(object sender, EventArgs e)
        {
            string FiltterBy = CB_FiltterBy.Text;
            string value = TB_FiltterBy.Text;

            DataView dv = DT_Driver.DefaultView;
            if (value != string.Empty && FiltterBy != string.Empty)
            {



                dv.RowFilter=$"{FiltterBy} = {value}";
                DT_Driver=dv.ToTable();
                if (DT_Driver.Rows.Count > 0)
                {
                    FullDataInTable();

                }
                else
                {

                    DT_Driver=clsBDrivers.GetAllDrivers();
                    FullDataInTable();
                }
            }

            else
            {
                DT_Driver=clsBDrivers.GetAllDrivers();
                FullDataInTable();
            }


          

        }

        private void TB_FiltterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Selected = CB_FiltterBy.SelectedItem.ToString();

            if (Selected == "DriverID" || Selected == "PersonID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }
        }
   
    
    
    
    
    
    
    
    
    }

}
