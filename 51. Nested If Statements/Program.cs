using System;

namespace _51._Nested_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //username & password = admin equal to admin rights
            //username & password = guess equal to guess rights
            login();
        }

        static void validation() { }
        static void login()
        {
            bool repeatlogin = true;
            while (repeatlogin)
            {
                Console.WriteLine("enter username"); string username = Console.ReadLine();
                Console.WriteLine("enter password"); string password = Console.ReadLine();

                if (username.Equals("admin") && password.Equals("admin")) { Console.WriteLine("hello admin"); repeatlogin = false; }
                else if (username.Equals("guess") && password.Equals("guess")) { Console.WriteLine("hello guess"); repeatlogin = false; }
                else { Console.WriteLine("login failed"); Console.Clear(); }
            }

        }
    }
}
