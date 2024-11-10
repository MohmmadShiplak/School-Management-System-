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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

           string HashedPassword = clsGlobal.ComputeHash(txtPassword.Text.Trim());

            clsUsers User = clsUsers.Find(txtUserName.Text.Trim(), HashedPassword);




            if (User != null)
            {


                if (chkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(),clsGlobal.Encrypt( txtPassword.Text.Trim()));
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!User.IsActive)
                {

                    txtUserName.Focus();
                    MessageBox.Show("Your Account is not active , Contact Admin ", "in Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                clsGlobal.CurrentUser = User;
                this.Hide();
                frmMain frm1 = new frmMain(this);
                frm1.ShowDialog();



            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid UserName/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }














        }
    }
}
