using System;

namespace _74._Using_Multiple_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human yuhana = new Human("Yuhana", "Atmaja", "brown", 32);
            yuhana.Introduce();
            Human bambang = new Human("bambang", "gentolet", "brown");
            bambang.Introduce();
            Human yanto = new Human("Yanto", "dimejo");
            yanto.Introduce();
            Human sukirman = new Human("sukirman");
            sukirman.Introduce();
            Human kosongan = new Human();
            kosongan.Introduce();
            Console.Read();
        }
    }
}
