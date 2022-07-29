using System;

namespace Coding_Exercise_2_If_and__Else_Coding_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberCheker();
        }

        static void NumberCheker()
        {
            Console.WriteLine("enter the number");
            string numberEntered = Console.ReadLine();
            int numberBeforeParsed;
            if (int.TryParse(numberEntered, out int numberAfterParsed)){numberBeforeParsed = numberAfterParsed;}
            else{numberAfterParsed = 0;}
            if (numberAfterParsed % 2==0) { Console.WriteLine("this is even number");}
            else { Console.WriteLine("Number you've entered is {0} is odd", numberAfterParsed); }
        }
    }
}
