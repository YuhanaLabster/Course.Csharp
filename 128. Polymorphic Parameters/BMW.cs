using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128._Polymorphic_Parameters
{
    internal class BMW:Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"Brand {brand}, HP is {HP} and its colour is {Color} : called from brand class");
        }

        public override void Repair()
        {
            Console.WriteLine($"The BMW {Model} was repaired");
        }
    }
}
