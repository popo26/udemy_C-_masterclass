/*
 CHALLENGE - Create an array of happiness in the main method and assign 5 values to it.
Create a method "SunIsShining", which has an array of type int as its parameter.
This method should increase the argument given by 2, for each entry.
Call this method in the main method and use "happiness" as the argument.
Create a foreach loop in the main method to write all values onto the console.
 */

using System;

namespace _93_using_arrays_as_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] happinessValues = new int[] { 1, 2, 3, 4, 5 };

            SunIsShining(happinessValues);

            foreach (int item in happinessValues)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

                
        }

        public static void SunIsShining(int[] happiness)
        {
            for (int i = 0; i < happiness.Length; i++)
                happiness[i] += 2;
            
        }
    }
}
