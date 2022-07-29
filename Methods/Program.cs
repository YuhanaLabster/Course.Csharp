using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            method_lagi();
        }

        public static void method_lagi()
        {
            Console.WriteLine("masukin namamu \n");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.Read();
        }

    }
}
