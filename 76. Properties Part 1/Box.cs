using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76._Properties_Part_1
{
    internal class Box
    {
        // member variable
        private int length;
        private int height;
        private int width;
        private int volume;

        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength ()
        {
            return this.length;
        }

        public void SetHeight (int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return this.height;
        }

        public void SetWidth (int width)
        {
            this.width = width;
        }

        public int GetWidth ()
        {
            return this.width;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"lenght is {length} and height is {height}, width is {width} and the volume is {volume = length*width*height}");
        }
    }
}
