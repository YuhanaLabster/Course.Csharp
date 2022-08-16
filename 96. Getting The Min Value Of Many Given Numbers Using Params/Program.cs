using System;

namespace _96._Getting_The_Min_Value_Of_Many_Given_Numbers_Using_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimumValue = MinValueChecker(1,2,4,5,9,8,4,8);
            Console.WriteLine(minimumValue);
        }
        public static int MinValueChecker(params int[] numbers)
        {
            int min = int.MaxValue; //this will compare to the maximum number from int list which us 2,147,483,647
            foreach (int number in numbers)
            {
                if  (number < min) // if element inside the arguments given is lower than the 2,147,483,647
                {
                    min = number; //it will replace the 2,147,483,647 with that element.
                }
            }
            return min;
        }
    }
}
