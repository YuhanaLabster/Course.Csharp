using System;

namespace Coding_Exercise_13_Math_Class
{
    internal class Program
    {
        /*
        Subject:
        Complete the Run Method with code that will:

            Pars line into int if it is possible. Otherwise, or if the value is not in the range between 0 and 180, display "Check the input!" on the new line and return;

            if the parsing was successful, calculate and print:

                1. Cosine of this angle in the format "Cos = X", where X is the value;

                2. Sine of the angle in the format "Sin = X", where X is the value;

                3. Tangent of the angle in the format "Tg = X", where X is the value;

                Hint: All of those methods expect us to provide radians as input. In order to convert the angle to radians, use the method ConvertToRadians. 
        */
        static void Main(string[] args)
        {
            Run("150");
        }


        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {
            double userInput = double.Parse(line);
            if (userInput >= 180) 
            {
                Console.WriteLine("Check the input!");
            }
            else
            {
                Console.WriteLine($"Cos = {ConvertToRadians(Math.Cos(ConvertToRadians(userInput)))}");
                Console.WriteLine($"Sin = {ConvertToRadians(Math.Sin(ConvertToRadians(userInput)))}");
                Console.WriteLine($"Tg = {ConvertToRadians(Math.Tan(ConvertToRadians(userInput)))}");
            }
        }
    }
}
