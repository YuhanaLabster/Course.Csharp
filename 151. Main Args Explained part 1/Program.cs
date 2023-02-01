using System;

namespace _151._Main_Args_Explained_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            we can pass  from args in static void Main(string[] args) by :
                * go to properties of the project
                * Click debug then select general
                * Click Open Debug Launch Profiles UI
                * Enter the arguments in "Command Line Arguments"
                * Define the index of the arguments in code
                * Run the Code

            // the args array cannot be null. So, it's safe to access the Length property without null checking.
            // so we check the length of the array if it's zero it means no arguments were provided to the application
            */
            if (args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args ; ) , Please provide arguments next time");
                // pause the application so it does' t quite after pritning our error message
                Console.ReadKey();
                //quit the application entirly since we can't proceed further since, the arguments are empty
                return;
            }
            Console.WriteLine($"hello {args[0]}");
        }
    }
}
