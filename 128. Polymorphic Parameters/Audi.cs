﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128._Polymorphic_Parameters
{
    internal class Audi:Car
    {
        private string brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"Brand {brand}, HP is {HP} and its colour is {Color} : called from brand class");
        }

        public override void Repair()
        {
            Console.WriteLine($"The Audi {Model} was repaired");
        }
    }
}
