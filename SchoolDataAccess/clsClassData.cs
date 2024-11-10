using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace SchoolDataAccess
{
    public class clsClassData
    {

        public static bool GetClassInfobyClassID(int? ClassID, ref string ClassName, ref byte Capacity, ref string Description)
        {

            bool IsFound = false;



            try
            {
                using (SqlConnection Connection = new SqlConnection(clsSettings.Connectionstring))
                {

                    Connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetClassesInfobyClassID", Connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@ClassID", (object)ClassID ?? DBNull.Value);


                        using (SqlDataReader Reader = command.ExecuteReader())
                        {


                            if (Reader.Read())
                            {

                                IsFound = true;

                                ClassName = (string)Reader["ClassName"];
                                Capacity = (byte)Reader["Capacity"];
                                Description = (Reader["Description"] != DBNull.Value) ? (string)Reader["Description"] : null;

                            }
                            else
                            {
                                IsFound = false;
                            }



                        }

                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Errro :" + ex.ToString());
            }

            return IsFound;

        }
        public static int? AddNewClasses(string ClassName, short Capacity, string Description)
        {

            int? ClassID = null;


            try
            {



                using (SqlConnection Connection = new SqlConnection(clsSettings.Connectionstring))
                {

                    Connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_AddNewClasses", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ClassName", (object)ClassName ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Capacity", (object)Capacity ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);


                        SqlParameter OutPutClassID = new SqlParameter("@ClassID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };


                        Command.Parameters.Add(OutPutClassID);

                        Command.ExecuteScalar();


                        ClassID = (int?)OutPutClassID.Value;

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return ClassID;
        }
        public static bool UpdateClasses(int? ClassID, string ClassName, short ?Capacity, string Description)
        {
            int Rowaffected = 0;

            try
            {



                using (SqlConnection Connection = new SqlConnection(clsSettings.Connectionstring))
                {

                    Connection.Open();


                    using (SqlCommand Command = new SqlCommand("SP_UpdateClasses", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ClassID", (object)ClassID ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@ClassName", (object)ClassName ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Capacity", (object)Capacity ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);




                        Rowaffected = Command.ExecuteNonQuery();



                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            return Rowaffected > 0;
        }
        public static DataTable AllTeachersTeachInClass(int? classID)
=> clsDataAccessHelper.All("SP_TeachersTeachInClass", "ClassID", classID);

       public static DataTable GetAllCalssesAreTaughtbyTeacher(int ?TeacherID)
        {
            return clsDataAccessHelper.All("SP_ClassesAreTaughtByTeacher", "TeacherID", TeacherID);
        }
        public static DataTable GetAllClasses() => clsDataAccessHelper.All("SP_GetAllClasses");

        public static bool Delete(int? ClassID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteClass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ClassID", (object)ClassID ?? DBNull.Value);


                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return (rowAffected > 0);
        }

        public static int Count() => clsDataAccessHelper.Count("SP_GetAllClassesCount");



    }
    
}
