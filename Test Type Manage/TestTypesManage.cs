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
    public partial class Frm_TestTypesManage : Form
    {
        private DataTable TestTypes;
        public Frm_TestTypesManage()
        {
            InitializeComponent();
            TestTypes=clsBTestTypes.GetAllTestTypes();
            if (TestTypes!=null)
            {
                FullTable();
            }
        }

        public void FullTableAterUpdate(DataTable NewData)
        {
            this.TestTypes=NewData;
            FullTable();
        }
        private void FullTable()
        {
           DGV_TestTypes.Rows.Clear();
            foreach(DataRow Test in TestTypes.Rows)
            {
                DGV_TestTypes.Rows.Add(Test["TestTypeID"], Test["TestTypeTitle"], Test["TestTypeDescription"], Test["TestTypeFees"]);
            }
        }
        private void TMS_UpdateTypes_Click(object sender, EventArgs e)
        {
            int TestID = Convert.ToInt32(DGV_TestTypes.SelectedRows[0].Cells["C_TestID"].Value);
            Frm_UpdateTestsTypes UpdateTestTypes = new Frm_UpdateTestsTypes(clsBTestTypes.Find(TestID));
            UpdateTestTypes.DataBake+=FullTableAterUpdate;
            UpdateTestTypes.Show();
        }
        private void B_Refresh_Click(object sender, EventArgs e)
        {
            TestTypes=clsBTestTypes.GetAllTestTypes();
            if (TestTypes!=null)
            {
                FullTable();
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_TestTypesManage_Load(object sender, EventArgs e)
        {

        }
    }
}
