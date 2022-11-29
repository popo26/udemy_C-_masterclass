/*
 #########################################

Please, avoid changing the source code for the exercise!

#########################################

Write two new methods:

LowUpper method will take a string as input, create lower- and uppercase copies, and return the result of their join.

Example:

"lol" string will produse "lolLOL".
 */

using System;

namespace _42_Test_Your_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static string LowUpper(string s) {
            return s.ToLower() + s.ToUpper();
        }

        public static void Count(string s) {
            Console.WriteLine("The amount of character is {0}.", s.Length);
        }

        public static void Run() {
            string s = "HeY ThErE!";

            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }
    }
}



