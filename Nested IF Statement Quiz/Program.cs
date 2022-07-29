using System;

namespace Nested_IF_Statement_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OddOrEvenNumberChecker();
        }

        static void OddOrEvenNumberChecker()
        {
            bool repeat = true;
            Console.WriteLine("Please Input Your Number");
            while (repeat) {
                string NumberEntered = Console.ReadLine();
                int toInt = int.Parse(NumberEntered);
                if (toInt % 3 == 0 )
                {
                    Console.WriteLine("Divisible by 3");
                }
                else if (toInt % 7 == 0)
                {
                    Console.WriteLine("Divisible by 7");
                }
                else
                {
                    if (toInt % 2 == 0)
                    {
                        Console.WriteLine("even number");
                    }
                else { Console.WriteLine("odd number"); }
                } 
                
            }


        }
    }
}
