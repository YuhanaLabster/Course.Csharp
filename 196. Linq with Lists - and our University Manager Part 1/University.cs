﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _196._Linq_with_Lists___and_our_University_Manager_Part_1
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
