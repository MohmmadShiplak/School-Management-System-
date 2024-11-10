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
    public partial class frmChangePassword : Form
    {




        public int? _UserID = null;

        public clsUsers _User;

        private enum enMode { AddNew = 0, UpdateNew = 1 };
        private enMode _Mode = enMode.AddNew;


        public frmChangePassword(int ?UserID)
        {
            InitializeComponent();
            _UserID = UserID;

            _Mode = enMode.UpdateNew;

         
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

            _User = clsUsers.FindByUserID(_UserID);

            if(_User==null)
            {

                MessageBox.Show("there is no Users with UserID " + _UserID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ctrlUserCard1.LoadUsersInfo(_UserID);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {






            _User.Password = txtNewPassword.Text;   


           if(_User.Save())
            {

                MessageBox.Show("Data Saved Sucessfully :-)", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           else
            {
                MessageBox.Show("An Error Ocurred , Password did not Change ","Error"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }









        }
    }
}
