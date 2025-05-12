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
    public partial class UserCard : UserControl
    {
        private clsBUsers CurrentUser;
        public UserCard()
        {
            InitializeComponent();
        }
        public void FillCardInfo(clsBUsers User,bool IsAllowedEditPerson=false)
        {
            this.CurrentUser = User;
            clsBPeople Person = clsBPeople.Find(User.PersonID);

            if (Person != null)
            {
                UC_PersonCard.FillCardInfo(Person,IsAllowedEditPerson);
                L_UserName.Text=this.CurrentUser.Username;
                L_UserID.Text=this.CurrentUser.UserID.ToString();
                L_IsActive.Text=this.CurrentUser.IsActive ? "Yes" : "No";
            }
           
        }

        private void UserCard_Load(object sender, EventArgs e)
        {

        }
    
    
    
    
    
    
    }
}
