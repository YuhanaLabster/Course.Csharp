using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122._Creating_And_Using_Your_Own_Interfaces
{
    internal class Chair:Furnitures,IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine($"Playing {DestructionSound} ");
            Console.WriteLine($"Spawning chair parts");

        }

    }
}
