using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
    public   class clsTeachers
    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? TeacherID { get; set; }
        public int? PersonID { get; set; }
        public byte? EducationLevelID { get; set; }
        public byte? TeachingExperience { get; set; }
        public string Certifications { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime CreationDate { get; set; }

        public clsPerson PersonInfo { get; private set; }
        public clsUsers CreatedByUserInfo { get; private set; }

        //this will implement later 
        public clsEducationLevel EducationLevelInfo { get; private set; }

        public clsTeachers()
        {
            TeacherID = null;
            PersonID = null;
            EducationLevelID = 0;
            TeachingExperience = null;
            Certifications = null;
            CreatedByUserID = null;
            CreationDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsTeachers(int? teacherID, int? personID, byte? educationLevelID,
            byte? teachingExperience, string certifications, int? createdByUserID,
            DateTime creationDate)
        {
            TeacherID = teacherID;
            PersonID = personID;
            EducationLevelID = educationLevelID;
            TeachingExperience = teachingExperience;
            Certifications = certifications;
            CreatedByUserID = createdByUserID;
            CreationDate = creationDate;

            PersonInfo = clsPerson.Find(personID);
            CreatedByUserInfo = clsUsers.Find(createdByUserID);    
            EducationLevelInfo = clsEducationLevel.Find(educationLevelID);

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            TeacherID = clsTeachersData.AddNewTeachers(PersonID, EducationLevelID, TeachingExperience,
                Certifications, CreatedByUserID);

            return (TeacherID.HasValue);
        }

        private bool _Update()
        {
            return clsTeachersData.UpdateTeachers(TeacherID, PersonID, EducationLevelID, TeachingExperience,
                Certifications, CreatedByUserID);
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

        public static clsTeachers FindByTeacherID(int? TeacherID)
        {
            int? personID = null;
            byte? educationLevelID = null;
            byte? teachingExperience = null;
            string certifications = null;
            int? createdByUserID = null;
            DateTime creationDate = DateTime.Now;

            bool isFound = clsTeachersData.GetTeachersInfoByTeacherID(TeacherID, ref personID, ref educationLevelID,
                ref teachingExperience, ref certifications, ref createdByUserID, ref creationDate);

            return (isFound) ? (new clsTeachers(TeacherID, personID, educationLevelID,
                                teachingExperience, certifications, createdByUserID, creationDate))
                             : null;
        }
        public static bool IsTeacher(int ?PersonID)
        {
            return clsStudentsData.IsStudent(PersonID);
        }
        public static clsTeachers FindByPersonID(int? PersonID)
        {
            int? TeacherID = null;
            byte? educationLevelID = null;
            byte? teachingExperience = null;
            string certifications = null;
            int? createdByUserID = null;
            DateTime creationDate = DateTime.Now;

            bool isFound = clsTeachersData.GetTeachersInfoByPersonID(PersonID,ref TeacherID, ref educationLevelID,
                ref teachingExperience, ref certifications, ref createdByUserID, ref creationDate);

            return (isFound) ? (new clsTeachers(TeacherID, PersonID, educationLevelID,
                                teachingExperience, certifications, createdByUserID, creationDate))
                             : null;
        }
       public static DataTable GetAllTeachers()
        {
            return clsTeachersData.GetAllTeachers();
        }
        public static DataTable AllInPages(short PageNumber, int RowsPerPage)
           => clsTeachersData.AllInPages(PageNumber, RowsPerPage);
        public static bool DeleteTeacher(int TeacherID)
        {
            return clsTeachersData.DeleteTeacher(TeacherID);
        }
        public static int  Count() => clsTeachersData.Count();


    }
}
