using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90._Challenge___Tic_Tac_Toe
{
    internal class Input
    {
        public static void AskUserCharacter()
        {
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine($"Hi Player {i}\nDo you have preffered character?\nPlease input single character only");
                Variables.Player.Add(i,Console.ReadLine());
                Display.RefreshScreen();
            }
            Console.WriteLine("Please remember your character");
            foreach (var i in Variables.Player)
            {
                Console.WriteLine($"Player {i.Key} : {i.Value}");
            }
            Console.WriteLine("Press ENTER to START!");
            Console.ReadKey();

        }

        public static int PlayerInput(int PlayerId)
        {
            Console.WriteLine($"Player {PlayerId} : Choose your field!");
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                return userInput;
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

        public static void Switcher(int PlayerInput)
        {
            switch (PlayerInput)
            {
                case 1:
                    Variables.Board[1, 0] = "need to be changed";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    {
                        Console.WriteLine("Incorrect Input");
                    }
                    break;
            }
        }

        public static void ClearData()
        {
            Variables.Player.Clear();
        }
    }
}
