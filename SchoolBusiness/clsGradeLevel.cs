using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
    public  class clsGradeLevel
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ? GradeLevelID { get; set; }
        public string GradeName { get; set; }










        public  clsGradeLevel(int ? gradeLevelID, string gradeName)
        {
            GradeLevelID = gradeLevelID;
            GradeName = gradeName;

            Mode = enMode.Update;
        }



        public static string GetGradeLevelName(byte? gradeLevelID)
                  => clsGradeLevelData.GetGradeLevelName(gradeLevelID);

        public static byte? GetGradeLevelID(string gradeName)
            => clsGradeLevelData.GetGradeLevelID(gradeName);

        public static DataTable AllOnlyName()=>clsGradeLevelData.AllOnlyNames();


        public static  clsGradeLevel Find(int ? GradeLevelID)
        {

            string GradeLevelName = "";

            if (clsGradeLevelData.GetGradeLevelInfobyID(GradeLevelID, ref GradeLevelName))
                return new clsGradeLevel(GradeLevelID, GradeLevelName);
            else
                return null;



        }
        public static clsGradeLevel Find(string GradeName)
        {

            int   GradeLevelID = 0;

            if (clsGradeLevelData.GetGradeLevelInfobyName(GradeName, ref GradeLevelID))
                return new clsGradeLevel(GradeLevelID,GradeName);
            else
                return null;



        }







    }
}
