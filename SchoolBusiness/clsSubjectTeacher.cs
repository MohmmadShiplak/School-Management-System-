using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
    public  class clsSubjectTeacher
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int? SubjectTeacherID { get; set; }
        public int? SubjectGradeLevelID { get; set; }
        public int? TeacherID { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public clsSubjectGradeLevel SubjectGradeLevelInfo { get; private set; }
        public clsTeachers TeacherInfo { get; private set; }

        public clsSubjectTeacher()
        {
            SubjectTeacherID = null;
            SubjectGradeLevelID = null;
            TeacherID = null;
            AssignmentDate = DateTime.Now;
            LastModifiedDate = null;
            IsActive = true;

            Mode = enMode.AddNew;
        }

        private clsSubjectTeacher(int? subjectTeacherID, int? subjectGradeLevelID,
            int? teacherID, DateTime assignmentDate, DateTime? lastModifiedDate, bool isActive)
        {
            SubjectTeacherID = subjectTeacherID;
            SubjectGradeLevelID = subjectGradeLevelID;
            TeacherID = teacherID;
            AssignmentDate = assignmentDate;
            LastModifiedDate = lastModifiedDate;
            IsActive = isActive;

            SubjectGradeLevelInfo = clsSubjectGradeLevel.Find(subjectGradeLevelID);
            TeacherInfo = clsTeachers.FindByTeacherID(teacherID);

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            SubjectTeacherID = clsSubjectTeacherData.Add(SubjectGradeLevelID, TeacherID);

            return (SubjectTeacherID.HasValue);
        }

        private bool _Update()
        {
            return clsSubjectTeacherData.Update(SubjectTeacherID,
                SubjectGradeLevelID, TeacherID, IsActive);
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

        public static clsSubjectTeacher Find(int? subjectTeacherID)
        {
            int? subjectGradeLevelID = null;
            int? teacherID = null;
            DateTime assignmentDate = DateTime.Now;
            DateTime? lastModifiedDate = null;
            bool isActive = true;

            bool isFound = clsSubjectTeacherData.GetInfoByID(subjectTeacherID,
                ref subjectGradeLevelID, ref teacherID, ref assignmentDate,
                ref lastModifiedDate, ref isActive);

            return (isFound) ? (new clsSubjectTeacher(subjectTeacherID,
                                subjectGradeLevelID, teacherID, assignmentDate,
                                lastModifiedDate, isActive))
                             : null;
        }
        public static DataTable AllSubjectsTaughtByTeacher(int? teacherID)
      => clsSubjectTeacherData.AllSubjectsTaughtByTeacher(teacherID);

        public static DataTable GetActiveSubjectTaughtByTeacher(int? TeacherID) => clsSubjectTeacherData.AllActiveSubjectsTaughtByTeacher(TeacherID);
      





















    }
}
