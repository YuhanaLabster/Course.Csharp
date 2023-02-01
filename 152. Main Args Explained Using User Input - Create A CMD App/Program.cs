using System;

namespace _152._Main_Args_Explained_Using_User_Input___Create_A_CMD_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No Arguments given, type HELP for available options");
                // pause the application so it does' t quite after pritning our error message
                Console.ReadKey();
                return; //quit the application entirly since we can't proceed further since, the arguments are empty
            }

            if (args[0] == "help")
            {
                Console.WriteLine("----- HELP MENU -----");
                Console.WriteLine("'add'    : To add 2 numbers");
                Console.WriteLine("'sub'    : To substract 2 numbers");
                Console.WriteLine("---------------------");
                Console.ReadKey();
            }
            if (args.Length != 3)
            {
                Console.WriteLine("Inva1id arguments, please use the help command for instructions");
                Console.ReadKey();
                return;//quit the app
            }

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Inva1id arguments, please use the help command for instructions");
                Console.ReadLine();
                return;
            }

            float result;

            switch (args[0])
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;

                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;
                default: Console.WriteLine("Inva1id arguments, please use the help command for instructions");
                    break;
            }

            //check the length of args
        }
    }
}
