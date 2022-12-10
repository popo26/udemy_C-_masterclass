using System;
using System.Collections.Generic;

namespace _128_polymorphic_parameters
{
    class Program
    {
        // Create a base class Car with two properties HP and Color
        // Create a Constructor setting those those two properties
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
        // Create a Repair Method which writes "Car was repaired" onto the console
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
        // called Model. Also a private member called brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDeails() and Repair in them as well. Adjust those methods accordingly.

        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z23");
            Car audiA3 = new Audi(100, "green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            Console.ReadKey();
        }
    }
}
