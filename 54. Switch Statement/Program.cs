using System;

namespace _54._Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AgeCheckerWithIfStatement();
            AgeCheckerWithSwitch();
        }
        static void AgeCheckerWithIfStatement()
        {
            bool repeat = true;
            while (repeat)
            {
            Console.WriteLine("input your age");
            string Ages = Console.ReadLine();
            int Age = int.Parse(Ages);
            if (Age == 25 || Age > 25)
            {
                Console.WriteLine("Good to go");
                    repeat = false;
                    Console.Clear();

            }
            else if (Age == 15 || Age < 15)
            {
                Console.WriteLine("i can't let you in, too young for party");
            }
            else
            {
                Console.WriteLine("how old are you?");
            }
            }

        }

        static void AgeCheckerWithSwitch()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("input your age");
                string Ages = Console.ReadLine();
                int Age = int.Parse(Ages);

                switch (Age)
                {
                    case 25:
                        Console.WriteLine("Good to go");
                        repeat = false;
                        break;
                    case 15:
                        Console.WriteLine("i can't let you in, too young for party");
                        break ;
                    default: Console.WriteLine("how old are you?");
                        break;
                }
            }

        }
    }
}
