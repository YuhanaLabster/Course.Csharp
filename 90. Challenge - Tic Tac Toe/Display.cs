using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90._Challenge___Tic_Tac_Toe
{
    internal class Display
    {
        public static void RefreshScreen()
        {
            Console.Clear();
        }

        public static void DrawScreen()
        {
            FirstRow();
            Console.Write("\n_______|_______|______\n");
            SecondRow();
            Console.Write("\n_______|_______|______\n");
            ThirdRow();
            Console.Write("\n       |       |       \n");
        }

        static void FirstRow()
        {
            Console.Write("       |       |   \n");
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.Write($"   {Variables.Board[0, i]}   |");
                }
                else if (i == 1)
                {
                    Console.Write($"   {Variables.Board[0, i]}   ");
                }
                else if (i == 2)
                {
                    Console.Write($"|   {Variables.Board[0, i]}");
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
                    Console.Write($"   {Variables.Board[1, i]}   |");
                }
                else if (i == 1)
                {
                    Console.Write($"   {Variables.Board[1, i]}   ");
                }
                else if (i == 2)
                {
                    Console.Write($"|   {Variables.Board[1, i]}");
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
                    Console.Write($"   {Variables.Board[2, i]}   |");
                }
                else if (i == 1)
                {
                    Console.Write($"   {Variables.Board[2, i]}   ");
                }
                else if (i == 2)
                {
                    Console.Write($"|   {Variables.Board[2, i]}");
                }

            }
        }
    }
}
