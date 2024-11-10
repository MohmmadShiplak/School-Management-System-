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
    public partial class frmListSubjectGradeLevel : Form
    {

        private DataTable _dtSubjectGradeLevel;

        public frmListSubjectGradeLevel()
        {
            InitializeComponent();
        }

        private void frmListSubjectGradeLevel_Load(object sender, EventArgs e)
        {

    _dtSubjectGradeLevel=clsSubjectGradeLevel.GetAllSubjectGradeLevels();
     dgvSubjectGradeLevel.DataSource= _dtSubjectGradeLevel;  

            if(dgvSubjectGradeLevel.Rows.Count > 0 )
            {

                dgvSubjectGradeLevel.Columns[0].HeaderText = "Subject Grade LevelID";
                dgvSubjectGradeLevel.Columns[0].Width = 150;

                dgvSubjectGradeLevel.Columns[1].HeaderText = "Subject Name";
                dgvSubjectGradeLevel.Columns[1].Width = 150;

                dgvSubjectGradeLevel.Columns[2].HeaderText = "Grade Name";
                dgvSubjectGradeLevel.Columns[2].Width = 150;

                dgvSubjectGradeLevel.Columns[3].HeaderText = "Description";
                dgvSubjectGradeLevel.Columns[3].Width = 150;

            }

        }

        private void showSubjectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int SubjectGradeLevelID = (int)dgvSubjectGradeLevel.CurrentRow.Cells[0].Value;

            frmShowSubjectsGradeLevelInfo frm1 = new frmShowSubjectsGradeLevelInfo(SubjectGradeLevelID);
            frm1.ShowDialog();


        }

        private void showSubjectTeacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int SubjectGradeLevelID = (int)dgvSubjectGradeLevel.CurrentRow.Cells[0].Value;


            frmShowSubjectTeacherInfo frm1=new frmShowSubjectTeacherInfo(SubjectGradeLevelID);
            frm1.ShowDialog();

        }

        private void whoTeacherItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SubjectGradeLevelID = (int)dgvSubjectGradeLevel.CurrentRow.Cells[0].Value;

            frmGetAllTeachersTeachSubject frm1=new frmGetAllTeachersTeachSubject(SubjectGradeLevelID);
            frm1.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {


            int SubjectGradeLevelID = (int)dgvSubjectGradeLevel.CurrentRow.Cells[0].Value;

            frmAddUpdateSubjectGradeLevel frm1 = new frmAddUpdateSubjectGradeLevel(SubjectGradeLevelID);
            frm1.ShowDialog();

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int SubjectGradeLevelID=(int)dgvSubjectGradeLevel.CurrentRow.Cells [0].Value;



            if (clsSubjectGradeLevel.Delete(SubjectGradeLevelID))
            {

                MessageBox.Show("SubjectGradeLevel Deleted Successfully :-)", "Success"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListSubjectGradeLevel_Load(null, null);
            }
            else
            {
                MessageBox.Show("SubjectGradeLevel  is not Deleted  (:-", "Failed "
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {

            frmAddUpdateSubjectGradeLevel frm1=new frmAddUpdateSubjectGradeLevel();
            frm1.ShowDialog();

        }
    }
}
