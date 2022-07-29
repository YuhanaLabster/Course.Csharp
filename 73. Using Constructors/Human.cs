using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73._Using_Constructors
{
    internal class Human
    {
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;

        //constructror
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"hello {firstName} {lastName}, your eyes color is {eyeColor}, and your age is {age}");
        }
    }
}
