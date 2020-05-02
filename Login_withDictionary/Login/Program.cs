using Login.Models;
using System;
using System.Collections.Generic;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOMEWORK LOGIN with Dictionary");

            User AddingUser = new User();
            AddingUser.NameAndPass.Add("admin@gmail.com", "P@ssword167");


            while (true)
            {
                Console.WriteLine("Press 1 for Register or 2 for Login");
                var userChoices = Console.ReadLine();
                int convetedNumber = Convert.ToInt32(userChoices);                   

                switch (convetedNumber)
                {
                    case 1:

                        Console.WriteLine("Enter username with the following format: admin@admin.com");
                        Console.WriteLine("Username must be up to 30 characters");

                        string usernameInput = Console.ReadLine();
                        string checkCOM = usernameInput.Substring(usernameInput.Length - 4);

                        if (usernameInput.ToLower().Contains("@") && usernameInput.ToLower().Contains(".")
                            && checkCOM.ToLower() == ".com" && usernameInput.Length < 30)
                        {
                 
                            Console.WriteLine("Enter your password");
                            Console.WriteLine("Password must contain at least 10 characters including: small letter, big letter, number and special character");
                            
                            string password = Console.ReadLine();
                            var sampleRegex = new System.Text.RegularExpressions.Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{10,15}$");
                            bool isStrongPassword = sampleRegex.IsMatch(password);
                           
                            if (isStrongPassword)
                            {
                                AddingUser.NameAndPass.Add(usernameInput, password);

                                Console.WriteLine("You have registered successfully");                        
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have entered invalid password");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong format");
                        }

                        break;

                    case 2:

                        while (true)
                        {
                            Console.WriteLine("Enter your username");
                            var username = Console.ReadLine();
                            Console.WriteLine("Enter password");
                            var password = Console.ReadLine();
                            bool registration = false;

                            foreach (var item in AddingUser.NameAndPass)
                            {
                                if (username == item.Key && password == item.Value)
                                {
                                    registration = true;
                                    break;
                                }
                            }
                            if(registration == true)
                            {
                                Console.WriteLine("You are logged in successfully");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect username or password");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
