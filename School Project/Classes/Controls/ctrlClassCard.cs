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
    public partial class ctrlClassCard : UserControl
    {

        private clsClass _Class;

        private int ?_ClassID =null;


        public clsClass ClassInfo
        {
            get { return _Class; }
        }


        public int ?ClassID
        {
            get { return _ClassID; }
        }


        public void FillClassesInfo()
        {


            _ClassID = _Class.ClassID.Value;

            lblClassID.Text = _Class.ClassID.ToString();
            lblClassName.Text=_Class.ClassName.ToString();
            lblDescription.Text = _Class.Description.ToString();
            lblCapacity.Text = _Class.Capacity.ToString();  


        }

        public void LoadClassInfoByClassID(int ?ClassID)
        {

            _Class = clsClass.Find(ClassID);

            if(_Class==null)
            {
                ResetDefualtValues();

                MessageBox.Show("No Classes With ClassID " + _ClassID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            FillClassesInfo();
        }


        public void ResetDefualtValues()
        {

            lblClassID.Text = null ;
            lblClassName.Text = null;
            lblDescription.Text = null;
            lblCapacity.Text = null;


        }











        public ctrlClassCard()
        {
            InitializeComponent();
        }
    }
}
