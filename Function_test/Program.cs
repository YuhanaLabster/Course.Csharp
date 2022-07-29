using System;

namespace Function_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(tambah(kali(10,5),bagi(100,50)));
            Console.Read();
        }

        public static int tambah(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int kali(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int bagi(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
