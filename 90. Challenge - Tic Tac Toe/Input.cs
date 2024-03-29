﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        }

        public static void CharacterReminder()
        {
            Console.WriteLine("Please remember your character");
            foreach (var i in Variables.Player)
            {
                Console.WriteLine($"Player {i.Key} : {i.Value}");
            }
        }

        public static int PlayerInput(int PlayerKey)
        {
            Console.WriteLine($"Player {PlayerKey} : Choose your field!");
            try
            {
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine($"user entered {userInput}");
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
            catch (ArgumentNullException)
            {
                Console.WriteLine($"Player {PlayerKey} you just did not input any number,your move skipped");
                return 0;
            }
        }

        public static void DuplicateFinder(int PlayerKey)
        {
            string PlayerCharacter = Variables.Player[PlayerKey]; 
            for (int i = 0; i < Variables.Board.GetLength(0); i++)
            {
                for (int j = 0; j < Variables.Board.GetLength(1); j++)
                {
                    if (Variables.Board[i, j] != PlayerCharacter)
                    {
                        Debug.WriteLine("duplicate found");
                    }
                }   
            }
        }

        public static int PlayerConfirmation()
        {
            Console.WriteLine("Press 1 to restart or 2 to exit the game");
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
            catch (ArgumentNullException)
            {
                Console.WriteLine($"please check your input");
                PlayerConfirmation();
                return 0;
            }
        }

        public static void ArrayUpdater(int PlayerInput, string userCharacter)
        {     
            switch (PlayerInput)
            {
                case 1:
                    Variables.Board[0, 0] = userCharacter;

                    break;
                case 2:
                    Variables.Board[0, 1] = userCharacter;

                    break;
                case 3:
                    Variables.Board[0, 2] = userCharacter;

                    break;
                case 4:
                    Variables.Board[1, 0] = userCharacter;

                    break;
                case 5:
                    Variables.Board[1, 1] = userCharacter;

                    break;
                case 6:
                    Variables.Board[1, 2] = userCharacter;

                    break;
                case 7:
                    Variables.Board[2, 0] = userCharacter;

                    break;
                case 8:
                    Variables.Board[2, 1] = userCharacter;

                    break;
                case 9:
                    Variables.Board[2, 2] = userCharacter;

                    break;
                case 0:
                    GameLogic.GameConfirmation();
                    break;

            }
        }

        public static void ClearData()
        {
            Variables.Player.Clear();
            CloneArray();
        }

        public static void CloneArray()
        {
            for (int i = 0; i < Variables.Cloned.GetLength(0); i++)
            {
                for (int j = 0; j < Variables.Cloned.GetLength(1); j++)
                {
                    Variables.Board[i,j] = Variables.Cloned[i,j];
                }
            }
        }
    }
}
