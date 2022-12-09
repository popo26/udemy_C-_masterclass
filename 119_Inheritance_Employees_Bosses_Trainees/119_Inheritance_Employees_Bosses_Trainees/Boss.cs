using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119_Inheritance_Employees_Bosses_Trainees
{
    class Boss:Employee
    {
        private string CompanyCar { get; set; }

        public Boss(string companyCar, string name, string firstName, int salary):base(name,firstName,salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I am Leading.");
        }
    }

   
}
