using System;

namespace _145._Random_Class
{
    internal class Program
    {
        public static bool Again = true;
        static void Main(string[] args)
        {
            AskMeAnything();
        }

        private static int Randomizer()
        {
            Random generate = new Random();
            int RandomNumber;
            for (int i = 1; i <= 3; i++)
            {
                RandomNumber = generate.Next(1, 4);
                return RandomNumber;
            }
            return 0;
        }

        private static void Answer()
        {
            switch (Randomizer())
            {
                case 1: Console.WriteLine("YES"); break;
                case 2: Console.WriteLine("Maybe"); break;
                case 3: Console.WriteLine("NO"); break;
            }
        }

        private static void Questions()
        {
            Console.WriteLine("Ask me");
            Console.ReadLine();
            Answer();
        }

        private static bool RepeatAgain()
        {
            Console.WriteLine("Ask again? (Y/N)");
            if (Console.ReadLine() == "N")
            {
                 Again = false;
            }
            Console.Clear();
            return true;
        }

        private static void AskMeAnything()
        {
            while (Again)
            {
                Questions();
                RepeatAgain();
            }
        }
    }
}
