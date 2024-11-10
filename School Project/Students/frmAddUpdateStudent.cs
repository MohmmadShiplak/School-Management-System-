using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class frmAddUpdateStudent : Form
    {

        public enum enMode { AddNew=0,UpdateNew=1};
        public enMode _Mode;

        public int? _StudentID = null;

        public clsStudents _Student;


        public int? SelectedStudentID =null;




        public frmAddUpdateStudent()
        {
            InitializeComponent();

           
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateStudent(int ?StudentID)
        {
            InitializeComponent();

            _StudentID = StudentID;


            _Mode = enMode.UpdateNew;
        }

        private void FillGradeLevelsInComboBox()
        {

            DataTable dtGradeLevel = clsGradeLevel.AllOnlyName();


            foreach (DataRow Row in dtGradeLevel.Rows)
            {
                cbGradeLevels.Items.Add(Row["GradeName"].ToString());
            }

            // cbGradeLevels.SelectedIndex = 0;

          

        }






        private void FillStudentsInfo()
        {

            ctrlPersonCardWithFilter1.LoadPersonInfo(_Student.PersonID);

            lblStudentID.Text = _Student.StudentID.ToString();
          //  lblCreatedByUser.Text = _Student.CreatedByUserInfo?.Username;
            //this will Implement Later 

            cbGradeLevels.SelectedIndex = cbGradeLevels.FindString(_Student.GradeLevelInfo.GradeName);


        }

        private void ResetDefaultValues()
        {
            FillGradeLevelsInComboBox();

            if(_Mode==enMode.AddNew)
            {


                _Student = new clsStudents();

                lblTitle.Text = "Add New Student ";


                return;
            }
           else
            {
                lblTitle.Text = "Update Students ";
            }




            lblStudentID.Text = "[???]";
            lblCreatedByUser.Text = clsGlobal.CurrentUser?.Username;


        }








        public void LoadData()
        {

           


            _Student = clsStudents.Find(_StudentID);


            if(_Student==null)
            {

                MessageBox.Show("No Students With StudentID " + _StudentID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);


                btnSave.Enabled = false;

                this.Close();


                return;
            }
            FillStudentsInfo();
        }

        private void ctrlPersonCardWithFilter1_OnePersonSelected(object sender, ctrlPersonCardWithFilter.clsPersonSelectedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int  ?GradeLevelID = clsGradeLevel.Find(cbGradeLevels.Text).GradeLevelID;



            _Student.GradeLevelID= GradeLevelID; 
           // _Student.StudentID = SelectedStudentID;
           // _Student.CreatedByUserID = clsGlobal.CurrentUser?.UserID;
            _Student.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _Student.GradeLevelID = clsGradeLevel.GetGradeLevelID(cbGradeLevels.Text);
            //this will Implement Later 
            _Student.PersonID = ctrlPersonCardWithFilter1.PersonID;
            if (_Student.Save())
            {

                this.Text = "Update Students ";
                lblTitle.Text = this.Text;

                _Mode = enMode.UpdateNew;

                lblStudentID.Text = _Student.StudentID.ToString();


                MessageBox.Show("Data Saved Sucessfully :-)", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Data  is not Saved  (:-", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void frmAddUpdateStudent_Load(object sender, EventArgs e)
        {

            ResetDefaultValues();


            if (_Mode == enMode.UpdateNew)
                LoadData();




        }

        private void rlPersonCardWithFilter1_OnePersonSelected(object sender, ctrlPersonCardWithFilter.clsPersonSelectedEventArgs e)
        {

        }
    }
}
