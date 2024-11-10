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
    public partial class frmAddUpdateSubject : Form
    {

        public enum enMode { AddNew=0, UpdateNew=1 };
        public enMode _Mode;


        public int ?_SubjectID = null;

        public clsSubjects _Subject =null;



        public frmAddUpdateSubject(int SubjectID)
        {
            InitializeComponent();
            _SubjectID = SubjectID; 

            _Mode = enMode.UpdateNew;
        }


        public frmAddUpdateSubject()
        {
            InitializeComponent();
          _Mode = enMode.AddNew;
        }

       private void ResetDefualtValues ()
        {

            if (_Mode == enMode.AddNew)
            {
                _Subject = new clsSubjects();

              
                lblTitle.Text = "Add New Subject ";

            }
            else
            {
               lblTitle.Text = "Update Subjects ";
            }
            lblTitle.Text = null;
            txtSubjectName.Text = null;

        }

        private void LoadData()
        {

            _Subject = clsSubjects.Find(_SubjectID);

            if(_Subject==null)
            {

                MessageBox.Show("No Subjects With SubjectID " + _SubjectID.ToString(), "Error "
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;
            }


            lblSubjectID.Text = _Subject.SubjectID.ToString();
            txtSubjectName.Text= _Subject.SubjectName.ToString();    


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Subject.SubjectName=txtSubjectName.Text; 

            if(_Subject.Save())
            {

                MessageBox.Show(" Data  Saved Successfully :-) " + _SubjectID.ToString(), "Success "
                   , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(" Data is not  Saved S (:- " + _SubjectID.ToString(), "Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void frmAddUpdateSubject_Load(object sender, EventArgs e)
        {

           ResetDefualtValues();

            if (_Mode == enMode.UpdateNew)
                LoadData();






        }
    }
}
