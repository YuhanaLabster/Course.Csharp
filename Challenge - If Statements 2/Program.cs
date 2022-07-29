using System;

namespace Challenge___If_Statements_2
{
    internal class Program
    {
        static int highscore = 150;
        static string highScorePlayer = "yanto";

        static void Main(string[] args)
        {
            //ScoreCHecker();
            ScoreCheckFromCourse(100,"bambang");
            ScoreCheckFromCourse(200, "eko");
            ScoreCheckFromCourse(300, "setyanto");
            ScoreCheckFromCourse(400, "tugino");
            ScoreCheckFromCourse(500, "waryanto");
        }

        static void ScoreCHecker()
        {
            Console.WriteLine("enter your score");
            string inputScore = Console.ReadLine();
            Console.WriteLine("enter your name");
            string inputName = Console.ReadLine();
            int parsedScore = int.Parse(inputScore);

            if (parsedScore > highscore)
            {
                Console.WriteLine("New highscore is " + parsedScore);
                Console.WriteLine("New highscore holder is  " + inputName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highScorePlayer);
            }
        }

        public static void ScoreCheckFromCourse(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highScorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is  " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highScorePlayer);
            }
        }
    }
}
///Create an application with a score, highscore and a highscorePlayer.
///Create a method which has two parameters, one for the score and one for the playerName.
///When ever that method is called, it should be checked if the score of the player is higher than the highscore,
///if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console
///if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
///Consider which variables are required globally and which ones locally.
