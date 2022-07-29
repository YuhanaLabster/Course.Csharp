using System;

namespace Coding_Exercise_5_break_and_continue_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -10;
            while (true)
            {
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                else if (i >= 10)
                {
                    break;
                }
                Console.WriteLine(i++);
            }
        }

    }
}
