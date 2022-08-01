using System;

namespace _78._Challenge___Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box boxes = new Box(4, 5, 6);
            Console.WriteLine($"the box Length is {boxes.Length}");
            Console.WriteLine($"the box Height is {boxes.Height}");
            Console.WriteLine($"the box Width is {boxes.Width}");
            Console.WriteLine($"the box Volume is {boxes.Volume}");
            Console.WriteLine($"the box Front Surface is {boxes.FrontSurface}");
        }
    }
}
