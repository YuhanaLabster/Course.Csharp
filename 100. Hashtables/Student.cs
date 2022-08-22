using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100._Hashtables
{
    internal class Student
    {
        public int Id { get; set; } //property called Id
        public string name { get; set; } //property called name
        public float GPA { get; set; } //property called GPA

        //simple constractor
        public Student (int Id, string name, float GPA)
        {
            this.Id = Id;
            this.name = name;
            this. GPA = GPA;
        }
    }
}
