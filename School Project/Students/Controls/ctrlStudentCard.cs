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
using System.Xml.Serialization;

namespace School_Project
{
    public partial class ctrlStudentCard : UserControl
    {

        public int ?_StudentID = null;

        public clsStudents _Student;

        public int ?PersonID
        {
            get { return ctrlPersonCard1._PersonID; }
        }
        public int ?StudentID
        {
            get { return _StudentID; }

        }
  
       public clsStudents StudentInfo
        {
            get { return _Student; }
        }

        private void FillStudentsInfo()
        {

            _StudentID = _Student.StudentID.Value;

            ctrlPersonCard1.LoadPersonInfo(_Student.PersonID);
            lblStudentID.Text = _Student.StudentID.ToString();
            lblCreationDate.Text = clsFormat.DateToShort(_Student.CreationDate);
            lblGradeLevel.Text = _Student.GradeLevelInfo?.GradeName;
            // lblCreatedByUser.Text = _Student.CreatedByUserInfo.Username;
            //this is will Implement Later 



        }
        public void LoadStudentsInfoByStudentID(int ?StudentID)
        {

            _StudentID = StudentID;

            if(!_StudentID.HasValue)
            {


                MessageBox.Show("No Students With StudentID "+_StudentID.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                ResetDefualtValues();
               
                return;

            }

            _Student = clsStudents.Find(_StudentID);


            if (_Student==null)
            {
                MessageBox.Show("There is no Students with StudentID " + _StudentID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                ResetDefualtValues();   

                return;
            }

            FillStudentsInfo();
        }
        public void LoadStudentsInfoByPersonID(int PersonID)
        {

            _Student = clsStudents.FindByPersonID(PersonID);

            if (_Student == null)
            {
                MessageBox.Show("There is no Students with StudentID " + _StudentID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            FillStudentsInfo();

        }
        private void ResetDefualtValues()
        {

            _StudentID = null;
            _Student = null;


            lblStudentID.Text = "[???]";
            lblCreatedByUser.Text = "[???]";
            lblGradeLevel.Text = "[???]";
            lblCreationDate.Text = "[???]";

        }






        public ctrlStudentCard()
        {
            InitializeComponent();
        }
    }
}
