using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class frmAddUpdateTeachers : Form
    {
        public Action<int?> TeacherIDDataBack;

       public enum enMode { AddNew=0,UpdateNew=1};
       public enMode _Mode;

        public int ?_TeacherID =null;

        public int? SelectedPersonID = null;

        public clsTeachers _Teacher;



        public frmAddUpdateTeachers(int ?TeacherID)
        {
            InitializeComponent();
            _TeacherID=TeacherID;   

            _Mode = enMode.UpdateNew;  
        }

        public frmAddUpdateTeachers()
        {
            InitializeComponent();
      

            _Mode = enMode.AddNew;
        }
        private void FillComboBoxWithEducationLevels()
        {
            DataTable educationlevelName = clsEducationLevel.AllOnlyNames();

            foreach(DataRow Row in educationlevelName.Rows )
            {
                cbEducationLevels.Items.Add(Row["LevelName"]);
            }

           // cbEducationLevels.SelectedIndex = 0;
        }





public void ResetDefualtValues()
        {



            FillComboBoxWithEducationLevels();

            if (_Mode == enMode.AddNew)
            {

                _Teacher = new clsTeachers();

                return;

            }
            else
            {

            }

            lblTeacherID.Text = "";
            lblCreatedByUser.Text = "";
            txtCertifications.Text = "";
           cbEducationLevels.SelectedIndex = 0;
        

        }




        public void LoadData()
        {

            _Teacher = clsTeachers.FindByTeacherID(_TeacherID);


            if(_Teacher==null)
            {

                MessageBox.Show("No Teachers with TeacherID  " + _TeacherID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);


                this.Close();

                return;
            }

            lblTeacherID.Text=_TeacherID.ToString();
        //   lblCreatedByUser.Text = clsUsers.Find(_Teacher.CreatedByUserID).Username;
            txtCertifications.Text=_Teacher.Certifications;
               numaricTeachingExperience.Value =(decimal) _Teacher.TeachingExperience;
            //this will implement later 
            cbEducationLevels.SelectedValue = cbEducationLevels.FindString(clsEducationLevel.GetEducationLevelName(_Teacher.EducationLevelID));

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Teacher.PersonID);    

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            _Teacher.TeacherID = SelectedPersonID;
            _Teacher.CreatedByUserID = clsGlobal.CurrentUser?.UserID;
            _Teacher.TeachingExperience = (byte)numaricTeachingExperience.Value;
            _Teacher.Certifications = txtCertifications.Text;
            //this will implement later 
            _Teacher.EducationLevelID = clsEducationLevel.GetEducationLevelID(cbEducationLevels.Text);
            _Teacher.PersonID = ctrlPersonCardWithFilter1.PersonID;

            if(_Teacher.Save())
            {

                lblTeacherID.Text = _Teacher.TeacherID.ToString();

                MessageBox.Show("Data Saves Sucessfully :-)", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TeacherIDDataBack?.Invoke(_Teacher.TeacherID);
            }
            else
            {

                MessageBox.Show("Data is not Saved ( -:", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }





        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter1_OnePersonSelected(object sender, ctrlPersonCardWithFilter.clsPersonSelectedEventArgs e)
        {


if(!e.PersonID.HasValue)
            {
                btnSave.Enabled = false;
                return;


            }

            if (_Mode == enMode.AddNew && ctrlPersonCardWithFilter1.SelectedPersonInfo.IsTeacher)
            {

                MessageBox.Show("This Person is Already Registered as a Teachers , Please Select Onther Person ",
                    "Person Registered "
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;

                return;


            }

            if (_Mode == enMode.AddNew && ctrlPersonCardWithFilter1.SelectedPersonInfo.IsStudent && clsStudents.IsActiveStudent(e.PersonID))
            {

                MessageBox.Show("This Person is Still Student and " + "Can not be Registered as a Teacher until they "
                                + "They have Graduated and Finished Learning at Study Center ", "Active Student ", MessageBoxButtons.OK
                                , MessageBoxIcon.Error);

                btnClose.Enabled = false;

                return;

            }








            SelectedPersonID = e.PersonID;


            btnSave.Enabled = true;


        }

        private void frmAddUpdateTeachers_Load(object sender, EventArgs e)
        {

            ResetDefualtValues();


            if (_Mode == enMode.UpdateNew)
                LoadData();





        }
    }
}
