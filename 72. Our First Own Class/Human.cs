using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72._Our_First_Own_Class
{
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("Hi my name is {0} {1}",firstName,lastName);
        }


    }
}
