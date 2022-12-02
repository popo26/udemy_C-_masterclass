using System;
using System.Collections.Generic;

namespace _105_stack__and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("The top value {0} was removed from the stack", stack.Pop());
                Console.WriteLine("Current stack count is {0}", stack.Count);
            }

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Stack<int> myStack = new Stack<int>();


            Console.WriteLine("the numbers in the arrays are: ");
            
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
                myStack.Push(num);
                
            }

            //numbers in reverse
            Console.WriteLine("");
            Console.WriteLine("The numbers in reverse : ");
            while (myStack.Count > 0)
            {
                int num = myStack.Pop();
                Console.Write(num + " ");
            }
        }
    }
}
