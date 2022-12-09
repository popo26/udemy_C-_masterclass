using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119_Inheritance_Employees_Bosses_Trainees
{
    class Trainee : Employee
    {
        private int WorkingHours { get; set; }
        private int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours,
            string name, string firstName, int salary) : base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Im learning for {0} hours", SchoolHours);
        }
        public new void Work()
        {
            Console.WriteLine("Im working for {0} hours", WorkingHours);
        }




    }
}
