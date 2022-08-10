using System;

namespace Tic_Tac_Toe_winner_identifier
{
    internal class Program
    {
        public static int[,] board =
        {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }, 
        };

        public static void Main(string[] args)
        {
            Checker(2,5);
        }
        public static bool Checker(string[,] board)
        {
            // here we perform horizontal and vertical checks
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }
            // here diagonal checks 
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;
            return false;
        }
        }
    }
