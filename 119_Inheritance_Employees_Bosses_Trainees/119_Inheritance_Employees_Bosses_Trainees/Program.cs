using System;

namespace _119_Inheritance_Employees_Bosses_Trainees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Oakenfull", "Ramon", 10000);
            employee1.Work();
            employee1.Pause();
            

            Boss boss = new Boss("Ferrari", "Boss", "Big", 900000);
            boss.Lead();

            Trainee trainee = new Trainee(32, 8, "Morikawa", "Coco", 10000);
            trainee.Learn();
            trainee.Work();
            Console.ReadKey();
        }
    }
}
