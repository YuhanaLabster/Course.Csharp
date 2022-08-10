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
            UserInput();
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
            string Player1 = Console.ReadLine();
            int ParsedPLayer1Input = int.Parse(Player1);
            return ParsedPLayer1Input;
        }

        static int Player2Input()
        {
            Console.WriteLine("Player 2 : Choose your field!");
            string Player2 = Console.ReadLine();
            int ParsedPLayer2Input = int.Parse(Player2);
            return ParsedPLayer2Input;
        }

    }
}
