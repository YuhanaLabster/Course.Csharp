using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90._Challenge___Tic_Tac_Toe
{
    internal class Input
    {
        public static string AskUserCharacter(int PlayerId)
        {
            Console.WriteLine("Do you have preffered character?\n Please input single character only");
            string Player1Character = Console.ReadLine();
            return Player1Character;
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

        public static void Switcher(int PlayerId)
        {
            switch (PlayerId)
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


    }
}
