using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using SchoolBusiness;
using Microsoft.Win32;
namespace School_Project
{
    public static  class clsGlobal
    {

        public static clsUsers CurrentUser;


        public static string ComputeHash(string Input)
        {


            // Compute the hash value from the UTF-8 encoded input string
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Input));
               


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

        }
        public static string Encrypt(string plainText, string key = "02D2E9-830F-4B31-89C6-237F4131BC")
        {
            if (plainText == null)
            {
                return null;
            }

            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }


                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Clinic Project";

            string UsernameName = "Username";
            string UsernameData = Username;

            string PasswordName = "Password";
            string PasswordData = Password;

            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, UsernameName, UsernameData, RegistryValueKind.String);
                Registry.SetValue(keyPath, PasswordName, PasswordData, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                //  clsLog loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                // loggerToEventViewer.LogError("General Exception", ex);
                return false;
            }

        }






    }











}

