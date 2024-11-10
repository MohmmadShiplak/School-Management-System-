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
    public partial class ctrlGetAllSubjectsTaughtByTeacher : UserControl
    {

        private int? _SubjectTeacherID = null;

        public ctrlGetAllSubjectsTaughtByTeacher()
        {
            InitializeComponent();
        }

        public int ?SubjectTeacherID
        {
            get { return _SubjectTeacherID; }
        }





     private void _LoadSubjectTeacherInfo(int ?TeacherID,object dataSources)
        {

            _SubjectTeacherID=TeacherID;


            var columnsInfo = new[] { ("Subject Teacher ID", 180),
                                     ("Teacher ID", 120),
                                     ("Subject Grade-Level ID", 200),
                                     ("Subject Name", 200),
                                     ("Grade Name", 130),
                                     ("Assignment Date", 160),
                                     ("Is Active", 110)
            };

            ctrlSubList1.LoadInfo(_SubjectTeacherID,dataSources,columnsInfo);


            clsTeachers TeacherInfo=clsTeachers.FindByTeacherID(TeacherID);


            if(TeacherInfo != null)
            {

                //string Prefix = TeacherInfo.PersonInfo.Gendor == clsPerson.enGender.Male ? "Mr" : "MS";
                //ctrlSubList1.Title = $"Subjects Taught by {Prefix}{TeacherInfo.PersonInfo.FullName}";

            }


        }

        public void LoadAllSubjectsInfoTaughtByTeacher(int ?TeacherID)
        {
            _LoadSubjectTeacherInfo(TeacherID, clsSubjectTeacher.AllSubjectsTaughtByTeacher(TeacherID));
        }
        public void LoadActiveSubjectsTaughtByTeacher(int ?TeacherID)
        {
            _LoadSubjectTeacherInfo(TeacherID, clsSubjectTeacher.GetActiveSubjectTaughtByTeacher(TeacherID));
        }




        private void ctrlGetAllSubjectsTaughtByTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
