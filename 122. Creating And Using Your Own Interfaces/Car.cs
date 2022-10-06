using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122._Creating_And_Using_Your_Own_Interfaces
{
    internal class Car:Vehicle,IDestroyable
    {
        public string DestructionSound { get; set; }
        
        public List<IDestroyable> DestroableNearby;

        public Car(float speed, string color):base(speed, color)
        {
            DestructionSound = "CarExplosion.mp3";
            DestroableNearby = new List<IDestroyable>();
        }
        public void Destroy()
        {
            Console.WriteLine($"Playing destruction sound{DestructionSound}");
            Console.WriteLine("Fire started");
            foreach(IDestroyable destroyable in DestroableNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
