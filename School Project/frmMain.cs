using School_Project.Classes;
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
    public partial class frmMain : Form
    {
        frmLogin frmLogin;

        public frmMain(frmLogin frm1)
        {
            InitializeComponent();
            frmLogin = frm1;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard frm1 = new frmDashboard();
            frm1.ShowDialog();




        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmListStudents frm1=new frmListStudents();
            frm1.ShowDialog();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {

frmListTeachers frm1=new frmListTeachers();
            frm1.ShowDialog();


        }

        private void btnClasses_Click(object sender, EventArgs e)
        {


            frmListClass frm1=new frmListClass();   
            frm1.ShowDialog();
        }

        private void btnSubjectGrades_Click(object sender, EventArgs e)
        {
            frmListSubjectGradeLevel frm1=new frmListSubjectGradeLevel();
            frm1.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmListPayments frm1=new frmListPayments();   
            frm1.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmListUsers frm1 = new frmListUsers();
            frm1.ShowDialog();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm1=new frmSettings(); 
            frm1.ShowDialog();
        }
    }
}
