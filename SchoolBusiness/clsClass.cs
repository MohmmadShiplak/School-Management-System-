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
    public  class clsClass
    {

        public enum enMode { AddNew=0,Update=1 };
        public enMode _Mode;

        public int? ClassID { get; set; }
        public string ClassName { get; set; }
        public byte Capacity { get; set; }
        public string Description { get; set; }

        public clsClass()
        {
            ClassID = null;
            ClassName = string.Empty;
            Capacity = 0;
            Description = null;

            _Mode = enMode.AddNew;
        }

        private clsClass(int? classID, string className, byte capacity, string description)
        {
            ClassID = classID;
            ClassName = className;
            Capacity = capacity;
            Description = description;

            _Mode = enMode.Update;
        }
        private bool _Add()
        {
            ClassID = clsClassData.AddNewClasses(ClassName, Capacity, Description);

            return (ClassID.HasValue);
        }

        private bool _Update()
        {
            return clsClassData.UpdateClasses(ClassID,  ClassName, Capacity, Description);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        _Mode = enMode.Update;
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
        public static  clsClass Find(int ?ClassID)
        {

            string ClassName = "", Description = "";

            byte Capacity = 0;

           bool IsFound=clsClassData.GetClassInfobyClassID(ClassID,ref ClassName,ref Capacity,ref Description);

            if(IsFound)
                return new clsClass(ClassID, ClassName, Capacity, Description);
            else
                return null;    


        }
        public static DataTable AllTeachersTeachinClass(int ?ClassID)
        {
            return clsClassData.AllTeachersTeachInClass(ClassID);   
        }
        public static DataTable GetAllClassesAreTaughtTeacher(int ?TeacherID)
        {
           return clsClassData.GetAllCalssesAreTaughtbyTeacher(TeacherID);
        }
        public static DataTable GetAllClasses()=>clsClassData.GetAllClasses();

        public static bool DeleteClass(int ClassID) => clsClassData.Delete(ClassID);
        public static int Count() => clsClassData.Count();



    }
}
