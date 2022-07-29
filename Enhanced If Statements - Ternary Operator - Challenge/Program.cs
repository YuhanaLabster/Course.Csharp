using System;

/*create a small application that takes a temperature value as input and checks if the input is an integer or not.
 * If the input value is not an integer value, it should print to the console "Not a valid Temperature".
 * And if the input value is the valid integer then it should work as mentioned below.
 * # If input temperature value is <=15 it should write "it is too cold here" to the console.
 * # If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.
 * # If the input temperature value is > 28 it should write "it is hot here" to the console.
 * you can use if statement for the other conditions like to check if the entered value is a valid integer or not.
 */
namespace Enhanced_If_Statements___Ternary_Operator___Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureCheck();
        }
        static void TemperatureCheck()
        {
            bool repeat = true;
            while (repeat)
            {
            Console.WriteLine("input your temperature");
            string inputTemperature = Console.ReadLine();
                int onlyNUmber;
                bool isNumber = int.TryParse(inputTemperature, out onlyNUmber);
                if (isNumber)
                {
                    string stateOfMatter = onlyNUmber <= 15 ? "it is too cold here" : onlyNUmber >= 16 && onlyNUmber <= 28 ? "its OK" : onlyNUmber > 28 ? "its hot here" :"whatever";
                    Console.WriteLine(stateOfMatter);
                }
                else { Console.WriteLine("Not a valid Temperature"); }
            }
        }
        static void TemperatureCheckCorrect()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("input your temperature");
                string inputTemperature = Console.ReadLine();
                int onlyNUmber;
                bool isNumber = int.TryParse(inputTemperature, out onlyNUmber);
                if (isNumber)
                {
                    string stateOfMatter = onlyNUmber <= 15
                        ? "it is too cold here" 
                        : onlyNUmber >= 16 && onlyNUmber <= 28 
                        ? "its OK" 
                        : onlyNUmber > 28 
                        ? "its hot here" 
                        : "whatever";
                    Console.WriteLine(stateOfMatter);
                }
                else { Console.WriteLine("Not a valid Temperature"); }
            }
        }

    }
}
