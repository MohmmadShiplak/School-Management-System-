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
    public partial class frmGetAllSubjectsTaughtByTeacher : Form
    {
        public int? _TeacherID = null;

        public frmGetAllSubjectsTaughtByTeacher(int TeacherID)
        {
            InitializeComponent();
            _TeacherID=TeacherID;
        }

        private void frmGetAllSubjectsTaughtByTeacher_Load(object sender, EventArgs e)
        {

            ctrlTeacherCard1.LoadTeacherInfoByTeacherID(_TeacherID);
            ctrlGetAllSubjectsTaughtByTeacher1.LoadActiveSubjectsTaughtByTeacher(_TeacherID);
          









        }
    }
}
