using SchoolBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class ctrlGetAllClassesAreTaughtbyTeacher : UserControl
    {
        private int ?_TeacherID = null;

        public clsClass _Class;

        public ctrlGetAllClassesAreTaughtbyTeacher()
        {
            InitializeComponent();
        }

        public void LoadAllClassesThatAreTaughtbyTeacher (int ?TeacherID)
        {
            _TeacherID = TeacherID;


            object DataSource = clsClass.GetAllClassesAreTaughtTeacher(_TeacherID);

            var ColumnsInfo = new[] { ("ClassID",120),
                                     ("TeacherID",120),
                                      ("Teacher Name",300),
                                       ("Subject Name",165),
                                        ("Grade Name",173)};
           

            ctrlSubList1.LoadInfo(_TeacherID,DataSource,ColumnsInfo);   


        }




    }
}
