using System;

namespace _63_for_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            forloop();
        }
        static void forloop()
        {
            for (int counter = 0; counter < 100; counter++)
            {
                Console.WriteLine("loops number {0}", counter);
            }
        }
        static void forloopODD()
        {
            for (int counter = 1; counter < 20; counter+=2)
            {
                Console.WriteLine("odd numnber {0}", counter);
            }
        }

        static void OddFinder()
        {
            Console.WriteLine("enter your number, i fill the odd number");
            string userInput = Console.ReadLine();
            int parsedInput;
            if (int.TryParse(userInput, out parsedInput))
            {
                for (int i = 0; i < parsedInput; i++)
                {
                    if (i % 3 == 0);
                    Console.WriteLine("{i} is odd number",i);
                }

            }   

            

        }
    }
}
