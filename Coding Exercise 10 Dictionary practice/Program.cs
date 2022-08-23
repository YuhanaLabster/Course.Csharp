using System;
using System.Collections.Generic;

namespace Coding_Exercise_10_Dictionary_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Speller(1));
        }
        public static string Speller (int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {0,"zero"},
                {1,"one"},
                {2,"two"},
                {3,"three"},
                {4,"four"},
                {5,"Five"},
            };

            if (dic.ContainsKey(i))
            {
                return dic[i];
            }
            else
                return "nope";
        }

    }
}
