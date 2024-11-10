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
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        public class clsPersonSelectedEventArgs:EventArgs
        {

            public int? PersonID { get; set; }


            public clsPersonSelectedEventArgs(int ?PersonID)
            {

                this.PersonID = PersonID;


            }

        }
        public event EventHandler<clsPersonSelectedEventArgs> OnePersonSelected;

        public void RaiseOnePersonSelected(int ?PersonID)
        {
            RaiseOnePersonSelected(new clsPersonSelectedEventArgs(PersonID));
        }

        protected virtual void RaiseOnePersonSelected(clsPersonSelectedEventArgs e)
        {
            OnePersonSelected?.Invoke(this, e);
        }

        private bool _FilterEnabled = true;


        public bool FilterEnabled
        {

            get => ctrlFilter1.FilterEnabled;
            set => ctrlFilter1.FilterEnabled = value;
        }




        public int? PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }
        //Expose outside the Control 
        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCard1.SelctedPersonInfo; }
        }
        private void FindNow()
        {

            //switch(cbFilterby.Text)
            //{

            //    case "PersonID":
            //         ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
            //        break;

            //    default:
            //        break;
                  
            //}


            //if (OnePersonSelected != null && FilterEnabled)
            //   RaiseOnePersonSelected(ctrlPersonCard1._PersonID);

          

        }
        public void LoadPersonInfo(int ?PersonID)
        {

            ctrlFilter1.TextSearch = PersonID.ToString();
           ctrlPersonCard1?.LoadPersonInfo(PersonID);


            if (OnePersonSelected != null && FilterEnabled)
                RaiseOnePersonSelected(ctrlPersonCard1?.PersonID);



        

        }


        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();

          ctrlFilter1.ItemsInComboBox(new[] { ("Person ID", true) });



        }


        private void ctrlFilter1_OnFindNumericClick(object sender, ctrlFilter.FindNumericClickEventArgs e)
        {

          switch(e?.FieldName)
            {

                case "Person ID":
                    LoadPersonInfo(e.Value);
                    break;

            }




        }
    }
}
