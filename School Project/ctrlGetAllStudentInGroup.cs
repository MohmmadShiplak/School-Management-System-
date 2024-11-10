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
    public partial class ctrlGetAllStudentInGroup : UserControl
    {
        private int? _GroupID = null;
        private string _GroupName = null;   

        public ctrlGetAllStudentInGroup()
        {
            InitializeComponent();
        }

        private void _LoadData(string Title)
        {

            object DataSource = clsGroup.GetAllStudentsInGroup(_GroupID);


            var ColumnsInfo = new[] {("Student ID",110) ,
                                     ("Full Name",300),
                                     ("Gender",120),
                                     ("Date Of Birth",120),
                                     ("Grade",130),
                                     ("Age",60)};

            ctrlSubList1.LoadInfo(_GroupID,DataSource,ColumnsInfo); 

        }
        //public void LoadAllStudentsInGroup(int ?GroupID)
        //{

        //    _GroupID = GroupID;


        //    _LoadData("Students are in the Group ");


        //}
        public void LoadAllStudentsInGroup(int ?GroupID)
        {

            _GroupID= GroupID;
         //   _GroupName = GroupName;

            _LoadData($"Students are in the Group {_GroupName}");
        }









    }
}
