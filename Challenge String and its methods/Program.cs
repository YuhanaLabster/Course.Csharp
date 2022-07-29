using System;

namespace Challenge_String_and_its_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("input your name");
            yourName = Console.ReadLine();
            Console.WriteLine($"your name is {yourName}");
            Console.WriteLine(yourName.ToUpper());
            Console.WriteLine(yourName.ToLower());
            Console.WriteLine(yourName.Substring(0,5));
            Console.WriteLine(yourName.Trim());
            Console.ReadKey();  



        }
    }
}
