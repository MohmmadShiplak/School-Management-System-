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
    public partial class ctrlSubjectTeacherCard : UserControl
    {

        public clsSubjectTeacher _SubjectTeacher=null;

        public clsSubjectTeacher SubjectTeacherInfo
        {
            get { return _SubjectTeacher; }
        }

        private int ?_SubjectTeacherID =null;

        public int ?SubjectTeacherID
        {
            get { return _SubjectTeacherID; }
        }


        private void FillSubjectTeacherInfo()
        {

            lblSubjectTeacherID.Text = _SubjectTeacher.SubjectTeacherID.ToString();
            lblSubjectGradeLevelID.Text = _SubjectTeacher.SubjectGradeLevelID.ToString();
           lblSubjectTeacherID.Text = _SubjectTeacher.SubjectTeacherID.ToString();
            lblTeacherID.Text = _SubjectTeacher.TeacherID.ToString();
            lblGradeLevel.Text = _SubjectTeacher.SubjectGradeLevelInfo.GradeLevelInfo.GradeName;
            lblAssignmentDate.Text = clsFormat.DateToShort(_SubjectTeacher.AssignmentDate);
            lblLastModifiedDate.Text = (_SubjectTeacher.LastModifiedDate.HasValue) ? clsFormat.DateToShort(_SubjectTeacher.LastModifiedDate) : "N/A";
            lblIsActive.Text = (_SubjectTeacher.IsActive) ? "Yes" : "No";


            llShowSubjectInfo.Enabled = true;
            llShowSubjectInfo.Enabled = true;

        }
        public void LoadSubjectTeacherInfo(int ?SubjectTeacherID)
        {

            _SubjectTeacher =clsSubjectTeacher.Find(SubjectTeacherID);

            if(_SubjectTeacher == null)
            {

                MessageBox.Show("No Subject Teachers With Subject Teacher "+_SubjectTeacherID.ToString(),"Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }



            FillSubjectTeacherInfo();


        }


















        public ctrlSubjectTeacherCard()
        {
            InitializeComponent();
        }
    }
}
