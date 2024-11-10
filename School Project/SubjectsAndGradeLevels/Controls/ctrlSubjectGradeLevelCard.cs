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
    public partial class ctrlSubjectGradeLevelCard : UserControl
    {

        public int? _SubjectGradeLevelID = null; 

        public int ?SubjectGradeLevelID
        {
            get { return _SubjectGradeLevelID; }
        }

        public clsSubjectGradeLevel _SubjectGradeLevel;
        //Expose it outside Control 
        public clsSubjectGradeLevel SubjectGradeLevelInfo
        {
            get { return _SubjectGradeLevel; }
        }

        public ctrlSubjectGradeLevelCard()
        {
            InitializeComponent();
        }

        private void FillSubjectGradeLevelInfo()
        {


            lblSubjectGradeLevelID.Text = _SubjectGradeLevel.SubjectGradeLevelID.ToString();
            lblGradeLevelName.Text = _SubjectGradeLevel.GradeLevelInfo.GradeName;
            lblSubjectName.Text = _SubjectGradeLevel.SubjectInfo.SubjectName;
            lblDescription.Text = _SubjectGradeLevel.Description;
            lblFees.Text = _SubjectGradeLevel.Fees.ToString();
            lblSubjectID.Text = _SubjectGradeLevel.SubjectID.ToString();
            lblGradeLevelID.Text = _SubjectGradeLevel.GradeLevelID.ToString();

        }
        public void LoadData(int ?SubjectGradeLevelID)
        {


            _SubjectGradeLevel = clsSubjectGradeLevel.Find(SubjectGradeLevelID);

            if(_SubjectGradeLevel == null)
            {
            
                MessageBox.Show("No Subjects Grade Level With "+SubjectGradeLevelID.ToString(),"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            
            
            }
            FillSubjectGradeLevelInfo();
        }
       










    }
}
