using System;

namespace _91._Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* index                            0   1    2    3
             * normal array of type int     : [15],[21],[23],[13]
             * 
             * index                                      0                      1                     3
             * jagged array of type int     : [array1([15],[13],[5])],[array2([7],[8],[2])],[array3([2],[4],[1])]
             * 
             */


            // declare jaggedArray
            int[][] jaggedArray = new int[3][];


            //we can add value into array by this way 
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            // or we can add value right away
            jaggedArray[0] = new int[] { 2, 3, 4, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // and here's the alternative way 
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 4, 5, 7, 11 },
                new int[] { 8, 9, 3 }
            };

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine($" element {i}");
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine($" inner loop {jaggedArray2[i][j]}");
                }
            }

        }

    }
}
