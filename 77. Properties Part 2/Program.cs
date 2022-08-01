using System;

namespace _77._Properties_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box boxes = new Box(10, 12, 3);
            Console.WriteLine(boxes.Width);
            Console.WriteLine(boxes.Height);
            Console.WriteLine(boxes.Width);
            Console.WriteLine(boxes.Volume);
        }
    }
}
