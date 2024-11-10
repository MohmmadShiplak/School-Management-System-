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
    public partial class frmListTeachers : Form
    {
        public DataTable _dtTeachers;
        private readonly short _RowPerPage = 0;
        public frmListTeachers()
        {
            InitializeComponent();

           // if (short.TryParse(ConfigurationManager.AppSettings["RowsPerPage"], out short value))
            //    _RowPerPage = value;
            //else
            //    _RowPerPage = 10;



        }

        private void frmListTeachers_Load(object sender, EventArgs e)
        {
            _dtTeachers = clsTeachers.GetAllTeachers();

             dgvTeachersList.DataSource = _dtTeachers;


            if (dgvTeachersList.Rows.Count > 0)
            {
                dgvTeachersList.Columns[0].HeaderText = "Teacher ID";
                dgvTeachersList.Columns[0].Width = 110;

                dgvTeachersList.Columns[1].HeaderText = "Full Name";
                dgvTeachersList.Columns[1].Width = 300;

                dgvTeachersList.Columns[2].HeaderText = "Gender";
                dgvTeachersList.Columns[2].Width = 120;

                dgvTeachersList.Columns[3].HeaderText = "Date Of Birth";
                dgvTeachersList.Columns[3].Width = 120;

                dgvTeachersList.Columns[4].HeaderText = "Education Level";
                dgvTeachersList.Columns[4].Width = 130;

                dgvTeachersList.Columns[5].HeaderText = "Age";
                dgvTeachersList.Columns[5].Width = 60;
            }






        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {

            frmAddUpdateTeachers frm1 = new frmAddUpdateTeachers();
            frm1.ShowDialog();
            frmListTeachers_Load(null, null);








        }

        private void showTeachersInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int TeacherID = (int)dgvTeachersList.CurrentRow.Cells[0].Value;


            frmShowTeachersInfo frm1 = new frmShowTeachersInfo(TeacherID);
            frm1.ShowDialog();


        }

        private void updateTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TeacherID = (int)dgvTeachersList.CurrentRow.Cells[0].Value;

            frmAddUpdateTeachers frm1=new frmAddUpdateTeachers(TeacherID);
            frm1.ShowDialog();
            frmListTeachers_Load(null, null);







        }

        private void deleteTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int TeacherID = (int)dgvTeachersList.CurrentRow.Cells[0].Value;

            if (clsTeachers.DeleteTeacher(TeacherID))
            {

                MessageBox.Show("Teacher Deleted Successfully :-)", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListTeachers_Load(null, null);
            }
            else
            {
                MessageBox.Show("Teacher is not Deleted  (:-", "Failed "
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }








        }

        private void subjectHeTeachesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TeacherID = (int)dgvTeachersList.CurrentRow.Cells[0].Value;

            frmGetAllSubjectsTaughtByTeacher frm1=new frmGetAllSubjectsTaughtByTeacher(TeacherID);
            frm1.ShowDialog();





        }

        private void classesHeTeachesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int TeacherID = (int)dgvTeachersList.CurrentRow.Cells[0].Value;

            frmGetAllClassesAreTaughByTeacher frm1 = new frmGetAllClassesAreTaughByTeacher(TeacherID);
            frm1.ShowDialog();  

        }
    }
}
