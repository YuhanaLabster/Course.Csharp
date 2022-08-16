using System;
using System.Collections;

namespace _98._ArrayLists
{
    internal class Program
    {
        public static ArrayList myList = new ArrayList();
        static void Main(string[] args)
        {
            // array without defining the amount.
            ArrayList arrayUndefinedAmount = new ArrayList();
            // array wih defined amount of object
            ArrayList arrayDefinedAmount = new ArrayList(100);

            Update();
            DisplayArrayList();
        }

        public static void Update()
        {
            myList.Add(25);
            myList.Add("hello");
            myList.Add(13.5);
            myList.Add(125);
            myList.Add('%');
            myList.Add('&');
            myList.Add("testing");
        }

        public static void DisplayArrayList()
        {
            foreach (object obj in myList)
            {
                if (obj is int)
                {
                    Console.Write("this int");
                    Console.WriteLine((int)obj);
                }
                else if (obj is string)
                {
                    Console.Write("this string ");
                    Console.WriteLine((string)obj);
                }
                else if (obj is double)
                {
                    Console.Write("this double ");
                    Console.WriteLine((double)obj);
                }
                else if (obj is char)
                {
                    Console.Write("this char ");
                    Console.WriteLine((char)obj);
                }
            }
            Console.WriteLine($"total element {myList.Count}");
        }
    }
}
