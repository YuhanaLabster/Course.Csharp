using System;
using System.Collections.Generic;

namespace Rudys_challenge
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Triangle();
            Square();
        }
        static void Square()
        {
            Console.WriteLine("enter single character you want to show");
            string Characters = Console.ReadLine();
            char ParsedCharacter = Characters.ToCharArray()[0];
            Console.WriteLine("How many times will be repeated?");
            string input = Console.ReadLine();
            int ParsedInput = int.Parse(input);
            Console.WriteLine("Here's the square");
            for (int i = ParsedInput; i > 0; i--)
            {
                Console.WriteLine(new string(ParsedCharacter, ParsedInput));
            }
        }

        static void PointUpTriangle() //finished
        {
            Console.WriteLine("enter single character you want to show");
            string Characters = Console.ReadLine();
            char ParsedCharacter = Characters.ToCharArray()[0];
            Console.WriteLine("How many times will be repeated?");
            string input = Console.ReadLine();
            int ParsedInput = int.Parse(input);
            Console.WriteLine("Here's the triangle");
            for (int i = 0; i < ParsedInput; i++)
            {
                Console.Write(ParsedCharacter);
                Console.WriteLine(new string(ParsedCharacter, i));
            }
        }
        static void PointDownTriangle() //finished
        {
            Console.WriteLine("enter single character you want to show");
            string Characters = Console.ReadLine();
            char ParsedCharacter = Characters.ToCharArray()[0];
            Console.WriteLine("How many times will be repeated?");
            string input = Console.ReadLine();
            int ParsedInput = int.Parse(input);
            Console.WriteLine("Here's the triangle");
            for (int i = ParsedInput; i > 0; i--)
            {
                Console.WriteLine(new string(ParsedCharacter, i));
            }
        }
    }
}
