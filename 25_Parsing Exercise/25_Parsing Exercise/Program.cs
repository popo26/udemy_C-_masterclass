/*
  Parse the string variables from below into the correct datatypes:

public static void Main(string[] args)
{   
   string stringForFloat = "0.85"; // datatype should be float
   string stringForInt = "12345"; // datatype should be int
} 

Questions for this assignment
Share your solution (paste code):
 */



using System;

namespace _25_Parsing_Exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float myFloat = float.Parse(stringForFloat);
            int myInt = int.Parse(stringForInt);

            Console.WriteLine(myFloat);
            Console.WriteLine(myInt);
            Console.Read();
        }

    }
}
