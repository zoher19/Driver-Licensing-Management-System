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
    public partial class Frm_ManageApp : Form
    {
        private DataTable ApplicationTypes;
        public Frm_ManageApp()
        {
            InitializeComponent();
            ApplicationTypes=clsBApplicationTypes.GetAllApplicationTypes();
            FullDataInDGV();

        }

        private void FullDataAfterUpdate(DataTable NewData)
        {
            this.ApplicationTypes = NewData;
            FullDataInDGV();
        }
        private void FullDataInDGV()
        {
           DGV_ApplicationsType.Rows.Clear();
            if(DGV_ApplicationsType != null )
            {
                foreach (DataRow Application in ApplicationTypes.Rows)
                {
                    DGV_ApplicationsType.Rows.Add(Application["ApplicationTypeID"], Application["ApplicationTypeTitle"], Application["ApplicationFees"]);
                }
            }
            else
            {
                MessageBox.Show("Application Types are not exists ..Please try again letter", "Error Messge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Frm_ManageApp_Load(object sender, EventArgs e)
        {

        }

        private void TMS_UpdateTypes_Click(object sender, EventArgs e)
        {
            int ApplicationID =Convert.ToInt32(DGV_ApplicationsType.SelectedRows[0].Cells["C_ApplicationID"].Value);
            Frm_UpdateApplicationTypes updateApplicationTypes = new Frm_UpdateApplicationTypes(clsBApplicationTypes.Find(ApplicationID));
            updateApplicationTypes.UpdateApplicationTypes+=FullDataAfterUpdate;
            updateApplicationTypes.ShowDialog();    
        }

        private void B_Refresh_Click(object sender, EventArgs e)
        {
            ApplicationTypes=clsBApplicationTypes.GetAllApplicationTypes();
            FullDataInDGV();

        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
