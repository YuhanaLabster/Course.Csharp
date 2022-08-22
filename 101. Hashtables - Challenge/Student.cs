using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101._Hashtables___Challenge
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Grade { get; set; }

        public Student(int Id, string Name, float Grade)
        {
            this.Id = Id;
            this.Name = Name;
            this.Grade = Grade;
        }

    }


}
