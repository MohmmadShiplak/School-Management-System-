using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace SchoolDataAccess
{
    public  class clsSubjectTeacherData
    {

        public static bool GetInfoByID(int? subjectTeacherID, ref int? subjectGradeLevelID,
         ref int? teacherID, ref DateTime assignmentDate,
         ref DateTime? lastModifiedDate, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetSubjectsTeacherInfobyID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectTeacherID", (object)subjectTeacherID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                          


                                if (reader.Read())
                                {
                                    // The record was found
                                    isFound = true;

                                    subjectGradeLevelID = (reader["SubjectGradeLevelID"] != DBNull.Value) ? (int?)reader["SubjectGradeLevelID"] : null;
                                    teacherID = (reader["TeacherID"] != DBNull.Value) ? (int?)reader["TeacherID"] : null;
                                    assignmentDate = (DateTime)reader["AssignmentData"];
                                    lastModifiedDate = (reader["LastModifiedDate"] != DBNull.Value) ? (DateTime?)reader["LastModifiedDate"] : null;
                                    isActive = (bool)reader["IsActive"];
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
                Console.WriteLine("Error :" + ex.ToString());
            }

            return isFound;
        }

        public static int? Add(int? subjectGradeLevelID, int? teacherID)
        {
            // This function will return the new person id if succeeded and null if not
            int? subjectTeacherID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewSubjectsTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectGradeLevelID", (object)subjectGradeLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TeacherID", (object)teacherID ?? DBNull.Value);

                        SqlParameter outputIdParam = new SqlParameter("@NewSubjectTeacher", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        subjectTeacherID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.ToString());
            }

            return subjectTeacherID;
        }

        public static bool Update(int? subjectTeacherID, int? subjectGradeLevelID,
            int? teacherID, bool isActive)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateSubjectTeachers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectTeacherID", (object)subjectTeacherID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@SubjectGradeLevelID", (object)subjectGradeLevelID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@TeacherID", (object)teacherID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@IsActive", isActive);

                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
              Console.WriteLine("Error :"+ex.ToString());
            }

            return (rowAffected > 0);
        }
        public static DataTable AllSubjectsTaughtByTeacher(int? teacherID)
            => clsDataAccessHelper.All("SP_GetAllSubjectsTaughtByTeacher", "TeacherID", teacherID);
        public static DataTable AllActiveSubjectsTaughtByTeacher(int? teacherID)
       => clsDataAccessHelper.All("SP_GetActiveSubjectTaughtByTeacher", "TeacherID", teacherID);













    }
}
