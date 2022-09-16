using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120._Inheritance_Challenge_2___Employees__Bosses_and_Trainees_Solution
{
    internal class Boss:Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string CompanyCar, string name, string firstName, int salary):base(name, firstName, salary)
        {
            this.CompanyCar = CompanyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"am the boss{Name} ");
        }
    }
} 
