using System;

namespace Coding_Exercise_4__Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.Read();
        }

        public static void ForLoop()
        {
            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine("for loop start from {0}",i);
            }

        }
        public static void WhileLoop()
        {
            int i = 3;
            while (i > -4)
            {
                Console.WriteLine("for while start from {0}", i);
                i--;
            }
        }

        public static void Run()
        {
            ForLoop();
            WhileLoop();
        }
    }
}
