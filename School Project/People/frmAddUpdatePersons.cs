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
using static SchoolBusiness.clsPerson;

namespace School_Project
{
    public partial class frmAddUpdatePersons : Form
    {

        public delegate void DataBackEventHandler(object sender, int? PersonID);

        public DataBackEventHandler DataBack;





        public enum enMode { AddNew=0, UpdateNew=1 };
        public  enMode _Mode = enMode.UpdateNew;

        public  enum enGender {Male=0,Female=1 };



        public  int _PersonID = -1;
        public  clsPerson _Person ;




        public frmAddUpdatePersons(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            _Mode = enMode.UpdateNew;

        }

        public frmAddUpdatePersons()
        {

            InitializeComponent();


            _Mode = enMode.AddNew ;
        }
        private void ResetDefaultValues()
        {

            if(_Mode==enMode.AddNew)
            {
                _Person = new clsPerson();

                return;

            }
            else
            {
//in this case mode is not Add New 
            }
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
         
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

        }
        public  void LoadData()
        {

           

            _Person = clsPerson.Find(_PersonID);


            if (_Person == null)
            {

                MessageBox.Show("No Persons with PersonID " + _PersonID.ToString(), "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

             

                return;


            }
            lblPersonID.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtAddress.Text = _Person.Address;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;

            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = false;

            dtpDateOfBirth.Value = _Person.DateOfBirth;



        }











        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

  

        private void btnSave_Click(object sender, EventArgs e, clsPerson _Person)
        {

         




        }

        private void frmAddUpdatePersons_Load(object sender, EventArgs e)
        {

            ResetDefaultValues();

            if(_Mode==enMode.UpdateNew)
            LoadData();




        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gendor = (short)enGender.Male;
            else
                _Person.Gendor = (short)enGender.Female;


            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                //change form mode to update.

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.UpdateNew;

                DataBack?.Invoke(this, _Person.PersonID);


                // Trigger the event to send data back to the caller form.
                
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);









        }
    }
}
