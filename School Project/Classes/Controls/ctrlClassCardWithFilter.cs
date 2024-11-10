using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace School_Project
{
    public partial class ctrlClassCardWithFilter : UserControl
    {

        //declare class With Paramatrized Constructer 
        public class clsClassSelectedEvenArgs : EventArgs
        {

            public int? ClassID
            {
                get; set;

            }
            public clsClassSelectedEvenArgs(int? ClassID)
            {
                this.ClassID = ClassID;
            }

        }
        //delcare Eevnt 
        public event  EventHandler<clsClassSelectedEvenArgs> OneClassSelected;

        //take Arguments that sent 
        public  void RaiseOneClassSelected(int? ClassID)
        {
            RaiseOneClassSelected(new clsClassSelectedEvenArgs(ClassID));
        }
        //declare method in order to send Argumnets to other method 
        protected void RaiseOneClassSelected(clsClassSelectedEvenArgs e)
        {
            OneClassSelected?.Invoke(this, e);
        }
        //expose it OutSide Control
        public int? ClassID
        {
            get { return ctrlClassCard1.ClassID; }
        }

        public clsClass ClassInfo
        {
            get { return ctrlClassCard1.ClassInfo; }
        }

        //        private bool _FilterEnabled = true;

        //        public bool FilterEnabled
        //        {

        //get
        //            {
        //                return _FilterEnabled;
        //            }
        //            set
        //            {
        //                _FilterEnabled = value;
        //                gpFilter.Enabled = _FilterEnabled;   

        //            }

        //        }
        //       public void Find()
        //        {


        //switch(cbFilterby.Text)
        //            {

        //                case "ClassID":
        //                    ctrlClassCard1.LoadData(int.Parse(txtFilterValue.Text));
        //                    break;


        //                default:
        //                    break;

        //            }

        //            if (OneClassSelected != null && FilterEnabled)
        //                RaiseOneClassSelected(ctrlClassCard1.ClassID);

        //        }
        //public void LoadData(int ?ClassID)
        //        {

        //            cbFilterby.SelectedIndex = 0;
        //            txtFilterValue.Text = ClassID.ToString();
        //            Find();
        //        }
        //public void LoadClassInfobyClassID(int ?ClassID)
        //{

        //    ctrlFilter1.TextSearch = ClassID.ToString();
        //    ctrlClassCard1.LoadClassInfoByClassID(ClassID);

        //    if (OneClassSelected != null)
        //        RaiseOneClassSelected(ctrlClassCard1.ClassID);
        //}

        public ctrlClassCardWithFilter()
        {
            InitializeComponent();

            ctrlFilter1.ItemsInComboBox(new[] { ("Class ID", true) });
        }

        private void ctrlFilter1_OnFindNumericClick(object sender, ctrlFilter.FindNumericClickEventArgs e)
        {

      
        }

        private void ctrlFilter1_OnFindNumericClick_1(object sender, ctrlFilter.FindNumericClickEventArgs e)
        {
            //switch (e?.FieldName)
            //{


            //    case "Class ID":
            //        LoadClassInfobyClassID(e?.Value);
            //        break;

            //}
        }
    }
}
