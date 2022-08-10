using System;

namespace _89._Nested_For_Loops_And_2D_Arrays___Two_Examples
{
    internal class Program
    {
        static int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                //for (int i = 0; i < matrix.GetLength(1); i++)
                //Console.Write(matrix[i,0]); // output : 1 4 7
                //Console.Write(matrix[i,1]); // output : 2 5 8
                //Console.Write(matrix[i,2]); // output : 3,6,9
                //Console.Write(matrix[0,i]); // output : 1 2 3
                //Console.Write(matrix[1,i]); // output : 4 5 6
                //Console.Write(matrix[2,i]); // output : 7 8 9

            };
        static void Main(string[] args)
        {
            //don't use foreach loop to iterate multi dimentional array.
            //NestedLoop2DArray();
            //DiagonalCheck();
            //FromCourse();
            //DiagonalCheck();
            SingleLoop();
        }
        static void NestedLoop2DArray()
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (matrix[x, i] % 2 == 0)
                    {
                        Console.WriteLine($"{matrix[x, i]} even number");
                    }
                    else
                    {
                        Console.WriteLine($"{matrix[x, i]} odd number");
                    }
                }
            }
        }

        static void OddAndEvenNumber()
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (matrix[x, i] % 2 == 0)
                    {
                        Console.WriteLine($"{matrix[x, i]} even number");
                    }
                    else
                    {
                        Console.WriteLine($"{matrix[x, i]} odd number");
                    }
                }
            }
        }

        static void FromCourse()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] %2 == 0)
                    {
                        Console.Write(matrix[i,j] + " ");
                        /*  output : 2 4 6 8
                            {  , 2,   },
                            { 4,  , 6 },
                            {  , 8,   },
                         */
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " else ");
                        /*  output : 1 3 5 7 9
                            { 1,  , 3 },
                            {  , 5,   },
                            { 7,  , 9 },
                         */
                    }

                }
            }
        }

        static void DiagonalCheck()
        {
        /*  Target : 1 5 9
            { 1 ,   ,   },
            {   , 5 ,   },
            {   ,   , 9 },
            
            // coloumn 0  | coloumn 1 |    index 2
            {     1,           2,             3     }, // row 0
            {     4,           5,             6     }, // row 1
            {     7,           8,             9     }  // row 2  
            Console.WriteLine(array2D[2,0]); //to access number 7 we defined call the row then the coloumn
         */
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i==j)
                        matrix[i,j] = 0;
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                }
            }
        }

        static void SingleLoop()
        {
            //for (int i = 0, j= 2; i < matrix.GetLength(1); i++,j--) //this hackish shouldn't be used
            //{
            //    Console.WriteLine(matrix[i,j]);
            //}
            for (int i = 2; i < matrix.GetLength(0); i--) //this is the proper way
            {
                for (int j = 2; j < matrix.GetLength(1); j--)
                {
                    if (i == j)
                        matrix[i, j] = 0;
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                }
            }
        }
    }
}
