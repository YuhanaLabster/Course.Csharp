using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90._Challenge___Tic_Tac_Toe
{
    internal class GameLogic
    {
        public static bool isContinue = true;

        public bool RestartGame
        {
            get { return false; }
        }

        public static void Gameplay()
        {
            Display.RefreshScreen();
            Input.AskUserCharacter();
            while (isContinue)
            {
                for (int i = 1; i < 3; i++) 
                    {
                        Input.CharacterReminder();
                        Display.DrawScreen();
                        Input.ArrayUpdater(Input.PlayerInput(i), Variables.Player[i]);
                        LineChecker(i);
                        Display.RefreshScreen();
                    }

            }

        }

        public static void OverideChecker(int PlayerId)
        {
            PlayerInverter(PlayerId);
        }

        public static int PlayerInverter(int PlayerId)
        {
            if (PlayerId %2== 0)
            {
                return 1;
            }
            return 2;
        }

        public static void GameConfirmation()
        {
            if (Input.PlayerConfirmation() == 1)
            {
                Input.ClearData();
                Gameplay();
            }
            else
            {
                Console.WriteLine("bye");
            }
        }

        public static void Winner(int PlayerKey)
        {
            isContinue = false;
            Display.RefreshScreen();
            Console.WriteLine($"Congratulations Player {PlayerKey}, you are the winner!");
            GameConfirmation();
        }

        public static void LineChecker(int PlayerKey)
        {
            FirstRow(PlayerKey);
            SecondRow(PlayerKey);
            ThirdRow(PlayerKey);
            FirstColumn(PlayerKey);
            SecondColumn(PlayerKey);
            ThirdColumn(PlayerKey);
            Diagonal(PlayerKey);
        }
        public static void FirstRow(int PlayerKey)
        {
            //[0, 0], [0, 1],[0, 2]
            if (Variables.Player[PlayerKey].Equals(Variables.Board[0, 0]) && Variables.Player[PlayerKey].Equals(Variables.Board[0, 1]) && Variables.Player[PlayerKey].Equals(Variables.Board[0, 2]))
            {
                Winner(PlayerKey);
            }
        }
        public static void SecondRow(int PlayerKey)
        {
            //[1, 0], [1, 1],[1, 2]
            if (Variables.Player[PlayerKey].Equals(Variables.Board[1, 0]) && Variables.Player[PlayerKey].Equals(Variables.Board[1, 1]) && Variables.Player[PlayerKey].Equals(Variables.Board[1, 2]))
            {
                Winner(PlayerKey);
            }
        }
        public static void ThirdRow(int PlayerKey)
        {
            //[2, 0], [2, 1],[2, 2]
            if (Variables.Player[PlayerKey].Equals(Variables.Board[2, 0]) && Variables.Player[PlayerKey].Equals(Variables.Board[2, 1]) && Variables.Player[PlayerKey].Equals(Variables.Board[2, 2]))
            {
                Winner(PlayerKey);
            }
        }
        public static void FirstColumn(int PlayerKey)
        {
            //[0, 0], [1, 0],[2, 0]
            if (Variables.Player[PlayerKey].Equals(Variables.Board[0, 0]) && Variables.Player[PlayerKey].Equals(Variables.Board[1, 0]) && Variables.Player[PlayerKey].Equals(Variables.Board[2, 0]))
            {
                Winner(PlayerKey);
            }
        }
        public static void SecondColumn(int PlayerKey)
        {
            //[0, 1], [1, 1],[2, 1]
            if (Variables.Player[PlayerKey].Equals(Variables.Board[0, 1]) && Variables.Player[PlayerKey].Equals(Variables.Board[1, 1]) && Variables.Player[PlayerKey].Equals(Variables.Board[2, 1]))
            {
                
                Winner(PlayerKey);
            }
        }
        public static void ThirdColumn(int PlayerKey)
        {
            //[0, 2], [1, 2],[2, 2]
            if (Variables.Player[PlayerKey].Equals(Variables.Board[0, 2]) && Variables.Player[PlayerKey].Equals(Variables.Board[1, 2]) && Variables.Player[PlayerKey].Equals(Variables.Board[2, 2]))
            {
                
                Winner(PlayerKey);
            }
        }
        public static void Diagonal(int PlayerKey)
        {
            //[0, 0], [1, 1],[2, 2]
            if (Variables.Player[PlayerKey].Equals(Variables.Board[0, 0]) && Variables.Player[PlayerKey].Equals(Variables.Board[1, 1]) && Variables.Player[PlayerKey].Equals(Variables.Board[2, 2]))
            {
                
                Winner(PlayerKey);
            }
        }


    }

}
