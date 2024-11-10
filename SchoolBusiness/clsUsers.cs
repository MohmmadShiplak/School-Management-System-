using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
    public class clsUsers
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;



        public enum enPermissions
        {
            All = -1,
            AddUser = 1,
            UpdateUser = 2,
            DeleteUser = 4,
            ListUsers = 8
        }


        public int? UserID { get; set; }
        public int? PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public bool IsActive { get; set; }

        public clsPerson PersonInfo { get; private set; }

        public clsUsers()
        {
            UserID = null;
            PersonID = null;
            Username = string.Empty;
            Password = string.Empty;
            Permissions = -1;
            IsActive = true;

            Mode = enMode.AddNew;
        }

        private clsUsers(int? userID, int? personID, string username, string password,
            int permissions, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            Username = username;
            Password = password;
            Permissions = permissions;
            IsActive = isActive;
            PersonInfo = clsPerson.Find(personID);

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            UserID = clsUsersData.Add(PersonID, Username, Password, Permissions, IsActive);

            return (UserID.HasValue);
        }

        private bool _Update()
        {
            return clsUsersData.Update(UserID, PersonID, Username, Password, Permissions, IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static clsUsers FindByUserID(int? UserID)
        {
            int? PersonID = null;
            string Username = string.Empty;
            string Password = string.Empty;
            int permissions = -1;
            bool IsActive = false;

            bool IsFound = clsUsersData.GetUserInfoByUserID(UserID, ref PersonID,
             ref Username, ref Password, ref permissions, ref IsActive);





            return (IsFound) ? (new clsUsers(UserID, PersonID, Username, Password, permissions, IsActive)) : null;

            return null;

        }

        public static clsUsers Find(int? PersonID)
        {
            int? UserID = null;
            string Username = string.Empty;
            string Password = string.Empty;
            int permissions = -1;
            bool IsActive = false;

            bool IsFound = clsUsersData.GetUsersInfoByPersonID(PersonID, ref UserID,
                ref Username, ref Password, ref permissions, ref IsActive);

            return (IsFound) ? (new clsUsers(UserID, PersonID, Username, Password, permissions, IsActive)) : null;


        }

        public static clsUsers Find(string Username)
        {
            int? UserID = null;
            int? PersonID = null;
            string Password = string.Empty;
            int permissions = -1;
            bool IsActive = false;

            bool IsFound = clsUsersData.GetUserInfoByUsername(ref UserID, ref PersonID,
                Username, ref Password, ref permissions, ref IsActive);

            return (IsFound) ? (new clsUsers(UserID, PersonID, Username, Password, permissions, IsActive)) : null;
        }

       public  static clsUsers Find(string Username, string   Password)
        {
            int? UserID = null;
            int? PersonID = null;
            bool IsActive = false;
            int permissions = -1;
            bool IsFound = clsUsersData.GetUserInfoByUsernameAndPassword(ref UserID, ref PersonID,  Username,
                Password, ref permissions, ref IsActive);

            return (IsFound) ? (new clsUsers(UserID, PersonID, Username, Password, permissions, IsActive)) : null;
        }
        public static bool IsUserExist(int? PersonID)
        {
            return clsUsersData.IsUserExist(PersonID);
        }
        public static bool IsUserExist(string UserName)
        {
            return clsUsersData.IsUserExist(UserName);
        }
        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }
        public static bool DeleteUser(int UserID)=>clsUsersData.Delete(UserID); 
     
        public List<string>PermissionsText()
        {

            if (Permissions == -1)
                return new List<string> { "Admin" };

            List<string> permissions = new List<string>();  

            if(((int)enPermissions.AddUser&Permissions)==(int)enPermissions.AddUser)
                    {
                permissions.Add("Add User");
            }

            if(((int)enPermissions.UpdateUser&Permissions)==(int)enPermissions.UpdateUser)
            {
                permissions.Add("Update User");
            }

            if(((int)enPermissions.DeleteUser&Permissions)==(int)enPermissions.DeleteUser)
            {
                permissions.Add("Delete User");
            }

            if(((int)enPermissions.ListUsers&Permissions)==(int)enPermissions.ListUsers)
            {
                permissions.Add("List User");
            }

            return permissions;
        }
        //public static bool ChangePaasword(int ?UserID,string Password)
        //{
        //    return clsUsersData.ChangePassword(UserID,Password);    
        //}
        public static int Count() => clsUsersData.Count();

    }
}
