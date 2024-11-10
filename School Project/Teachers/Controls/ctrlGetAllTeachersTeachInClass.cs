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
    public partial class ctrlGetAllTeachersTeachInClass : UserControl
    {

        private int ?_ClassID = null;


        public ctrlGetAllTeachersTeachInClass()
        {
            InitializeComponent();
        }

        public void LoadAllTeachersTeachSubject (int ?ClassID)
        {

            _ClassID = ClassID;

            object DataSource = clsClass.AllTeachersTeachinClass(_ClassID);

            var ColumnsInfo = new[] {
                ("Teacher ID",110),
                ("Full Name",300),
                ("Class ID",120),
                ("Group ID",120),
                ("Group Name",160),
                ("Subject Name",150),
                ("Grade Name",120)

            };
          

            ctrlSubList1.LoadInfo(_ClassID,DataSource,ColumnsInfo);


            ctrlSubList1.Title = "Teachers are Teaching in Class ";










        }















    }
}
