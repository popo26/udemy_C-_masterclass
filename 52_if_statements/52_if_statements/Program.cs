//Challenge - If Statements
//Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, wenn login in (so the same ones that he used when registering).
//As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
//User If statements and User Input and Methods to solve the challenge.

using System;

namespace _52_if_statements
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        public static void Login()
        {
            Console.WriteLine("Enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login successfull");
                }
                else
                {
                    Console.WriteLine("Login failed.");
                }
            }
            else {
                Console.WriteLine("Wrong username.");
            }
        }
        public static void Register()
        {
            Console.WriteLine("What's your username");
            username = Console.ReadLine();
            Console.WriteLine("What's your password");
            password = Console.ReadLine();

            Console.WriteLine("Registration completed");
        }
    }
}
