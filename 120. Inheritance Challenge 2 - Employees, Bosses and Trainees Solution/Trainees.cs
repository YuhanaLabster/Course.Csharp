using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120._Inheritance_Challenge_2___Employees__Bosses_and_Trainees_Solution
{
    internal class Trainees:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainees(string name, string firstName, int salary, int workingHours, int schoolHours) :base(name,firstName,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"my name is {Name}, paid for {Salary} and am learning for {SchoolHours}");
        }

        public void Work()
        {
            Console.WriteLine($"my name is {Name}, paid for {Salary} and am work for {WorkingHours}");
        }
    }
}
