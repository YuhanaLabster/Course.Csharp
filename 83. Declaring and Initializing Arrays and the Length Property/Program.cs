using System;

namespace _83._Declaring_and_Initializing_Arrays_and_the_Length_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 25;
            grades[2] = 19;
            grades[3] = 30;
            grades[4] = 40;

            Console.WriteLine($"element value from index number 3 is {grades[3]}");
            

        }
    }
}
