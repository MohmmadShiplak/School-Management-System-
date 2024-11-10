using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
    public  class clsSubjectGradeLevel
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? SubjectGradeLevelID { get; set; }
        public int? SubjectID { get; set; }
        public byte? GradeLevelID { get; set; }
        public decimal Fees { get; set; }
        public string Description { get; set; }

        public clsSubjects SubjectInfo { get; private set; }
        public clsGradeLevel GradeLevelInfo { get; private set; }

        public clsSubjectGradeLevel()
        {
            SubjectGradeLevelID = null;
            SubjectID = null;
            GradeLevelID = null;
            Fees = -1M;
            Description = null;

            Mode = enMode.AddNew;
        }

        private clsSubjectGradeLevel(int? subjectGradeLevelID, int? subjectID,
            byte? gradeLevelID, decimal fees, string description)
        {
            SubjectGradeLevelID = subjectGradeLevelID;
            SubjectID = subjectID;
            GradeLevelID = gradeLevelID;
            Fees = fees;
            Description = description;

            SubjectInfo = clsSubjects.Find(subjectID);
            GradeLevelInfo = clsGradeLevel.Find(gradeLevelID);

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            SubjectGradeLevelID = clsSubjectGradeLevelData.Add(SubjectID, GradeLevelID,
                Fees, Description);

            return (SubjectGradeLevelID.HasValue);
        }

        private bool _Update()
        {
            return clsSubjectGradeLevelData.Update(SubjectGradeLevelID, SubjectID,
                GradeLevelID, Fees, Description);
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

        public static clsSubjectGradeLevel Find(int? subjectGradeLevelID)
        {
            int? subjectID = null;
            byte? gradeLevelID = null;
            decimal fees = -1M;
            string description = null;

            bool isFound = clsSubjectGradeLevelData.GetInfoByID(subjectGradeLevelID,
                ref subjectID, ref gradeLevelID, ref fees, ref description);

            return (isFound) ? (new clsSubjectGradeLevel(subjectGradeLevelID,
                subjectID, gradeLevelID, fees, description)) : null;
        }
        public static DataTable AllOnlyNames()
        {
            return clsSubjectGradeLevelData.AllOnlyNames();
        }
        public static byte ?GetSubjectID (string SubjectName )
        {
            return clsSubjectGradeLevelData.GetSubjectID(SubjectName);  
        }
        public static DataTable AllTeachersTeachSubject(int? SubjectGradeLevelID)
        {
            return clsSubjectGradeLevelData.AllTeachersTeachSubject(SubjectGradeLevelID);
        }
        public static DataTable AllUntaughtSubjectsByTeacher(int? teacherID)
         => clsSubjectGradeLevelData.AllUntaughtSubjectsByTeacher(teacherID);

        public static DataTable GetAllSubjectGradeLevels() => clsSubjectGradeLevelData.GetAllSubjectGradeLevels();


        public static bool Delete(int SubjectGradeLevelID) => clsSubjectGradeLevelData.Delete(SubjectGradeLevelID);

        public static int Count() => clsSubjectGradeLevelData.Count();

    }
}
