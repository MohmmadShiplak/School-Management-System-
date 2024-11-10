using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Globalization;

namespace SchoolBusiness
{
    public class clsEducationLevel
    {

public enum enMode { AddNew=0,Update=1 };
        public enMode _Mode;

       public byte ?EducationLevelID { get; set; }
        public string LevelName { get; set; }



        public clsEducationLevel (byte? ID ,string LevelName)
        {

            this.EducationLevelID= ID;  
            this.LevelName= LevelName;  

         _Mode=enMode.Update;
        }

        public static  clsEducationLevel Find(byte ?ID)
        {

            string LevelName = " ";


            if (clsEducationLevelData.GetInfoByID(ID, ref LevelName))
                return new clsEducationLevel(ID, LevelName);
            else
                return null;


        }

        public static DataTable AllOnlyNames()
        {
            return clsEducationLevelData.AllOnlyName();
        }
        public static string GetEducationLevelName(byte ?EducationLevelID)
        {
            return clsEducationLevelData.GetEducationLevelName(EducationLevelID);
        }

        public static byte? GetEducationLevelID(string LevelName)
        {
            return clsEducationLevelData.GetEducationLevelID(LevelName);
        }
   

    }
}
