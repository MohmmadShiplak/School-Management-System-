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

namespace School_Project.Classes
{
    public partial class frmListClass : Form
    {
        private DataTable _dtClasses;
        public frmListClass()
        {
            InitializeComponent();
        }

        private void frmListClass_Load(object sender, EventArgs e)
        {
            _dtClasses = clsClass.GetAllClasses();
            dgvClass.DataSource = _dtClasses;


            if(dgvClass.Rows.Count > 0 )
            {

                dgvClass.Columns[0].HeaderText = "Class ID";
                dgvClass.Columns[0].Width = 200;


                dgvClass.Columns[1].HeaderText = "Class Name";
                dgvClass.Columns[1].Width = 200;


                dgvClass.Columns[2].HeaderText = "Capacity";
                dgvClass.Columns[2].Width = 200;


            }

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {

           frmAddUpdateClasses frm1=new frmAddUpdateClasses();
            frmListClass_Load(null, null);
            frm1.ShowDialog();


        }

        private void showClassInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ClassID=(int)dgvClass.CurrentRow.Cells[0].Value;

            frmShowClassInfo frm1 = new frmShowClassInfo(ClassID);
            frmListClass_Load(null, null);
            frm1.ShowDialog();

        }

        private void classesAreTaughtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ClassID = (int)dgvClass.CurrentRow.Cells[0].Value;

            frmGetAllClassesAreTaughByTeacher frm1 = new frmGetAllClassesAreTaughByTeacher(ClassID);

            frm1.ShowDialog();



        }

        private void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ClassID = (int)dgvClass.CurrentRow.Cells[0].Value;

            frmAddUpdateClasses frm1 = new frmAddUpdateClasses(ClassID);
            frmListClass_Load(null, null);
            frm1.ShowDialog();



        }

        private void deleteClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ClassID = (int)dgvClass.CurrentRow.Cells[0].Value;


            if(clsClass.DeleteClass(ClassID))
            {

                MessageBox.Show("Class Deleted Successfully :-)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListClass_Load(null, null);

                return;

            }
            else
            {
                MessageBox.Show("Failed to delete Class ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
