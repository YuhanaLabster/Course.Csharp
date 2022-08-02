using System;

namespace Coding_Exercise_7_Arrays_for_and_foreach_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();

        }
        public static void GetOdd(int[] Array)
        {
            foreach (int i in Array)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} is odd number");
                }
            }
        }
        public static void GetEven(int[] Array)
        {
            foreach (int i in Array)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is Even number");
                }
            }
        }
        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);

        }

    }
}
