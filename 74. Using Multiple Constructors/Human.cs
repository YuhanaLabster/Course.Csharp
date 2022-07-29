using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74._Using_Multiple_Constructors
{
    internal class Human
    {
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;


        //Accept 4 arguments (firstname, lastname, eyecolor, age)
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //Accept 3 arguments (firstname, lastname, eyecolor)
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        //Accept 2 arguments (firstname, lastname)
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        //Accept 1 argument (firstname)
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        //Without Argument ()
        public Human()
        {
            Console.WriteLine("default object created, no argument");
        }

        public void Introduce()
        {
            if (firstName != null && lastName != null && eyeColor != null && age !=0)
            {
                Console.WriteLine($"hello {firstName} {lastName}, your eyes color is {eyeColor} and your age is {age}");
            }
            else if (firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine($"hello {firstName} {lastName}, your eyes color is {eyeColor}");
            }
            else if (firstName != null && lastName != null)
            {
                Console.WriteLine($"hello {firstName} {lastName}");
            }
            else if (firstName != null)
            {
                Console.WriteLine($"hello {firstName}");
            }
            else
            {
                Console.WriteLine("no agrs");
            }
        }
    }
}
