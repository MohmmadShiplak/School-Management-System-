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
    public partial class frmAddUpdateClasses : Form
    {

        //Type of Delegation 
        public Action<int?> DataBack;



       private enum enMode { AddNew=0,Update=1 };
       private enMode _Mode;



        private int ?_ClassID = null;

        private clsClass _Class = null;


        public frmAddUpdateClasses(int ClassID)
        {
            InitializeComponent();

            _ClassID = ClassID;

            _Mode = enMode.Update;
        }
        public frmAddUpdateClasses()
        {
            InitializeComponent();

     
            _Mode = enMode.AddNew;
        }

      private void _ResetDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {

                _Class = new clsClass();

            }
         
            lblClassID.Text = null;
            txtClassName.Text = null;   
            txtDescription.Text = null;
            numaricCapacity.Text = null;    
        }

        public void LoadData()
        {

            _Class = clsClass.Find(_ClassID);

            if (_Class==null)
            {

MessageBox.Show("No Classes With ClassID "+_ClassID.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


                this.Close();

                return;

            }


            lblClassID.Text= _ClassID.ToString();
            numaricCapacity.Value = _Class.Capacity;
            txtClassName .Text = _Class.ClassName;
            txtDescription .Text = _Class.Description;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Class.Capacity = (byte)numaricCapacity.Value;
            _Class.ClassName=txtClassName.Text;
            _Class.Description=txtDescription.Text; 

            if(_Class.Save())
            {
                lblClassID.Text = _Class.ClassID.ToString();


                MessageBox.Show("Data Saved Successfully :-)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;

                DataBack?.Invoke(_Class.ClassID);
            }
            else
            {

                MessageBox.Show("Data Failed to Save (:-", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }







        }

        private void frmAddUpdateClasses_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();


            if (_Mode == enMode.Update)
                LoadData();



        }
    }
}
