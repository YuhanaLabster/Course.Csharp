using System;

namespace Challenge___If_Statements
{
    internal class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            CreateAccount();
            login();
            Console.Read();
        }

        public  static void CreateAccount()
        {
            Console.WriteLine("enter your username");
            username = Console.ReadLine();
            Console.WriteLine("enter your password");
            password = Console.ReadLine();
            Console.WriteLine("account created");
        }

        public static void login()
        {
            Console.WriteLine("enter username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("loggin successfull");
                }
                else 
                {
                    Console.WriteLine("wrong password"); 
                }
            }
            else
            {
                Console.WriteLine("wrong username");
            }
            
        }
    }
}
