using System;

namespace _45._Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_1 = 20;
            int number_2 = 200;
            int number_3;
            bool isPositive = true;
            number_3 = -number_1;
            Console.WriteLine("number_3 will have the same value as number_1 but in negative {0} ", number_3);
            Console.WriteLine(!isPositive);
            int number_4 = 9;
            int number_5 = 99;
            number_4++;
            Console.WriteLine(number_4);
            Console.WriteLine(++number_1);
            Console.WriteLine("=======================================");
            int numberToIncrementafter = 5;
            Console.WriteLine(numberToIncrementafter);
            Console.WriteLine(numberToIncrementafter ++); //it means the next number will be added by 1
            Console.WriteLine(numberToIncrementafter);

            /// result : 
            /// 5
            /// 5
            /// 6
            Console.WriteLine("#######################################");

            int numberToIncrementBefore = 5;
            Console.WriteLine(numberToIncrementBefore);
            Console.WriteLine(++ numberToIncrementBefore); //it means at this line and the next line will be added by 1
            Console.WriteLine(numberToIncrementBefore);
            /// result : 
            /// 5
            /// 6
            /// 6

            Console.WriteLine("#######################################");
            int num1 = 10;
            int num2 = 5;
            bool isLower;
            isLower = num1 < num2; // 10 is not lower than 5
            Console.WriteLine(isLower); //the result is false

            Console.WriteLine("#######################################");
            bool isTrueFirst = true;
            bool isTrueSecond = true;
            bool allTrue = isTrueFirst && isTrueSecond;
            Console.WriteLine(allTrue);

            Console.WriteLine("#######################################");
            int num_1 = 10;
            int num_2 = 9;
            bool boolReturn = num_1 > num_2;
            bool toCompare = false;
            bool compareFromReturnAndVariable = boolReturn && toCompare;
            Console.WriteLine(compareFromReturnAndVariable);

            Console.WriteLine("#######################################");
            bool isTrue_first = false;
            bool isTrue_second = true;
            bool orTrue = isTrue_first || isTrue_second;
            Console.WriteLine(orTrue);



        }
    }
}
