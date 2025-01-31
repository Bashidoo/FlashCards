﻿namespace GruppFlashCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

          




            var _library = new Library();   // Insert lists from Loaded SQL Data --Busher
            bool loggingIn = true;
            while (loggingIn)
            {

                string userEmail = Utility.GetValidatedStringInput("Please Enter your Email: ").Trim();
                string password = Utility.GetValidatedStringInput("Enter your password:").Trim();

                Users? LoggedInUser = _library.UserLogin(userEmail, password);

                if (LoggedInUser != null)
                {
                    loggingIn = false;
                    
                    Console.WriteLine($"Welcome: {LoggedInUser.Email}");
                  

                }
                else
                {
                    Console.WriteLine("Logging in failed.");
                }

            }

            // SQL Integration! -------------
        }
    }
}
