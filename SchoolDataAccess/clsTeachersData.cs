using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SchoolDataAccess
{
   public static   class clsTeachersData
    {

        public static bool GetTeachersInfoByTeacherID(int? teacherID, ref int? personID, ref byte? educationLevelID,
     ref byte? teachingExperience, ref string certifications,
     ref int? createdByUserID, ref DateTime creationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTeachersInfobyTeacherID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherID", (object)teacherID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                educationLevelID = (reader["EduacationLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["EduacationLevelID"]) : null;
                                teachingExperience = (reader["TeachingExperience"] != DBNull.Value) ? (byte?)reader["TeachingExperience"] : null;
                                certifications = (reader["Certifications"] != DBNull.Value) ? (string)reader["Certifications"] : null;
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

        public static bool GetTeachersInfoByPersonID(int? personID, ref int? teacherID, ref byte? educationLevelID,
            ref byte? teachingExperience, ref string certifications,
            ref int? createdByUserID, ref DateTime creationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetTeachersInfobyPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                teacherID = (reader["TeacherID"] != DBNull.Value) ? (int?)reader["TeacherID"] : null;
                                educationLevelID = (reader["EduacationLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["EduacationLevelID"]) : null;
                                teachingExperience = (reader["TeachingExperience"] != DBNull.Value) ? (byte?)reader["TeachingExperience"] : null;
                                certifications = (reader["Certifications"] != DBNull.Value) ? (string)reader["Certifications"] : null;
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
               Console.WriteLine("Error :"+ex.Message);
            }

            return isFound;
        }

        public static int? AddNewTeachers(int? personID, byte? educationLevelID, byte? teachingExperience,
            string certifications, int? createdByUserID)
        {
            // This function will return the new person id if succeeded and null if not
            int? teacherID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewTeachers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EducationLevelID", (object)educationLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TeachingExperience", (object)teachingExperience ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Certifications", (object)certifications ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)createdByUserID ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@TeacherID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        teacherID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return teacherID;
        }

        public static bool UpdateTeachers(int? teacherID, int? personID, byte? educationLevelID,
            byte? teachingExperience, string certifications,
            int? createdByUserID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateTeachers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TeacherID", (object)teacherID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@EducationLeveLID", (object)educationLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TeachingExperience", (object)teachingExperience ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Certifications", (object)certifications ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)createdByUserID ?? DBNull.Value);

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
        public static bool IsTeacher(int ?PersonID)
        {
            return clsDataAccessHelper.IsExists("SP_IsTeacher", "PersonID", PersonID);
        }
        public static DataTable GetAllTeachers()
        {
            return clsDataAccessHelper.All("SP_GetAllTeachers");
        }
        public static DataTable AllInPages(short PageNumber, int RowsPerPage)
         => clsDataAccessHelper.AllInPages(PageNumber, RowsPerPage, "SP_GetAllTeachersInPages");

        public static bool DeleteTeacher(int TeacherID)
        {


            int RowAffected = 0;


            using (SqlConnection Connection = new SqlConnection(clsSettings.Connectionstring))
            {

                Connection.Open();

                using (SqlCommand Command = new SqlCommand("SP_DeleteTeachers", Connection))
                {

                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@TeacherID",TeacherID);


                    RowAffected = Command.ExecuteNonQuery();
                }

            }
            return RowAffected > 0;
        }
        public static int Count() => clsDataAccessHelper.Count("SP_GetAllTeachersCount");














    }
}
