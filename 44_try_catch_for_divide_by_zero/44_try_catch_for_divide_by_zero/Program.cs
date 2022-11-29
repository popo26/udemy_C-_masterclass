using System;

namespace _44_try_catch_for_divide_by_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
          
            int num1 = int.Parse(userInput);
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero");
            }
            finally { Console.WriteLine("This line is called anyway."); }
        }
    }
}
