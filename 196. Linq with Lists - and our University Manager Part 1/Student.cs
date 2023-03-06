using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _196._Linq_with_Lists___and_our_University_Manager_Part_1
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
