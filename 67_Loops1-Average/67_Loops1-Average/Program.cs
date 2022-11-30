/*
 * Challenge - Loops 1 - Average
Imagine you are a developer and get a job in which you need to create a program for a teacher. He needs a program written in c# that calculates the average score of his students. So he wants to be able to enter each score individually and then get the final average score once he enters -1.
So the tool should check if the entry is a number and should add that to the sum. Finally once he is done entering scores, the program should write onto the console what the average score is.
The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
Test your program thoroughly.
 */

using System;

namespace _67_Loops1_Average
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            //int counter = 0;
            //int totalScore = 0;
            //string input = "";
            //int IntScore;

            //while (true) {
               
            //    Console.WriteLine("whats the score: ");
            //    input = Console.ReadLine();
            //    bool stringParse = int.TryParse(input, out IntScore);

            //    if (stringParse)
            //    {
            //        counter++;
            //        totalScore += IntScore;
            //        double average = (double)totalScore / (double)counter;
            //        Console.WriteLine("{0} people. The average score is {1}", counter, average);

            //    }
            //    if (input == "D")
            //    {
            //        Console.WriteLine("Stopping");
            //        break;
            //    }
            //}

            int counter = 0;
            int scoreInt;
            int total = 0;

           
            while (true) 
            {
                Console.WriteLine("Enter C to calculate average.");
                Console.WriteLine("Enter the score between 1 and 20: ");
                string input = Console.ReadLine();


                if (input == "C")
                {
                    double average = (double)total / (double)counter;
                    Console.WriteLine("********************************************************");
                    Console.WriteLine("For {0} students, average score is {1}\n", counter, average);
                    Console.WriteLine("********************************************************");
                    break;
                }
                else if (int.TryParse(input, out scoreInt) && scoreInt < 0 || scoreInt > 20)
                {
                    Console.WriteLine("invalid score. Should be between 1 and 20");
                    Console.WriteLine("Current total: {0}\n", total);
                    continue;
                }
                else if (int.TryParse(input, out scoreInt) && scoreInt > 0 && scoreInt < 21)
                {
                    total += scoreInt;
                    Console.WriteLine("Current total: {0}\n", total);
                    
                }
                else
                {
                    Console.WriteLine("Invalid entry\n");
                    continue;
                }
                counter++;
            }
        }
    }
}
