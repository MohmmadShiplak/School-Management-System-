using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess
{
    public class clsUsersData
    {

        public static bool GetUserInfoByUserID(int? userID, ref int? personID, ref string username,
    ref string password, ref int permissions, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUsersInfoByUserID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                username = (string)reader["UserName"];
                                password = (string)reader["Password"];
                                permissions = (int)reader["Permissions"];
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
                Console.WriteLine("Error :" + ex.Message);
            }

            return isFound;
        }

        //   public static bool GetUsersInfoByPersonID(int? personID, ref int? userID, ref string username,
        //ref string password, ref int permissions, ref bool isActive)
        //   {
        //       bool isFound = false;

        //       try
        //       {
        //           if (!personID.HasValue)
        //           {
        //               Console.WriteLine("Invalid PersonID");
        //               return false;
        //           }

        //           using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
        //           {
        //               connection.Open();

        //               using (SqlCommand command = new SqlCommand("SP_GetUsersInfobyPersonID", connection))
        //               {
        //                   command.CommandType = CommandType.StoredProcedure;

        //                   command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

        //                   using (SqlDataReader reader = command.ExecuteReader())
        //                   {
        //                       if (reader.Read())
        //                       {
        //                           isFound = true;

        //                           userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
        //                           username = (string)reader["UserName"];
        //                           password = (string)reader["Password"];
        //                           permissions = (int)reader["Permissions"];
        //                           isActive = (bool)reader["IsActive"];
        //                       }
        //                   }
        //               }
        //           }
        //       }
        //       catch (Exception ex)
        //       {
        //           Console.WriteLine($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
        //       }

        //       return isFound;
        //   }
        public static bool GetUsersInfoByPersonID(int? personID, ref int? userID, ref string username,
        ref string password, ref int permissions, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUsersInfoByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                username = (string)reader["UserName"];
                                password = (string)reader["Password"];
                                permissions = (int)reader["Permissions"];
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
                // clsDataAccessHelper.HandleException(ex);
                Console.WriteLine("Error :" + ex.Message);

            }

            return isFound;
        }













        public static bool GetUserInfoByUsername(ref int? userID, ref int? personID, string username,
            ref string password, ref int permissions, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUsersInfoByUserName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                password = (string)reader["Password"];
                                permissions = (int)reader["Permissions"];
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
                Console.WriteLine("Error :" + ex.Message);
            }

            return isFound;
        }

        public static bool GetUserInfoByUsernameAndPassword(ref int? userID, ref int? personID,
             string username,  string   password, ref int permissions, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_GetUsersInfoByUserNameAndPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;
                                userID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                personID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                permissions = (int)reader["Permissions"];
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
                Console.WriteLine("Error :" + ex.Message);
            }

            return isFound;
        }

        public static int? Add(int? personID, string username, string password, int permissions,
            bool isActive)
        {
            // This function will return the new person id if succeeded and null if not
            int? userID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewUsers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Permissions", permissions);
                        command.Parameters.AddWithValue("@IsActive", isActive);

                        SqlParameter outputIdParam = new SqlParameter("@UserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        command.ExecuteNonQuery();

                        userID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return userID;
        }

        public static bool Update(int? userID, int? personID, string username, string password,
            int permissions, bool isActive)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateNewUsers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.AddWithValue("@PersonID", (object)personID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Permissions", permissions);
                        command.Parameters.AddWithValue("@IsActive", isActive);
                        command.Parameters.AddWithValue("@UserID", (object)userID ?? DBNull.Value);
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
        //        public static bool IsUserExist(int ?PersonID)
        //        {

        //            bool IsFound = false;


        //            try
        //            {


        //                using (SqlConnection Connection = new SqlConnection(clsSettings.Connectionstring))
        //                {

        //                    Connection.Open();


        //                    using (SqlCommand Command = new SqlCommand("SP_IsUserExist", Connection))
        //                    {

        //                        Command.Parameters.AddWithValue("@PersonID", PersonID);


        //                        using (SqlDataReader Reader = Command.ExecuteReader())
        //                        {

        //                            {
        //                                IsFound = Reader.HasRows;
        //                            }


        //                        }
        //                    }

        //                }

        //            }
        //            catch(Exception ex)
        //            {
        //                Console.WriteLine("Error :" + ex.Message);
        //            }
        //            return IsFound;
        //}
        public static bool IsUserExist(int? PersonID)
        {
            return clsDataAccessHelper.IsExists("SP_IsUserExist", "PersonID", PersonID);
        }
        public static bool IsUserExist(string UserName)
        {
            return clsDataAccessHelper.IsExists("SP_IsUserExistByUserName", "UserName", UserName);
        }
        public static DataTable GetAllUsers()
        {

            return clsDataAccessHelper.All("SP_GetAllUsers");
        }
        public static bool Delete(int? UserID)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);


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
        public static int Count() => clsDataAccessHelper.Count("SP_GetAllUsersCount");



    }
}
  




















