using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78._Challenge___Properties
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

        public int FrontSurface 
        {
            get { return Length * Width; }
        }

        public Box(int Length, int Height, int Width)
        {
            this.Length = Length;
            this.Height = Height;
            this.Width = Width;
        }
    }
}
