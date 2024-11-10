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
    public partial class ctrlGetAllTeachersTeachSubject : UserControl
    {

        private int? _SubjectGradeLevelID = null;

        public ctrlGetAllTeachersTeachSubject()
        {
            InitializeComponent();
        }


        public void LoadAllTeachersTeachSubject(int ?SubjectGradeLevelID)
        {

            _SubjectGradeLevelID= SubjectGradeLevelID;

            object DataSource = clsSubjectGradeLevel.AllTeachersTeachSubject(_SubjectGradeLevelID);

            var ColumnsInfo = new[] {("Teacher ID",110),
            ("FullName",300),
            ("Gender",120),
            ("Date Of Birth",120),
            ("Education Level",160),
            ("Age",60)};


            ctrlSubList1.LoadInfo(_SubjectGradeLevelID, DataSource, ColumnsInfo);

        








        }










    }
}
