using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _133._Abstract
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere (double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            double volume = (float)(4.0 / 3 * Math.PI * Radius * Radius *Radius);
            return volume;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"This is a from Derived Class {Volume()}");
        }
    }
}
