using System;

namespace _65._While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enterCounter();
            Counter();
        }
        static void WhileLoop()
        {
            int limiter = 0;
            while (limiter < 10)
            {
                Console.WriteLine("counter number {0}", limiter);
                limiter++;
            }
            Console.WriteLine("this is the end");
        }

        static void enterCounter()
        {
            Console.WriteLine("enter the limit");
            string limit = Console.ReadLine();
            int parsedLimit = int.Parse(limit);
            while (parsedLimit > 0)
            {
            Console.Write("enter number {0}", parsedLimit);
                Console.ReadLine();
                parsedLimit--;
            }
            if (parsedLimit > 1)
            {
            Console.WriteLine("you have clicked {0} times!",limit);
            }
            Console.WriteLine("you have clicked {0} time!", limit);

        }

        static void Counter()
        {
            int counter = 1;
            string EnteredText = "";
            Console.WriteLine("type any key to stop the program");
            while (EnteredText.Equals(""))
            {
                EnteredText = Console.ReadLine();
                Console.WriteLine("pressed {0} times",counter);
                counter++;
            }
            counter-=2;
            Console.WriteLine("total {0} times",counter);
        }
    }
}
