using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128._Polymorphic_Parameters
{
    internal class Car
    {
        // properties
        public int HP { get; set; }
        public string Color { get; set; }

        // constructor
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP is {HP} and its colour is {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
