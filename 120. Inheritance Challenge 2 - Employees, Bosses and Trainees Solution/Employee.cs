using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120._Inheritance_Challenge_2___Employees__Bosses_and_Trainees_Solution
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        public Employee()
        {
            Name = "Yuhana Atmaja";
            FirstName = "Yuhana";
            Salary = 1000;
        }

        public void Work()
        {
            Console.WriteLine("am working");
        }

        public void Pause()
        {
            Console.WriteLine("am having a break");
        }
    }
}
