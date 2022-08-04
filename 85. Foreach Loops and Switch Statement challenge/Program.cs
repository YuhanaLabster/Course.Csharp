using System;

namespace _85._Foreach_Loops_and_Switch_Statement_challenge
{
    internal class Program
    {
        public static bool IsRepeat = true;
        
        static void Main(string[] args)
        {
            CharChecker();
        }


        public static void WordChecker(string FirstValue)
        {
            foreach (char x in FirstValue)
            {
                if (!char.IsLetter(x))
                {
                    Console.WriteLine($"{x} is not a string");
                    IsRepeat = true;
                }
                else
                {
                    IsRepeat = false;   
                }
            }
        }
        public static void IntChecker(string FirstValue)
        {
            foreach (char x in FirstValue)
            {
                if (!char.IsNumber(x))
                {
                    Console.WriteLine($"{x} is not an integer");
                }
                else 
                { 
                    Console.Write($"{x} is the valid integer\n"); 
                    IsRepeat = false;
                }
            }
        }

        public static void CharChecker()
        {
            while (IsRepeat)
            {
                Console.WriteLine("Enter a value: ");
                string FirstValue = Console.ReadLine();
                Console.WriteLine("Select the Data type to validate the input you have entered. \n Press 1 for String \n Press 2 for Integer \n Press 3 for Boolean");
                string SecondValue = Console.ReadLine();
                int parsedSecondValue = int.Parse(SecondValue);
                switch (parsedSecondValue)
                {
                    case 1:
                    WordChecker(FirstValue);
                    break;
                    case 2:
                    IntChecker(FirstValue);
                    break;
                    default :
                    Console.WriteLine("invalid options");
                    break;  
                }   

            }

        }
        static void Attempt1()
        {
            Console.WriteLine("Enter a value: ");
            string FirstValue = Console.ReadLine();
            Console.WriteLine("Select the Data type to validate the input you have entered. \n Press 1 for String \n Press 2 for Integer \n Press 3 for Boolean");
            string SecondValue = Console.ReadLine();
            switch (SecondValue)
            {
                case "1":
                    if (FirstValue is String)
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It is a valid: String");
                    }
                    else
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It invalid: String");
                    }
                    break;
                case "2":
                    if (FirstValue is int)
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It is a valid: Integer");
                    }
                    else
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It invalid: Integer");
                    }
                    break;
                case "3":
                    if (FirstValue is bool)
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It is a valid: Boolean");
                    }
                    else
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It invalid: Boolean");
                    }
                    break;
            }



            //Console.WriteLine("You have entered a value: {} \n It is an invalid: Integer");
        }
        static void Attempt2()
        {
            bool IsValid =  false;
            Console.WriteLine("Enter a value: ");
            string FirstValue = Console.ReadLine();
            Console.WriteLine("Select the Data type to validate the input you have entered. \n Press 1 for String \n Press 2 for Integer \n Press 3 for Boolean");
            string SecondValue = Console.ReadLine();
            switch (SecondValue)
            {
                case "1":
                    foreach (char x in FirstValue)
                    {
                        if (!char.IsLetter(x))
                        {
                            IsValid = true;
                        }
                    } IsValid = false;
                    break;

                case "2":
                    if (FirstValue is int)
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It is a valid: Integer");
                        IsValid = true;
                    }
                    else
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It invalid: Integer");
                    }
                    IsValid = false;
                    break;

                case "3":
                    if (FirstValue is bool)
                    {
                        IsValid = true;
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It is a valid: Boolean");
                    }
                    else
                    {
                        Console.WriteLine($"You have entered a value: {FirstValue} \n It invalid: Boolean");
                    }
                    IsValid = false;
                    break;
                default:
                    {
                        Console.WriteLine("Failed to identify");
                    }
                    break;
            }
        }
    }
}

/* 1. Get user input store into string variable
 * 2. Get second input store into int variable
 * 3. Verify the second input if its INT with Parse method
 * 4. On case 1 check if input value is 1 then check each character through foreach loop then return its value as bool
 * 5. On case 2 check if input value is 2 and its and integer
 * 6. On case 3 check if input value is 3 anad its boolean
 * 7. Set default as "not valid input"
 * 7. At the last check, ensure isValid is true, if yes then print each result
 *
 */

