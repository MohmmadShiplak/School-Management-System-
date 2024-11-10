using SchoolDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusiness
{
    public class clsPerson
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enGender { Male = 0, Female = 1 };

        public int ? PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public short  Gendor { get; set; }


        public DateTime  DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public clsUsers UserInfo;



        public bool IsUser => clsUsers.IsUserExist(PersonID);
       

        public bool IsStudent
        {
            get { return clsStudents.IsStudent(PersonID); }
        }


       public bool IsActiveStudent
        {
            get { return clsStudents.IsActiveStudent(PersonID); }
        }



        public bool IsTeacher => clsTeachersData.IsTeacher(PersonID);

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public clsPerson()

        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
     
            Mode = enMode.AddNew;
        }

        public  clsPerson(int ? PersonID, string FirstName, string SecondName, string ThirdName,
           string LastName
            , DateTime DateOfBirth, short  Gendor,
            string Address, string Phone, string Email
   )

        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        //    this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
        //    this.UserInfo = clsUsers.Find(PersonID);
         
            Mode = enMode.Update;
        }
       private bool _AddNewPerson()
        {

            this.PersonID = clsPersonData.AddNewPersons(
                this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.Gendor, this.DateOfBirth, this.Phone, this.Email, this.Address
                );

            return (this.PersonID.HasValue);
        }
        private bool _UpdatePerson()
        {

            return clsPersonData.UpdatePersons(this.PersonID, this.FirstName, this.SecondName, this.ThirdName
                , this.LastName, this.Gendor, this.DateOfBirth, this.Phone, this.Email, this.Address); 
             
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }
        public static clsPerson Find(int  ?PersonID)
        {

            string FirstName = null, SecondName = null, ThirdName = null, LastName =null,Address=null,Email=null,Phone=null;

            short   Gender = -1;

         DateTime DateOfBirth = DateTime.Now;


            if (clsPersonData.GetPersonsInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Phone, ref Email, ref Address))

                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email);
            else
                return null;


        }



    }
}
