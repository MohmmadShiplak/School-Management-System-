using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess
{
    public  class clsEducationLevelData
    {
        public static bool GetInfoByID(byte? educationLevelID, ref string levelName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEducationLevelsInfobyID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EducationLevelID", (object)educationLevelID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                levelName = (string)reader["LevelName"];
                            }
                            else
                            {
                                // The record was not found
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine("Error :" + ex.Message);
            }

            return isFound;
        }

        public static byte? Add(string levelName)
        {
            // This function will return the new person id if succeeded and null if not
            byte? educationLevelID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddEducationLevels", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@LevelName", levelName);

                        SqlParameter outputIdParam = new SqlParameter("@EducationLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        educationLevelID = (byte?)(int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return educationLevelID;
        }

        public static bool Update(byte? educationLevelID, string levelName)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateEducationLevels", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EducationLevelID", (object)educationLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LevelName", levelName);

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

        public static bool Delete(byte? educationLevelID)
            => clsDataAccessHelper.Delete("SP_DeleteEducationLevel", "EducationLevelID", educationLevelID);

        //public static bool Exists(byte? educationLevelID)
        //    => clsDataAccessHelper.Exists("SP_DoesEducationLevelExist", "EducationLevelID", educationLevelID);

        //public static DataTable All()
        //    => clsDataAccessHelper.All("SP_GetAllEducationLevels");

        //public static DataTable AllOnlyNames()
        //    => clsDataAccessHelper.All("SP_GetAllEducationLevelsName");

        public static string GetEducationLevelName(byte? educationLevelID)
        {
            string levelName = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEducationLevelName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@EducationLevelID", educationLevelID);

                        SqlParameter outputIdParam = new SqlParameter("@LevelName", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        levelName = outputIdParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);

            }

            return levelName;
        }
        public static DataTable AllOnlyName()
        {
            return clsDataAccessHelper.All("SP_GetAllEducationLevelName");
        }
        public static byte? GetEducationLevelID(string educationLevelName)
        {
            // This function will return the new person id if succeeded and null if not
            byte? educationLevelID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetEducationLevelID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@LevelName", educationLevelName);

                        SqlParameter outputIdParam = new SqlParameter("@EducationLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        educationLevelID = (byte?)(int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return educationLevelID;
        }
    }







}
  



