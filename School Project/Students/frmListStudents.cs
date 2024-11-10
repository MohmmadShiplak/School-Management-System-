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
    public partial class frmListStudents : Form
    {


        public DataTable _dtAllStudents;

      

        public frmListStudents()
        {
            InitializeComponent();
        }

        private void frmListStudents_Load(object sender, EventArgs e)
        {
            _dtAllStudents = clsStudents.GetAllStudents();
            dgvAllUsers.DataSource = _dtAllStudents;


            dgvAllUsers.Columns[1].HeaderText = "Full Name";
            dgvAllUsers.Columns[1].Width = 140;






        }

        private void updateStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int StudentID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;


            frmAddUpdateStudent frm1 = new frmAddUpdateStudent(StudentID);
            frm1.ShowDialog();
            frmListStudents_Load(null, null);







        }

        private void showStudentsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int StudentID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;



            frmShowStudentsInfo frm1 = new frmShowStudentsInfo(StudentID);
            frm1.ShowDialog();




        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            frmAddUpdateStudent frm1 = new frmAddUpdateStudent();
            frm1.ShowDialog();
            frmListStudents_Load(null, null);




        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int StudentID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;


            if(clsStudents.DeleteStudent(StudentID))
            {



                MessageBox.Show("Student Deleted Sucessfully :-)", "Sucess"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Failed to Delete Student  (-:", "Failed"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);



            }






        }
    }
}
