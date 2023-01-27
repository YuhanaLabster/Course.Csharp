using System;

namespace _134._Abstract_and_as_and_is_Keyword_Polymorphism
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

                Cube IceCube = shape as Cube;

                if (IceCube is Cube) 
                {
                    Console.WriteLine("this is cube");
                }
                else
                {
                    Console.WriteLine("this not cube");
                }

                object cube1 = new Cube(5);
                Cube cube2 = (Cube)cube1;
                Console.WriteLine($"name is {cube2.Name} and Volume {cube2.Volume()}");


            }
        }
    }
}
