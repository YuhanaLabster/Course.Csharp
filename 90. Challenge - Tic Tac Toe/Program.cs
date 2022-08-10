﻿using System;

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
            //UserInput();
            Player1Input();
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

        static void UpdateScreen()
        {
            Console.Clear();
        }

        static int UserInput()
        {
            
            return Player2Input();
            return Player1Input();
        }

        static int Player1Input()
        {
            Console.WriteLine("Player 1 : Choose your field!");
            try
            {
            int Player1 = int.Parse(Console.ReadLine());
            return Player1;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input the correct format");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please only input single number only");
                return 0;
            }
        }

        static int Player2Input()
        {
            Console.WriteLine("Player 2 : Choose your field!");
            try
            {
                int Player2 = int.Parse(Console.ReadLine());
                return Player2;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input the correct format");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please only input single number only");
                return 0;
            }
        }

    }
}
