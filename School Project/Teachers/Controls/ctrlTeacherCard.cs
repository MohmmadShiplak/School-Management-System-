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
    public partial class ctrlTeacherCard : UserControl
    {

        public int ?_TeacherID = null;
        private clsTeachers _Teacher = null;

        private int? _PersonID = null;

        public int ?PersonID
        {
            get { return _PersonID; }
        }









        public clsTeachers TeacherInfo
        {
            get { return _Teacher; }
        }
        //Expose it through this Control 
        public int  ?TeacherID
        {
            get { return _TeacherID; }
        }

        public void Reset()
        {
            _TeacherID = null;
            _Teacher = null;

            lblTeacherID.Text = "[????]";
            lblTeachingExperience.Text = "[????]";
            lblCertifications.Text = "[????]";
            lblEducationLevel.Text = "[????]";
            lblCreatedByUser.Text = "[????]";
            lblCreationDate.Text = "[????]";

            llEditTeacherInfo.Enabled = false;
        }

        public void LoadTeacherInfoByTeacherID(int? TeacherID)
        {
     

            _Teacher = clsTeachers.FindByTeacherID(TeacherID);

            if (_Teacher == null)
            {
                MessageBox.Show("No Teachers with TeacherID " + TeacherID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                Reset();

                return;
            }

            _FillTeacherData();
        }

        public void LoadTeacherInfoByPersonID(int? personID)
        {

            _Teacher = clsTeachers.FindByPersonID(personID);

            if (_Teacher == null)
            {
                MessageBox.Show($"There is no a teacher with Person ID = {personID} !",
                    "Missing Teacher", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Reset();

                return;
            }

            _FillTeacherData();
        }
        private void _FillTeacherData()
        {



            ctrlPersonCard1.LoadPersonInfo(_Teacher.PersonID);

            lblTeacherID.Text = _Teacher.TeacherID.ToString();
            lblCertifications.Text = _Teacher.Certifications;
            lblEducationLevel.Text = _Teacher.EducationLevelInfo?.LevelName;
            lblTeachingExperience.Text = _Teacher.TeachingExperience.ToString() ;
       //    lblCreatedByUser.Text = _Teacher.CreatedByUserInfo.Username;
            lblCreationDate.Text = clsFormat.DateToShort(_Teacher.CreationDate);

            llEditTeacherInfo.Enabled = true;
        }





        public ctrlTeacherCard()
        {
            InitializeComponent();
        }
    }


















}
