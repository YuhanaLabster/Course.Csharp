using System;

namespace FizzBuzz
{
    internal class Program
    {
        static int fizzbuzz;
        
        static void Main(string[] args)
        {
            //FizzBuzz();
            FizzBuzzSwitch();
        }
        static void FizzBuzz()
        {

           for (int i = 1; i < 100; i++)
            {
                if (i %3 == 0 && i %5 == 0)
                {
                    Console.WriteLine("fizzBuzz");
                    fizzbuzz =+ i;
                }
                else if (i %3 == 0)
                {
                    Console.WriteLine($"{i} fizz");
                }
                else if (i %5 == 0)
                {
                    Console.WriteLine($"{i} buzz");
                }
                else
                {
                    Console.WriteLine($"just number {i}");
                }
            }
                Console.WriteLine($"fizzbuzz appear on {fizzbuzz}");
        }

        static void FizzBuzzSwitch()
        {
            for (int i = 1; i < 100; i++)
            {
                switch (i)
                {
                    case 3:
                        Console.WriteLine("fizz");
                        break;

                    case 5:
                        Console.WriteLine("buzz");
                        break;

                    default: Console.WriteLine("default");
                        break;
                }

            }
        }
    }
}
