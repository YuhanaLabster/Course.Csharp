using System;

namespace _88._Nested_For_Loops_And_2D_Arrays
{
    internal class Program
    {
        static int[,] matrix = 
            { 
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };
        static void Main(string[] args)
        {
            foreach (int x in matrix) //foreach not the best approach to iterate item with conditions, we should use nested for loop
            {
                Console.Write($"{x} this from foreach");
            }
            Console.WriteLine('\n');
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    Console.WriteLine($"{matrix[x,i]} this from nested loop");
                }  
            }   

        }
    }
}
