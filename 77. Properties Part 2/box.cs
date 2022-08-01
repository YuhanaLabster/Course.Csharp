using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77._Properties_Part_2
{
    internal class Box
    {
        public int Length { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int Volume
        {
            get { return this.Length * this.Height * this.Width; }
        } 

        public Box(int Length, int Height, int Width)
        {
            this.Length = Length;
            this.Height = Height;
            this.Width = Width;
        }
    }
}
