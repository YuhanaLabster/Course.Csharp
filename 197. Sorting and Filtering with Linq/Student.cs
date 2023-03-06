using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _197._Sorting_and_Filtering_with_Linq
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int UniversityID { get; set; }

        public void Print()
        {
            Console.WriteLine($"ID\t: {Id}\nName\t: {Name}\nGender\t: {Gender}\nAge\t: {Age}\nUniId\t: {UniversityID}\n---------------------- ");
        }
    }
}
