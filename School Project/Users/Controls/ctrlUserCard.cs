using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class ctrlUserCard : UserControl
    {

        public int? _UserID = null;

        public clsUsers _User;

        public ctrlUserCard()
        {
            InitializeComponent();
        }
        private void ShowPermissionsText()
        {


            List<string> permissions = _User.PermissionsText();

            if(permissions==null||permissions.Count==0)
            {
                lblPermissions.Text = "N/A";

                return;

            }

            lblPermissions.Text=string.Join(",", permissions);  

        }

       private void FillUsersInfo()
        {

              _UserID = _User.UserID.Value;

            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);

       
            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.Username;
            lblIsActive.Text = _User.IsActive ? "Yes" : "No";
            ShowPermissionsText();

        }
        public void LoadUsersInfo(int ?UserID)
        {


            _UserID = UserID;

            if (!_UserID.HasValue)
            {


                MessageBox.Show("No Users With UserID " + _UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                _ResetDefualtValues();

                return;


            }





            _User = clsUsers.FindByUserID(_UserID);


            if(_User==null)
            {

                MessageBox.Show("No Users With UserID " + _User.UserID, "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetDefualtValues();
                return;

            }



            FillUsersInfo();

        }
        public void _ResetDefualtValues()
        {
            _UserID = null;

            //  ctrlPersonCard1.ResetDefualtValues();

            lblUserID.Text = "[???]";
            lblIsActive.Text = "[???]";
            lblUsername.Text = "[???]";

        }
        private void llEditUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

         







        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
