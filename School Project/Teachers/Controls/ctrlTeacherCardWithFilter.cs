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
using static School_Project.ctrlPersonCardWithFilter;

namespace School_Project
{
    public partial class ctrlTeacherCardWithFilter : UserControl
    {

        public class clsTeacherSelectedEventArgs:EventArgs
        {

        public int? TeacherID { get; }


        public clsTeacherSelectedEventArgs(int? TeacherID)
        {

            this.TeacherID = TeacherID;


        }

    }
    public event EventHandler<clsTeacherSelectedEventArgs> OneTeacherSelected;

    public void RaiseOneTeacherSelected(int? TeacherID)
    {
        RaiseOneTeacherSelected(new clsTeacherSelectedEventArgs(TeacherID));
    }

    protected void RaiseOneTeacherSelected(clsTeacherSelectedEventArgs e)
    {
        OneTeacherSelected?.Invoke(this, e);
    }

    private bool _FilterEnabled = true;


    public bool FilterEnabled
    {

            get => ctrlFilter1.FilterEnabled;
            set => ctrlFilter1.FilterEnabled = value;
  
    }

        public int ?TeacherID => ctrlTeacherCard1.TeacherID;

        //Expose outside the Control 
        public clsTeachers SelectedTeacherInfo => ctrlTeacherCard1.TeacherInfo;
   
    //private void FindNow()
    //{

    //    switch (cbFindBy.Text)
    //    {

    //        case "PersonID":
    //            ctrlTeacherCard1.LoadTeacherInfoByPersonID(int.Parse(txtSearch.Text));
    //            break;


    //            case "TeacherID":
    //                ctrlTeacherCard1.LoadTeacherInfoByTeacherID(int.Parse(txtSearch.Text));
    //                break;

    //            default:
    //            break;

    //    }

    //    if (OneTeacherSelected != null && FilterEnabled)
    //        RaiseOneTeacherSelected(ctrlTeacherCard1.TeacherID);

    //}
    public void LoadTeacherInfo(int? TeacherID)
    {
        //cbFindBy.SelectedIndex = 0;
        //txtSearch.Text = TeacherID.ToString();
        //FindNow();

    }
        public void LoadTeachersInfoByTeacher(int ?TeacherID)
        {

            ctrlFilter1.TextSearch=TeacherID.ToString();
            ctrlTeacherCard1.LoadTeacherInfoByTeacherID(TeacherID);

            if (OneTeacherSelected != null)
                RaiseOneTeacherSelected(ctrlTeacherCard1.TeacherID);



            //txtSearch.Text = TeacherID.ToString();
            //ctrlTeacherCard1.LoadTeacherInfoByTeacherID(TeacherID);
        }
        public void LoadTeacherInfoByPersonID(int ?PersonID)
        {

            ctrlFilter1.TextSearch = PersonID.ToString();
            ctrlTeacherCard1.LoadTeacherInfoByPersonID(PersonID);


            if (OneTeacherSelected != null)
                RaiseOneTeacherSelected(ctrlTeacherCard1.PersonID);




            //txtSearch.Text = PersonID.ToString();
            //ctrlTeacherCard1.LoadTeacherInfoByPersonID(PersonID);

            //if (OneTeacherSelected != null)
            //    RaiseOneTeacherSelected(ctrlTeacherCard1.PersonID);


        }






















        public ctrlTeacherCardWithFilter()
        {
            InitializeComponent();

            ctrlFilter1.ItemsInComboBox(new[] { ("Teacher ID", true),("PersonID",true) });

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void ctrlFilter1_OnFindNumericClick(object sender, ctrlFilter.FindNumericClickEventArgs e)
        {

          switch(e?.FieldName)
            {


                case "Teacher ID":
                    LoadTeachersInfoByTeacher(e.Value);
                    break;

                case "Person ID":
                    LoadTeacherInfoByPersonID(e.Value);
                    break;
                    
            }


        }
    }
}
