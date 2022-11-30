﻿/*
 * Enhanced If Statements - Ternary Operator - Challenge
We have studied ternary operators and their usage so here is a small challenge for you. Let's create a small application that takes a temperature value as input and checks if the input is an integer or not.

If the input value is not an integer value, it should print to the console "Not a valid Temperature".

And if the input value is the valid integer then it should work as mentioned below.

If input temperature value is <=15 it should write "it is too cold here" to the console.

If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.

If the input temperature value is > 28 it should write "it is hot here" to the console.

Make sure to use ternary operators and not if statements to check for the three conditions, however you can use if statement for the other conditions like to check if the entered value is a valid integer or not.


 */


using System;

namespace _58__ENhanced_If_Statements_Ternary_Operator
{
    
    internal class Program
    {
        static int tempInt;
        static void Main(string[] args)
        {
            int inputTemp = 0;
            Console.WriteLine("Whats the temp?");
            string input = Console.ReadLine();
            bool validInt = int.TryParse(input, out inputTemp);

            if (validInt)
            {
                string stateOfMatter = tempInt <= 15 ? "this too cold" 
                    : tempInt >= 16 && tempInt <= 28 ? "its ok" 
                    : tempInt > 28 ? "it's too hot" : "";

                Console.WriteLine("the current temp is {0}. {1}", tempInt, stateOfMatter);
               
            }
            else {
                Console.WriteLine("Not valid temp.");
            }
            Console.ReadKey();
        }
        
    }
}
