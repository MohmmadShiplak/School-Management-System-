using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class ctrlPersonCard : UserControl
    {

        public int ?_PersonID =null;

        public clsPerson _Person;

        public clsPerson SelctedPersonInfo => _Person;
      

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public int ?PersonID => _PersonID;




        public void LoadPersonInfo(int ?PersonID)
        {

            _PersonID = PersonID;

            if(!_PersonID.HasValue)
            {

                MessageBox.Show("No People With PersonID "+_PersonID.ToString(),"Error"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);

                ResetPersonInfo();

                return;

            }

            _Person = clsPerson.Find(_PersonID);
           
            if(_Person==null)
            {
            
                MessageBox.Show("No Person with PersonID. = " + _PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                   ResetPersonInfo();

                return;

            }

            _FillPersonInfo();
        }


       private void _FillPersonInfo()
        {


            _PersonID = _Person.PersonID.Value;
            lblPersonID.Text = _Person.PersonID.ToString();
            
            lblFullName.Text = _Person.FullName;
            lblGender.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
           // lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblAddress.Text = _Person.Address;

        }
        public void ResetPersonInfo()
        {

            _PersonID = null;
            _Person = null;
            lblPersonID.Text = "[????]";
       
            lblFullName.Text = "[????]";
       
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
      
            lblAddress.Text = "[????]";
      

        }







    }
}
