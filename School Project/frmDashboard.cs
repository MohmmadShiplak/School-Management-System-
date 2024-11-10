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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

          lblStudents.Text=clsStudents.Count().ToString();
            lblTeachers.Text = clsTeachers.Count().ToString();
            lblClasses.Text = clsClass.Count().ToString();
           lblUsers.Text = clsUsers.Count().ToString();
            lblSubjectGrades.Text = clsSubjectGradeLevel.Count().ToString();
         
        }
    }
}
