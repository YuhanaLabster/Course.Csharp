using System;
using System.IO;
using System.Runtime.InteropServices;

namespace _136._Read_from_a_Textfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "D:\\C#\\Learnerbly\\136. Read from a Textfile\\files\\input.txt";
            string output = "D:\\C#\\Learnerbly\\136. Read from a Textfile\\files\\output.txt";
            string location = "D:\\C#\\Learnerbly\\136. Read from a Textfile\\files\\";

            Assignment(input, output);
        }

        static string ReadFromFile(string location) // read file directly using ReadAllText
        {
            string logs = System.IO.File.ReadAllText(@location);
            return logs;
        }

        static void ReadLineToList(string location) // using ReadAllLines
        {
            string[] lines = System.IO.File.ReadAllLines(@location);
            foreach (string line in lines)
            {
                Console.WriteLine($"from file : \t {line}");
            }
        }

        static void WriteToFile(string location, string input)
        {
            System.IO.File.WriteAllText(@location, input);
            Console.WriteLine("writing files successfully");
        }

        static void WriteFromListToFile(string location) 
        {
            string[] tofile = { "first linesss","second linesss", "third linesss"};
            System.IO.File.WriteAllLines(@location,tofile);
            Console.WriteLine("writing files successfully");
        }

        static void WriteUserInputToFile(string location)
        {
            Console.WriteLine($"write your message, and it will be stored in {location} \n Now write the file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("now write the message you want to save");
            string userInput = Console.ReadLine();
            WriteToFile($"{location}{fileName}.txt", userInput);
            Console.WriteLine("message successfully saved");
        }

        static void UsingStreamWriter(string location)
        {
            Console.WriteLine($"write your message, and it will be stored in {location} \n Now write the file name");
            string fileName = Console.ReadLine();
            Console.WriteLine($"set keyword, once you've set, the next text contains the keyword, file will be saved");
            string keyword = Console.ReadLine();
            Console.WriteLine("now write the message");
            string userInput = Console.ReadLine();
            if (userInput.Contains(keyword))
            {
                using (StreamWriter sw = new StreamWriter($"{location}{fileName}.txt"))
                {
                    sw.WriteLine(userInput);
                    Console.WriteLine("successfully writing the message");
                }
            }
        }

        static void CustomNotepadUsingStreamWritter(string location)
        {
            bool isContinue = true;
            Console.WriteLine($"write your message, and it will be stored in {location} \n Now write the file name");
            string fileName = Console.ReadLine();
            while(isContinue)
            {
                Console.WriteLine("now write the message");
                using (StreamWriter sw = new StreamWriter($"{location}{fileName}.txt"))
                {
                    sw.WriteLine(UserInput(),true);
                    if (AskConfirmation(UserInput()))
                    {
                        sw.WriteLine(UserInput(),true);
                        isContinue = false;
                    }
                }
            }
        }

        static bool AskConfirmation(string input)
        {
            Console.WriteLine("continue? (Y/N)");
            if (input == "Y")
            {
                return false;
            }
            return true;
        } 

        static string UserInput()
        {
            return Console.ReadLine();
        }

        static string[] ReadByLine(string location)
        {
            return File.ReadAllLines(location);
        }

        static void Assignment(string input, string output)
        {
            string results = "";
            foreach (string item in ReadByLine(input))
            {
                if (item.Contains("split"))
                {
                    results += item.Split()[4] + " ";
                }
            }
            Console.WriteLine(results);
        }
    }
}
