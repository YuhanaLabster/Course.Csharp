using System;

namespace _76._Properties_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLength(4);
            box.SetHeight(5);
            box.SetWidth(10);
            Console.WriteLine(box.GetVolume());
            Console.Read();
        }
    }
}
