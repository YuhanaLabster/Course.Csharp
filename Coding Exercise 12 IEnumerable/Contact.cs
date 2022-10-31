using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_12_IEnumerable
{
    internal class Contact
    {
        // solution
        public string Name { get; set; }
        public string Phone { get; set; }

        public void Call()
        {
            System.Console.WriteLine("Calling to {0}. Phone number is {1}", Name, Phone);
        }

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        // solution
    }
}
