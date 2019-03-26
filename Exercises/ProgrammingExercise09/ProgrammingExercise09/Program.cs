using System;
using System.Collections.Generic;


namespace ProgrammingExercise09
{
    class Program
    {
        static void Main(string[] args)
        {

            MyUtility myUtility = new MyUtility();
            int choice = PrintUI();

            while (choice != 0)
            {
                if (choice == 1)
                {
                    myUtility.EnterUserInfo();
                    choice = PrintUI();
                }
                else if (choice == 2)
                {
                    myUtility.ReturnUserInfo();
                    choice = PrintUI();
                }
                else if (choice == 3)
                {
                    myUtility.PrintContents();
                    choice = PrintUI();
                }
                //else
                //    Console.WriteLine("Please choose a valid option");
                //    choice = PrintUI();
            }
        }

        private static int PrintUI()
        {
            Console.WriteLine("To enter a username and password in the database press 1");
            Console.WriteLine("To authenticate a user Press 2");
            Console.WriteLine("To view all usernames and passwords press 3 ");
            Console.WriteLine("To Exit the program Enter 0");
            string strChoice = Console.ReadLine();
            int choice = Convert.ToInt16(strChoice);
            return choice;
            
        }
    }
}
