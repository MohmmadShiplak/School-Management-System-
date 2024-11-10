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
    public partial class frmGetAllClassesAreTaughByTeacher : Form
    {

        private int _TeacherID;
        public frmGetAllClassesAreTaughByTeacher(int teacherID)
        {
            InitializeComponent();
            _TeacherID = teacherID; 
        }

        private void frmGetAllClassesAreTaughByTeacher_Load(object sender, EventArgs e)
        {
            ctrlGetAllClassesAreTaughtbyTeacher1.LoadAllClassesThatAreTaughtbyTeacher(_TeacherID);
        }
    }
}
