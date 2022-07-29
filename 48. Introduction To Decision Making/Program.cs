using System;

namespace _48._Introduction_To_Decision_Making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            weatherCheck();
        }
        static void weatherCheck()
        {
            Console.WriteLine("what's the temperature?");
            string Check = Console.ReadLine();
            int temperatureCheck = int.Parse(Check);
            if (temperatureCheck < 10)
            {
                Console.WriteLine("take the coat");
            }
            else if (temperatureCheck == 10)
            {
                Console.WriteLine("its {0} degree celcius", temperatureCheck);
            }
            else;
            {
                Console.WriteLine("for {0} degree celcius, its warm", temperatureCheck);
            }
        }

    }
}
