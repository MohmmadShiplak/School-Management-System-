using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataAccess
{
    public class clsPersonData
    {
        //public static bool GetPersonsInfoByID(int? PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref byte? Gender, ref DateTime ?DateOfBirth, ref string Phone, ref string Email, ref string Address)
        //{
        //    bool IsFound = false;

        //    try
        //    {
        //        using (SqlConnection Connection = new SqlConnection(clsSettings.Connectionstring))
        //        {
        //            Connection.Open();

        //            using (SqlCommand Command = new SqlCommand("SP_GetPersonsInfobyID", Connection))
        //            {
        //                Command.CommandType = CommandType.StoredProcedure;
        //                Command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

        //                using (SqlDataReader Reader = Command.ExecuteReader())
        //                {
        //                    if (Reader.Read())
        //                    {
        //                        IsFound = true;
        //                        FirstName = Reader["FirstName"] != DBNull.Value ? (string)Reader["FirstName"] : null;
        //                        SecondName = Reader["SecondName"] != DBNull.Value ? (string)Reader["SecondName"] : null;
        //                        ThirdName = Reader["ThirdName"] != DBNull.Value ? (string)Reader["ThirdName"] : null;
        //                        LastName = Reader["LastName"] != DBNull.Value ? (string)Reader["LastName"] : null;
        //                        Gender = Reader["Gendor"] != DBNull.Value ? (byte)Reader["Gendor"] : (byte)0; // Default value if needed
        //                        DateOfBirth = Reader["DateOfBirth"] != DBNull.Value ? (DateTime)Reader["DateOfBirth"] : DateTime.MinValue; // Handle accordingly
        //                        Phone = Reader["Phone"] != DBNull.Value ? (string)Reader["Phone"] : null;
        //                        Email = Reader["Email"] != DBNull.Value ? (string)Reader["Email"] : null;
        //                        Address = Reader["Address"] != DBNull.Value ? (string)Reader["Address"] : null;
        //                    }
        //                    else
        //                    {
        //                        IsFound = false;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred: {ex.Message}");
        //        // Handle exception, e.g., log it
        //    }

        //    return IsFound;
        //}
        public static bool GetPersonsInfoByID(int? PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
    ref DateTime DateOfBirth
       , ref short Gendor, ref string Phone, ref string Email, ref string Address)
        {

            bool IsFound = false;

            using (SqlConnection Connection = new SqlConnection(clsSettings.Connectionstring))
            {

                Connection.Open();
                //name of Store Procedure 
                using (SqlCommand Command = new SqlCommand("SP_GetPersonsInfobyID", Connection))
                {


                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);


                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {

                        if (Reader.Read())
                        {

                            IsFound = true;

                            FirstName = (Reader["FirstName"] != DBNull.Value) ? (string)Reader["FirstName"] : null;
                            SecondName = (Reader["SecondName"] != DBNull.Value) ? (string)Reader["SecondName"] : null;
                            ThirdName = (Reader["ThirdName"] != DBNull.Value) ? (string)Reader["ThirdName"] : null;
                            LastName = (Reader["LastName"] != DBNull.Value) ? (string)Reader["LastName"] : null;
                            Gendor = (byte)Reader["Gendor"];
                            DateOfBirth = (DateTime)Reader["DateOfBirth"];
                          
                            Phone = (string)Reader["Phone"];
                            Email = (string)Reader["Email"];
                            Address = (Reader["Address"] != DBNull.Value) ? (string)Reader["Address"] : null;
                          //  ImagePath = (Reader["ImagePath"] != DBNull.Value) ? (string)Reader["ImagePath"] : null;

                        }
                        else
                        {
                            IsFound = false;
                        }

                    }
                    return IsFound;

                }

            }
        }

                public static int? AddNewPersons(string FirstName, string SecondName, string ThirdName, string LastName, short  Gender, DateTime? DateOfBirth, string Phone, string Email, string Address)
        {
            // This function will return the new person id if succeeded and null if not
            int? PersonID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddNewPersons", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Gendor", Gender);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);

                        SqlParameter OutputPersonID = new SqlParameter("@PersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(OutputPersonID);

                        command.ExecuteScalar();

                        PersonID = (int)OutputPersonID.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            return PersonID;
        }


        public static bool UpdatePersons(int ?PersonID,string FirstName, string SecondName, string ThirdName, string LastName, short  Gender, DateTime  DateOfBirth, string Phone, string Email, string Address)
        {
            // This function will return the new person id if succeeded and null if not
           int  RowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.Connectionstring))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdatePersons", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", ThirdName );
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Gendor", Gender);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);


                        RowAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            return (RowAffected > 0);
        }




    }

}
