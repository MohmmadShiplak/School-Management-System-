using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess
{
    public  class clsSubjectGradeLevelData
    {

        public static bool GetInfoByID(int? subjectGradeLevelID, ref int? subjectID,
            ref byte? gradeLevelID, ref decimal fees, ref string description)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectsGradeLevelInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectGradeLevelID", (object)subjectGradeLevelID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                subjectID = (reader["SubjectID"] != DBNull.Value) ? (int?)reader["SubjectID"] : null;
                                gradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (byte?)Convert.ToByte(reader["GradeLevelID"]) : null;
                                fees = (decimal)reader["Fees"];
                                description = (reader["Description"] != DBNull.Value) ? (string)reader["Description"] : null;
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
          Console.WriteLine("Error "+ex.ToString());
            }

            return isFound;
        }

        public static int? Add(int? subjectID, byte? gradeLevelID, decimal fees, string description)
        {
            // This function will return the new person id if succeeded and null if not
            int? subjectGradeLevelID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewSubjectGradeLevels", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectID", (object)subjectID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", (object)gradeLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Fees", fees);
                        command.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@SubjectGradeLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        subjectGradeLevelID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }

            return subjectGradeLevelID;
        }

        public static bool Update(int? subjectGradeLevelID, int? subjectID, byte? gradeLevelID,
            decimal fees, string description)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateSubjectGradeLevels", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectGradeLevelID", (object)subjectGradeLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@SubjectID", (object)subjectID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelID", (object)gradeLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Fees", fees);
                        command.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }

            return (rowAffected > 0);
        }
        public static DataTable AllOnlyNames() => clsDataAccessHelper.All("SP_GetAllSubjectNames");
        public static byte? GetSubjectID(string subjectName)
        {
            byte? subjectID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectName", subjectName);

                        SqlParameter outputIdParam = new SqlParameter("@SubjectID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        subjectID = (byte?)(int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
             Console.WriteLine("Error :"+ex.Message);   
            }

            return subjectID;
        }
        public static DataTable AllTeachersTeachSubject(int ?SubjectGradeLevelID)
        {
            return clsDataAccessHelper.All("SP_GetAllTeachersTeachSubject", "SubjectGradeLevel", SubjectGradeLevelID);
        }
        public static DataTable AllUntaughtSubjectsByTeacher(int? teacherID)
        => clsDataAccessHelper.All("SP_GetUntaughtSubjectsbyTeacher", "TeacherID", teacherID);

        public static bool Delete(int? SubjectGradeLevelID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteSubjectGradeLevel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectGradeLevelID", (object)SubjectGradeLevelID ?? DBNull.Value);


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

        public static DataTable GetAllSubjectGradeLevels() => clsDataAccessHelper.All("SP_GetAllSubjectGradeLevel");
        public static int Count() => clsDataAccessHelper.Count("SP_GetAllSubjectGradeLevelsCount");

    }
 












}
