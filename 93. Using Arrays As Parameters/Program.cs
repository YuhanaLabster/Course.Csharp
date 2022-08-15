using System;

namespace _93._Using_Arrays_As_Parameters
{
    internal class Program
    {
        /* Arrays are a reference type in C#. This means that each time an array is passed as an argument to any function,
         * the reference (or pointer) to the argument is passed to the function.
         * thus any modifications you make to the array in the function are made in the actual argument also
         */
        public static int [] studentGrades = new int[] { 92, 50, 23, 45, 87, 77, 21 };
        public static int[] numbers = { 2, 3, 4, 5, 6 };
        
        static void Main(string[] args)
        {

            //StudentAverages();
            foreach (int item in numbers)
            {
                Console.WriteLine($"item before IncreaseNumber method called : {item}");
            }
            IncreaseNumber(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine($"item after IncreaseNumber method called : {item}");
            }
        }

        static void StudentAverages()
        {
            double averageResult = GetAverage(studentGrades);
            foreach (var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine($"the average is {averageResult}");

        }
        static double GetAverage (int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average ;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void IncreaseNumber(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] += 2;
            }   
        }
    }
}
