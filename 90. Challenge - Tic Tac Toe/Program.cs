using System;

namespace _90._Challenge___Tic_Tac_Toe
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
            ShowAll();
        }

        static void ShowAll()
        {
            FirstRow();
            Console.Write("\n_______|_______|______\n");
            SecondRow();
            Console.Write("\n_______|_______|______\n");
            ThirdRow();
            Console.Write("\n       |       |       \n");
            Console.ReadKey();
        }

        static void FirstRow()
        {
            Console.Write("       |       |   \n");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                Console.Write($"   {matrix[0,i]}   |");
                }
                else if (i == 1)
                {
                  Console.Write($"   {matrix[0, i]}   ");
                }
                else if (i == 2)
                {
                 Console.Write($"|   {matrix[0, i]}");
                }

            }
            
        }

        static void SecondRow()
        {
            Console.Write("       |       |   \n");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.Write($"   {matrix[1, i]}   |");
                }
                else if (i == 1)
                {
                    Console.Write($"   {matrix[1, i]}   ");
                }
                else if (i == 2)
                {
                    Console.Write($"|   {matrix[1, i]}");
                }

            }
        }

        static void ThirdRow()
        {
            Console.Write("       |       |   \n");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.Write($"   {matrix[2, i]}   |");
                }
                else if (i == 1)
                {
                    Console.Write($"   {matrix[2, i]}   ");
                }
                else if (i == 2)
                {
                    Console.Write($"|   {matrix[2, i]}");
                }

            }
        }
    }
}
