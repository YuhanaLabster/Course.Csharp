using System;

namespace Challenge___Loops_1___Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AverageScore();
            AnswerFromCourses();
        }

        static void AverageScore()
        {
            int StudentScore = 0;
            int ScoreAdded = 0;

            Console.WriteLine("Enter your student score, to exit press -1 then press enter");
            bool retry = true;

            while (retry)
            {
                try
                {
                string userInput = Console.ReadLine();
                int inputInt = int.Parse(userInput);
                if (userInput !="-1")
                {
                        Console.WriteLine("data saved");
                        StudentScore += inputInt;
                    ScoreAdded++;
                }
                else
                {
                    try
                    {
                            Console.WriteLine($"average score {StudentScore/ScoreAdded}");
                            Console.WriteLine("thank you for using our code");
                            retry = false;
                            Console.Read();
                    }
                     catch (DivideByZeroException)
                    {
                        Console.WriteLine("thank you for using our code"); 
                    }
                }
                }
                catch (FormatException)
                {
                    Console.WriteLine("incorrect format");
                }

            }
            
        }

        static void AnswerFromCourses()
        {
            {
                string input = "0";
                int count = 0;
                int total = 0;
                int currentNumber = 0;

                while (input != "-1")
                {
                    Console.WriteLine("Last number was {0}", currentNumber);
                    Console.WriteLine("Please enter the next score");
                    Console.WriteLine("Current amount of entries {0}", count);
                    Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                    input = Console.ReadLine();
                    if (input.Equals("-1"))
                    {
                        Console.WriteLine("--------------------------------------------");
                        double average = (double)total / (double)count;
                        Console.WriteLine("The average score of your students is {0}", average);
                    }
                    if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                    {
                        total += currentNumber;
                    }
                    else
                    {
                        if (!(input.Equals("-1")))
                        {
                            Console.WriteLine("Please enter a value between 1 and 20!");
                        }
                        continue;
                    }

                    count++;

                }

                Console.ReadLine();
            }
        }
    }
}