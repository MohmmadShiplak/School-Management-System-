using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess
{
   public   class  clsStudentsData
    {

        public static bool GetInfoByStudentID(int? studentID, ref int? personID, ref int ? gradeLevelID,
            ref int? createdByUserID, ref DateTime creationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetStudentsInfByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentID", (object)studentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                gradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["GradeLevelID"]) : null;
                                createdByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;
                                creationDate = (DateTime)reader["CreationDate"];
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
                Console.WriteLine("Error :"+ex.Message); ;

            }

            return isFound;
        }

        public static bool GetInfoByPersonID(int? personID, ref int? studentID, ref byte? gradeLevelID,
            ref int? createdByUserID, ref DateTime creationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetStudentsInfoByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                studentID = (reader["studentID"] != DBNull.Value) ? (int?)reader["studentID"] : null;
                                gradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["GradeLevelID"]) : null;
                                createdByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;
                                creationDate = (DateTime)reader["CreationDate"];
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

        public static int? AddNewStudents(int? personID, int ? gradeLevelID,
            int? createdByUserID)
        {
            // This function will return the new person id if succeeded and null if not
            int? studentID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewStudents", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", (object)gradeLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)createdByUserID ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewStudentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteScalar();

                        studentID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {

              
                Console.WriteLine("Error :" + ex.Message);
            }

            return studentID;
        }

        public static bool UpdateNewStudents( int? personID, int ? gradeLevelID,
            int? createdByUserID,int ?StudentID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateStudents", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                    
                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", (object)gradeLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)createdByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@StudentID", (object)StudentID ?? DBNull.Value);
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

        public static bool Delete(int? studentID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StudentID", (object)studentID ?? DBNull.Value);
      

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

        //    public static bool Exists(int? studentID)
        //        => clsDataAccessHelper.Exists("SP_DoesStudentExist", "StudentID", studentID);

        //    public static DataTable All()
        //        => clsDataAccessHelper.All("SP_GetAllStudents");

        //    public static int Count()
        //        => clsDataAccessHelper.Count("SP_GetAllStudentsCount");

        public static bool IsStudent(int? personID)
            => clsDataAccessHelper.IsExists("SP_IsStudent", "PersonID", personID);

        //    public static bool IsStudentActive(int? personID)
        //        => clsDataAccessHelper.Exists("SP_IsStudentActive", "PersonID", personID);

        public static DataTable AllInPages(short PageNumber, int RowsPerPage)
            => clsDataAccessHelper.AllInPages(PageNumber, RowsPerPage, "SP_GetAllStudentsInPages");

        //    public static byte? GetGradeLevelIDOfStudent(int? studentID)
        //    {
        //        // This function will return the new person id if succeeded and null if not
        //        byte? gradeLevelID = null;

        //        try
        //        {
        //            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        //            {
        //                connection.Open();

        //                using (SqlCommand command = new SqlCommand("SP_GetGradeLevelIDOfStudent", connection))
        //                {
        //                    command.CommandType = CommandType.StoredProcedure;

        //                    command.Parameters.AddWithValue("@StudentID", studentID);

        //                    SqlParameter outputIdParam = new SqlParameter("@GradeLevelID", SqlDbType.Int)
        //                    {
        //                        Direction = ParameterDirection.Output
        //                    };
        //                    command.Parameters.Add(outputIdParam);

        //                    command.ExecuteNonQuery();

        //                    gradeLevelID = (byte?)(int)outputIdParam.Value;
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            clsDataAccessHelper.HandleException(ex);
        //        }

        //        return gradeLevelID;
        //    }
        //}

        public static DataTable GetAllStudents()
        {
            return clsDataAccessHelper.All("SP_GetAllStudents");
        }
        public static bool IsActiveStudent(int? PersonID)
        {
            return clsDataAccessHelper.IsExists("SP_IsActiveStudent", "PersonID", PersonID);

        }

        public static int Count() => clsDataAccessHelper.Count("SP_GetAllStudentsCount");






    }

















}

