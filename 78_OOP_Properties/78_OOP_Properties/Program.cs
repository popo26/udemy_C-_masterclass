using System;

namespace _78_OOP_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(1,2,3);

            Console.WriteLine("This box's front surface is " + box.FrontSurface);
            Console.WriteLine("This box's volume is {0}", box.GetVolume());
        }
    }
}
