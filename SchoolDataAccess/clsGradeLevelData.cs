using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess
{
    public class clsGradeLevelData
    {

        public static byte? GetGradeLevelID(string GradeName)
        {

            byte? GradeLevelID = null;


            try
            {




                using (SqlConnection Connection = new SqlConnection(clsSettings.Connectionstring))
                {

                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_GetGradeLevelID", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@GradeName", GradeName);


                        SqlParameter GradeIDOutput = new SqlParameter("@GradeLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };

                        Command.Parameters.Add(GradeIDOutput);

                        Command.ExecuteNonQuery();

                        GradeLevelID = (byte?)(int)GradeIDOutput.Value;


                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.ToString());
            }
            return GradeLevelID;
        }
        public static string GetGradeLevelName(byte? gradeLevelID)
        {
            // This function will return the new person id if succeeded and null if not
            string gradeName = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", gradeLevelID);

                        SqlParameter outputIdParam = new SqlParameter("@GradeName", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        gradeName = outputIdParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return gradeName;
        }
        public static DataTable AllOnlyNames()
         => clsDataAccessHelper.All("SP_GetAllGradeLevelName");

        public static bool GetGradeLevelInfobyID(int? GradeLevelID, ref string GradeLevelName)
        {

            bool IsFound = true;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelsInfobyID", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID",(object) GradeLevelID ?? DBNull.Value);


                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                GradeLevelName = (string)Reader["GradeName"];
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
                Console.WriteLine("Error :" + ex.Message);
            }
            return IsFound;
        }

        public static bool GetGradeLevelInfobyName(string GradeName, ref  int   GradeLevelID)
        {

            bool IsFound = true;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelInfobyName", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeName", (object)GradeName ?? DBNull.Value);


                        using (SqlDataReader Reader = command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                GradeLevelID  = (int)Reader["GradeLevelID"];
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
                Console.WriteLine("Error :" + ex.Message);
            }
            return IsFound;
        }















        public static int Count() => clsDataAccessHelper.Count("SP_GetAllDoctorsCount");









    }


    //    }
}
