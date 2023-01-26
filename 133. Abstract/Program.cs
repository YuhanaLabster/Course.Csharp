using System;

namespace _133._Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(5) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"name {shape.Name}, volume {shape.Volume()}");
            }
        }
    }
}
