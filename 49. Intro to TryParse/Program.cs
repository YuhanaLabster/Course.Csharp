using System;

namespace _49._Intro_to_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureCheck();
        }

        static void TemperatureCheck()
        {
            Console.WriteLine("Enter current temperature");
            string temps = Console.ReadLine();
            int parsedTemp;
            int IntTemps;
            //int IntTemps = int.Parse(temps);
            if (int.TryParse(temps, out parsedTemp)) { IntTemps = parsedTemp; Console.WriteLine(parsedTemp); }
            else { IntTemps = 0;}
            if (parsedTemp < 10) { Console.WriteLine("really cool here"); }
            else if (parsedTemp < 20) { Console.WriteLine("this still OK");}
            else if (parsedTemp < 35) { Console.WriteLine("quite hot here");}
            else { Console.WriteLine("this hot!");}
        }
    }
}
