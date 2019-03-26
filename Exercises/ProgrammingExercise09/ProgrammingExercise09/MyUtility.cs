using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace ProgrammingExercise09
{
    public class MyUtility
    {
        //public static Dictionary<string, byte[]> Diction;
        //public static Dictionary<string, byte[]> Locker = EnterUserInfo();//Takes user name and pass (assign sha-256) 
        ////ValueTuple<String, byte[]> UserAuth = ReturnuserInfo(Locker);//Takes a user name and authenicate user Identify (user is in system)
        //public static Dictionary<string, byte[]> Locker2 = ReturnUserInfo(Locker);
        ////public static PrintUI();
        ////ReturnAllUser();
        static Dictionary<string, string> Locker = new Dictionary<string, string>();

        internal void ReturnUserInfo()
        {
            Console.Write("Enter a username:");
            string UserName = Console.ReadLine();
            //Console.WriteLine();
            Console.Write("Enter your password:");
            string UserPass = Console.ReadLine();
            byte[] A = Encoding.Unicode.GetBytes(UserPass);
            SHA256 EncryptPass = SHA256.Create();
            byte[] B = EncryptPass.ComputeHash(A);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < B.Length; i++)
            {
                result.Append(B[i].ToString("X2"));
            }
            UserPass = result.ToString();
            if (Locker.ContainsKey(UserName) && Locker.ContainsValue(UserPass))
            {
                Console.WriteLine("Username: {0} Password:{1}", UserName, UserPass);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Username and Password not found.");
                Console.WriteLine();
            }

            //foreach (KeyValuePair<string, string> key in Locker)
            //{
            //    if (UserName == key.Key)
            //    {
            //        if (UserPass == key.Value)
            //        {
            //            Console.WriteLine("Username: {0} Password:{1}", key.Key, key.Value);
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Password incorrect");
            //            Console.WriteLine();
            //        }
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Username not found.");
            //        Console.WriteLine();
            //    }
            //}
        }

        internal void EnterUserInfo()
        {
            Console.Write("Enter your username:");
            string UserName = Console.ReadLine();
            //Console.WriteLine();
            Console.Write("Enter your Password:");
            string UserPass = Console.ReadLine();
            byte[] A = Encoding.Unicode.GetBytes(UserPass);
            SHA256 EncryptPass = SHA256.Create();
            byte[] B = EncryptPass.ComputeHash(A);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < B.Length; i++)
            {
                result.Append(B[i].ToString("X2"));
            }
            UserPass = result.ToString();
            try
            {
                Locker.Add(UserName, UserPass);
                Console.WriteLine();
            }
            catch(Exception)
            {
            Console.WriteLine("username and password taken");
                Console.WriteLine();
            }

        }

        internal void PrintContents()
        {
            foreach (KeyValuePair<string, string> s in Locker)
            {
                Console.WriteLine("Username: {0} Password:{1}", s.Key, s.Value);
            }
        }
    }
}
