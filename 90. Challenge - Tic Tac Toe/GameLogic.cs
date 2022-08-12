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
        public static bool isContinue
        {
            get { return true; }
            set { isContinue = value; }
        }

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

        public static void QuitGame()
        {
            Display.RefreshScreen();
            Console.WriteLine("do you want to quit?");
            if (Console.ReadLine() == "y")
            {
                isContinue = false;
            }
        }

    }

}
