using System;

namespace _64._Do_While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LengtCheck();
        }
        static void DoWhileLoop()
        {
            int counter = 0;
            do
            {
                Console.WriteLine("this number {0}", counter);
                counter++;
            } while (counter < 10);
            Console.Read();
        }
        
        static void LengtCheck()
        {
            Console.WriteLine("input your text");
            string userInput = Console.ReadLine();
            Console.WriteLine("enter your limit");
            int MaxLenght = Console.ReadLine().Length;
            int Limiter = 1;
            do
            {
                Console.WriteLine("{0} repeat",userInput);
                Limiter++;
            }
            while (Limiter < MaxLenght);
        }

    }
}
