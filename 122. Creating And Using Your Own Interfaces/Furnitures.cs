using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122._Creating_And_Using_Your_Own_Interfaces
{
    internal class Furnitures
    {
        public string Color { get; set; }
        public string Material { get; set; }
   
        public Furniture()
        {
            Color = "white";
            Material = "Wood";
        }

        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }

}
