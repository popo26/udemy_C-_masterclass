using System;

namespace _92_jagged_arrays
{
    internal class Program
    {
        //Create a jogged array, which contains 3 "friends arrays", in which two family members should be stored
        //Introduce family members from different families to each other via console (three introductions)
        static void Main(string[] args)
        {
            string[][] threeFamilies = new string[][]
                {
                    new string[] {"Tom", "Tim"},
                    new string[] {"Lucy", "Pusy"},
                    new string[] {"Jim", "Jam"}
                };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", threeFamilies[0][0], threeFamilies[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", threeFamilies[0][1], threeFamilies[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", threeFamilies[0][1], threeFamilies[2][1]);
            Console.ReadKey();
        }
    }
}
