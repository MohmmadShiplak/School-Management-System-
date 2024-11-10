using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class ctrlStudentCardWithFilter : UserControl
    {

        public class clsStuedntSelectedEventArgs : EventArgs
        {
            public  int ?StuedntID { get; set; }

            public clsStuedntSelectedEventArgs(int ?StudentID)
            {
                this.StuedntID = StudentID;
            }

        }
        public event  EventHandler<clsStuedntSelectedEventArgs> OneStudentSelected;

      public void   RaiseOneStudentSelected(int ?StudentID)
        {
            RaiseOneStudentSelected(new clsStuedntSelectedEventArgs(StudentID));
        }


        protected void RaiseOneStudentSelected(clsStuedntSelectedEventArgs e)
        {
           OneStudentSelected?.Invoke(this, e);
        }

        //private bool _FilterEnabled = true;


        //public bool FilterEnabled
        //{


        //    get
        //    {
        //        return _FilterEnabled;
        //    }
        //    set
        //    {

        //        _FilterEnabled = value;
        //        gpFilter.Enabled = _FilterEnabled;

        //    }


        //}


       
      
      public int ?StudentID
        {
            get { return ctrlStudentCard1.StudentID; }
        }

        public clsStudents SelectedStudentInfo
        {
            get { return ctrlStudentCard1.StudentInfo; }
        }


       //this is onther Solution for filtering data 

        //public void FindNow()
        //{
        //    switch (cbFilter.Text)
        //    {

        //        case "StudentID":
        //            ctrlStudentCard1.LoadStudentsInfoByStudentID(int.Parse(txtStudentID.Text));
        //            break;

        //        case "PersonID":
        //            ctrlStudentCard1.LoadStudentsInfoByPersonID(int.Parse(txtStudentID.Text));
        //            break;


        //        default:
        //            break;
        //    }


        //    if (OneStudentSelected != null && FilterEnabled)
        //        RaiseOneStudentSelected(ctrlStudentCard1.StudentID);




        //}


        //public void LoadStudentInfo(int StudentID)
        //{
        //    cbFilter.SelectedIndex = 0;
        //    txtStudentID.Text = _StudentID.ToString();
        //    FindNow();

        //}

        public void LoadStudentsInfoByStudentID(int ?StudentID)
        {

            ctrlFilter1.TextSearch=StudentID.ToString();
           ctrlStudentCard1.LoadStudentsInfoByStudentID(StudentID);

            if (OneStudentSelected != null)
                RaiseOneStudentSelected(ctrlStudentCard1?.StudentID);


        }

        public ctrlStudentCardWithFilter()
        {
            InitializeComponent();

            ctrlFilter1.ItemsInComboBox(new[] { ("Student ID", true) });
        }

      
        private void ctrlFilter1_OnFindNumericClick(object sender, ctrlFilter.FindNumericClickEventArgs e)
        {

            switch(e?.FieldName)
            {

                case "Student ID":
                    LoadStudentsInfoByStudentID(e?.Value);
                    break;

            }


        }
    }
}
