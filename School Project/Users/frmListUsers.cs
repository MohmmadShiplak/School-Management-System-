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
    public partial class frmListUsers : Form
    {

        public static  DataTable _dtUsers;

        public frmListUsers()
        {
            InitializeComponent();
        }
    

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtUsers = clsUsers.GetAllUsers();
            dgvGetAllUsers.DataSource = _dtUsers;




            dgvGetAllUsers.Columns[1].HeaderText = "Full Name";
            
            dgvGetAllUsers.Columns[1].Width = 120;

        }


        private void updateUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID = (int)dgvGetAllUsers.CurrentRow.Cells[0].Value;




            frmAddUpdateUser  frm1 = new frmAddUpdateUser(UserID);
            frm1.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void deleteUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserID=(int)dgvGetAllUsers.CurrentRow.Cells[0].Value;


            if (clsUsers.DeleteUser(UserID))
            {

                MessageBox.Show("User Deleted Successfully -:)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListUsers_Load(null, null);
            }
            else
            {
                MessageBox.Show("Failed to Delete the Users ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

 
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int UserID = (int)dgvGetAllUsers.CurrentRow.Cells[0].Value;


            frmChangePassword frm1 = new frmChangePassword(UserID);
            frm1.ShowDialog();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddUpdateUser frm1 = new frmAddUpdateUser();
           frm1.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int UserID = (int)dgvGetAllUsers.CurrentRow.Cells[0].Value;


            frmShowUsersInfo frm1 = new frmShowUsersInfo(UserID);
            frm1.ShowDialog();


        }
    }
}
