using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace School_Project
{
    public partial class frmGetAllTeachersTeachSubject : Form
    {

        private clsSubjectTeacher _subjectTeacher = null;

        private int? _selectedTeacherID = null;

        int? _SubjectGradeLevelID = null;

        public frmGetAllTeachersTeachSubject(int? SubjectGradeLevelID)
        {
            InitializeComponent();
            _SubjectGradeLevelID = SubjectGradeLevelID;

   


        }
        private void _FillSubjectTeacherObjectWithFieldsData()
        {
            _subjectTeacher = new clsSubjectTeacher();
            _subjectTeacher.TeacherID = _selectedTeacherID;
            _subjectTeacher.SubjectGradeLevelID = _SubjectGradeLevelID;
            _subjectTeacher.IsActive = true;
        }

        private void _SaveSubjectTeacher()
        {
            _FillSubjectTeacherObjectWithFieldsData();

            if (_subjectTeacher.Save())
            {
               // clsStandardMessages.ShowSuccess("Subject Teacher");
            }
            else
            {
               // clsStandardMessages.ShowError("Subject Teacher");
            }
        }



        private void frmGetAllTeachersTeachSubject_Load(object sender, EventArgs e)
        {
            ctrlGetAllTeachersTeachSubject1.LoadAllTeachersTeachSubject(_SubjectGradeLevelID);
        }
    }
}
