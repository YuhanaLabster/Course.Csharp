using System;
using System.Collections.Generic;
using System.Linq;

namespace _195._Linq_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11 };
            OddNumbers(numbers);
        }

        static void OddNumbers(int[] numbers)
        {
            // find the odd numbers then print it out
            Console.WriteLine("Odd Numbers : ");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 !=0 select number;
            Console.WriteLine(oddNumbers);
            foreach (int item in oddNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
