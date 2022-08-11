using System;


namespace _90._Challenge___Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display.Screen();
            Input.AskUserCharacter();
            foreach (var character in Variables.PlayerCharacters)
            {
                Console.Write(character);
            }
        }
    }
}
