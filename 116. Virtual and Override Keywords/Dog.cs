using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _116._Virtual_and_Override_Keywords
{
    internal class Dog :Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string Name, int Age) :base(Name, Age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public void MakeSound()
        {
            Console.WriteLine("wuuuf wuuf");
        }

        public void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
