using System;

namespace _149._Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we can set variable to Null by adding "?"
            int? empty = null;
            double? empty2 = null;
            double? empty3 = new double?();


            // we can assign number if the default is null by two ways : 
            // 1. Normal mode
            double? num1 = 69.69;
            double? num2= null;
            double num3; ;
            if (num1 == null)
            {
                num3 = 0.0;
            }
            else
            {
                num3 = (double)num1;
            }

            Console.WriteLine($"from normal mode {num3}");

            //2. null-coalescing operator
            num3 = num1 ?? 70.70;
            num3 = num2 ?? 70.70;
            Console.WriteLine();
            Console.WriteLine($"from null-coalescing operator {num3}");

        }
    }
}
