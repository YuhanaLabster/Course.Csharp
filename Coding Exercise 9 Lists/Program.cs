using System;
using System.Collections.Generic;

namespace Coding_Exercise_9_Lists
{
    internal class Program
    {
        public static List<int> MyList = new List<int>();

        static void Main(string[] args)
        {
            for (int i = 100; i <= 170; i++)
            {
                MyList.Add(i++);
            }

            foreach (int i in MyList)
            {
                Console.Write(i+" ");
            }   
        }
    }
}
