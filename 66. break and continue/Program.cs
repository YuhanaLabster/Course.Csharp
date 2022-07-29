using System;

namespace _66._break_and_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OddAndEvenChecker();
        }

        static void OddAndEvenChecker()
        {
            Console.WriteLine("input the maximum number");
            string userInput = Console.ReadLine();
            int parsedToInt = int.Parse(userInput);
            for (int i = 0; i < parsedToInt; i++)
            {
                if (i %2 == 0)
                {
                    Console.WriteLine("{0} is even number",i);
                    
                }
                Console.WriteLine("{0} is odd number",i);
            }
        }
    }
}
