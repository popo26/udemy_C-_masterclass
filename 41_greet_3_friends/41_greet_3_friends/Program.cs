using System;

namespace _41_greet_3_friends
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Ramon";
            string friend2 = "Coco";
            string friend3 = "Ollie";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
        }
        public static void GreetFriend(string friend)
        {
            Console.WriteLine("Hi {0}, my friend!", friend);
        }
    }
}
