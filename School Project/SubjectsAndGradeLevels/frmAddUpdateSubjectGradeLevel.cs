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
    public partial class frmAddUpdateSubjectGradeLevel : Form
    {
       public enum enMode { AddNew=0, UpdateNew=1 };
        public enMode _Mode;

        public int? _SubjectGradeLevelID = null;

        public clsSubjectGradeLevel _SubjectGradeLevel;


        public frmAddUpdateSubjectGradeLevel(int ?SubjectGradeLevelID)
        {
            InitializeComponent();
            _SubjectGradeLevelID = SubjectGradeLevelID;

            _Mode = enMode.UpdateNew;
        }
        public frmAddUpdateSubjectGradeLevel()
        {
            InitializeComponent();
          

            _Mode = enMode.AddNew;
        }

        private void FillComboBoxWithGradeLevelNames()
        {

            DataTable dtGradeLevelName = clsGradeLevel.AllOnlyName();

            foreach(DataRow Row in dtGradeLevelName.Rows)
            {
                cbGradeLevels.Items.Add(Row["GradeName"]);
            }
            cbGradeLevels.SelectedIndex = 0;

        }
        private void FillComboBoxWithSubjectGradeLevelName()
        {

            DataTable dtSubjectGradeLevelName = clsSubjects.AllOnlyNames();

            foreach(DataRow Row in dtSubjectGradeLevelName.Rows)
            {
                cbSubjectNames.Items.Add(Row["SubjectName"]);
            }
           cbSubjectNames.SelectedIndex = 0;
        }
        private void ResetDefualtValues()
        {
            FillComboBoxWithGradeLevelNames();

            FillComboBoxWithSubjectGradeLevelName();

            if(_Mode == enMode.AddNew)
            {
                _SubjectGradeLevel = new clsSubjectGradeLevel();

                lblTitle.Text = "Add New Subject Grade Level Name  ";

            }
            else
            {
                lblTitle.Text = "Update Subject Grade Level Name  ";
            }


            lblSubjectGradeLevelID.Text = null;
            txtDescription.Text = null;
            txtFees.Text = null;

        }

        private void LoadData()
        {

            _SubjectGradeLevel = clsSubjectGradeLevel.Find(_SubjectGradeLevelID);

            if(_SubjectGradeLevel == null)
            {


                MessageBox.Show("No Subjects Grade Levels With " + _SubjectGradeLevelID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;


            }

            lblSubjectGradeLevelID.Text = _SubjectGradeLevelID.ToString();
            cbGradeLevels.SelectedIndex = cbGradeLevels.FindString(_SubjectGradeLevel.GradeLevelInfo.GradeName);
            cbSubjectNames.SelectedIndex=cbSubjectNames.FindString(_SubjectGradeLevel.SubjectInfo.SubjectName);
            txtFees.Text = _SubjectGradeLevel.Fees.ToString();
            txtDescription.Text = _SubjectGradeLevel.Description;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //Not Implemented 
            _SubjectGradeLevel.SubjectID = clsSubjectGradeLevel.GetSubjectID(cbSubjectNames.Text);

            _SubjectGradeLevel.GradeLevelID = clsGradeLevel.GetGradeLevelID(cbGradeLevels.Text);

            _SubjectGradeLevel.Fees=Convert.ToDecimal(txtFees.Text);
            _SubjectGradeLevel.Description=txtDescription.Text;

        


            if(_SubjectGradeLevel.Save())
            {


                lblSubjectGradeLevelID.Text = _SubjectGradeLevel.SubjectGradeLevelID.ToString();

                MessageBox.Show("Data Saved Successfully :-)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblTitle.Text = "Update Subject Grade Level Name  ";


              //  _Mode = enMode.UpdateNew;
            }
            else
            {

                MessageBox.Show("Data is not Saved  ):-", "Faild ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }










        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdateSubjectGradeLevel_Load(object sender, EventArgs e)
        {

            ResetDefualtValues();

            if (_Mode == enMode.UpdateNew)
                LoadData();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llEditStudentInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmAddUpdateSubject frm1 = new frmAddUpdateSubject();
            frm1.ShowDialog();




        }
    }
}
