using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
     public  class clsStudents
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? StudentID { get; set; }
        public int? PersonID { get; set; }
        public int ? GradeLevelID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime CreationDate { get; set; }

        public clsPerson PersonInfo { get; private set; }
        public clsGradeLevel GradeLevelInfo { get; private set; }
        public clsUsers CreatedByUserInfo { get; private set; }

        public clsStudents()
        {
            StudentID = null;
            PersonID = null;
            GradeLevelID = null;
            CreatedByUserID = null;
            CreationDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsStudents(int? studentID, int? personID, int ? gradeLevelID,
            int? createdByUserID, DateTime creationDate)
        {
            StudentID = studentID;
            PersonID = personID;
            GradeLevelID = gradeLevelID;
            CreatedByUserID = createdByUserID;
            CreationDate = creationDate;

            PersonInfo = clsPerson.Find(personID);
            GradeLevelInfo = clsGradeLevel.Find(gradeLevelID);
            CreatedByUserInfo = clsUsers.Find(createdByUserID);

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            StudentID = clsStudentsData.AddNewStudents(PersonID, GradeLevelID, CreatedByUserID);

            return (StudentID.HasValue);
        }

        private bool _Update()
        {
            return clsStudentsData.UpdateNewStudents( PersonID, GradeLevelID, CreatedByUserID,StudentID);
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

        public static clsStudents Find(int? studentID)
        {
            int? personID = null;
            int ? gradeLevelID = null;
            int? createdByUserID = null;
            DateTime creationDate = DateTime.Now;

            bool isFound = clsStudentsData.GetInfoByStudentID(studentID, ref personID,
                ref gradeLevelID, ref createdByUserID, ref creationDate);

            return (isFound) ? (new clsStudents(studentID, personID, gradeLevelID,
                                createdByUserID, creationDate))
                            : null;
        }
        public static bool IsStudent(int ?PersonID)
        {
            return clsStudentsData.IsStudent(PersonID); 
        }
        public static clsStudents FindByPersonID(int? PersonID)
        {
            int? StudentID = null;
            byte? gradeLevelID = null;
            int? createdByUserID = null;
            DateTime creationDate = DateTime.Now;

            bool isFound = clsStudentsData.GetInfoByPersonID(PersonID, ref StudentID, ref gradeLevelID, ref createdByUserID, ref creationDate);

                

            return (isFound) ? (new clsStudents(StudentID, PersonID, gradeLevelID,
                                createdByUserID, creationDate))
                            : null;
        }
        public static  DataTable GetAllStudents()
        {
            return clsStudentsData.GetAllStudents();
        }
        public static bool DeleteStudent(int ?StudentID)
        {
            return clsStudentsData.Delete(StudentID);
        }
        public static bool IsActiveStudent(int ?StudentID)
        {
            return clsStudentsData.IsActiveStudent(StudentID);
        }
        public static int Count() => clsStudentsData.Count();


    }
}
