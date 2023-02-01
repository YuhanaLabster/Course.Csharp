using System;
using System.Collections.Generic;

namespace _155._Delegates_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Aiden", "sif","walter","Anatoli"};
            
            
            Console.WriteLine("----before-----");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(Filter); // in this case we don't have to add (string input) while calling Filter.

            Console.WriteLine("----after-----");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


        }

        static bool Filter(string input)
        {
            return input.Contains("i");
        }
    }
}
