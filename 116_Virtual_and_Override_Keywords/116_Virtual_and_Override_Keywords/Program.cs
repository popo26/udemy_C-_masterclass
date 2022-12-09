using System;

namespace _116_Virtual_and_Override_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sif", 15);
            Console.WriteLine($"{ dog.Name} is {dog.Age} year old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
