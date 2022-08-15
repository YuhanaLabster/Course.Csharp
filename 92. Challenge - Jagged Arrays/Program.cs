using System;

namespace _92._Challenge___Jagged_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a jaggedArray, which contains 3 "friends array", in which two family members should be stored.
            // introduce family members from different families to each other via console

            string[][] friends = new string[][]
            {
            new string[] { "bambang", "eko", "yanto" },
            new string[] { "adine bambang", "kakange bambang", "mbakyune bambang" },
            new string[] { "adine eko", "kakange eko", "mbakyune eko" },
            new string[] { "adine yanto", "kakange yanto", "mbakyune yanto" }
            };

            Console.WriteLine($"accessing the first element [0][0] {friends[0][0]}");
            Console.WriteLine($"accessing the second element [0][1] {friends[0][1]}");
            Console.WriteLine($"accessing the third element [0][2] {friends[0][2]}");



            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine($"inside {i}");
                for (int j = 0; j < friends[i].Length; j++)
                {
                    Console.WriteLine($" check {friends[i][j]}");
                }
            }
        }
    }
}
