using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134._Abstract_and_as_and_is_Keyword_Polymorphism
{
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a from Abstract Class {Name}");
        }

        public abstract double Volume();
    
    }
}
