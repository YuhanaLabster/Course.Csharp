using System;

namespace _84._Foreach_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetingFriends();
        }
        static void DontDoThis()
        ///this is not the best approach, as it might lead to memory out of bound.
        {
            int[] numbs = new int[10];
            for (int i = 1; i < numbs.Length; i++)
            {
                numbs[i] = i;
            }

            for (int j = 0; j < numbs.Length; j++)
            {
                Console.WriteLine($"elements {j} = {numbs[j]}");
            }

            //best approach
            int counter = 0;
            foreach (int k in numbs)
            {
                Console.WriteLine($"elements {k} = {numbs[k]}");
                counter++;
            }
            Console.Read();
        }
       
        static void GreetingFriends()
        {
            string[] Friends = {"bambang", "eko", "yanto", "darto", "yitno" };
            foreach (string f in Friends)
            {
                Console.WriteLine($"hallo {f}");
            }
        }
    }
}
