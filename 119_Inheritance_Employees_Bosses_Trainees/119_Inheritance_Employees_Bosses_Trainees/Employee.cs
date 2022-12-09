using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119_Inheritance_Employees_Bosses_Trainees
{
    class Employee
    {
       
        private string Name { get; set; }
        private string FirstName { get; set; }
        private int Salary { get; set; }

        public Employee() 
        {
            Name = "Oakenfull";
            FirstName = "Ai";
            Salary = 50000;

        }

        public Employee(string name, string firstName, int salary) 
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("Im working");
        }

        public void Pause() 
        {
            Console.WriteLine("Im having a break");
        }

       

    }
}
