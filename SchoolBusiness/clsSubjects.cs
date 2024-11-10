using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
    public  class clsSubjects
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? SubjectID { get; set; }
        public string SubjectName { get; set; }

        public clsSubjects()
        {
            SubjectID = null;
            SubjectName = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsSubjects(int? subjectID, string subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            SubjectID = clsSubjectsData.Add(SubjectName);

            return (SubjectID.HasValue);
        }

        private bool _Update()
        {
            return clsSubjectsData.Update(SubjectID, SubjectName);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static clsSubjects Find(int? subjectID)
        {
            string subjectName = string.Empty;

            bool isFound = clsSubjectsData.GetInfoByID(subjectID, ref subjectName);

            return (isFound) ? (new clsSubjects(subjectID, subjectName)) : null;
        }
        public static DataTable AllOnlyNames()
        {
            return clsSubjectsData.AllOnlyNames();
        }




    }
}
