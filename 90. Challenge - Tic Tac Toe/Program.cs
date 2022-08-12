using System;


namespace _90._Challenge___Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display.Screen();
            //NewGame();
            GameLogic.Gameplay();
        static void NewGame()
            {
                Input.AskUserCharacter();
                Input.ClearData();
                Display.RefreshScreen();
            }
        }
    }
}
