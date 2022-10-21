using System;
using System.Collections.Generic;

namespace _125._IEnumerable_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a list of type List <int> initialized with some numbers
            List<int> numberList = new List<int>() { 8, 6, 2 };
            // an array of type int [] initialized with some numbers
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            Console.WriteLine("");
            CollectionSum(numberList);
            Console.WriteLine("");
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // sum variables to store the sum of the numbers in anyCollection
            int sum = 0;
            //for each number in the collection passed to this method
            foreach (int item in anyCollection)
            {
                sum += item;
            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}
