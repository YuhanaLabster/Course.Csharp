using System;
using System.Collections.Generic;
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

        public static void Updater(string userCharacter, int userInput)
        {
            
        }

        public static void PlayerSwitch()
        {
            for (int i = 1; i < 3; i++) 
                {
                    Input.PlayerInput(i);
                }
        }
    }

}
