using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _197._Sorting_and_Filtering_with_Linq
{
    internal class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name} University, ID : {Id}");
        }
    }
}
