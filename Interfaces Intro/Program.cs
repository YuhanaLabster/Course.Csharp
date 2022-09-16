using System;

namespace Interfaces_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket_1 = new Ticket(10);
            Ticket ticket_2 = new Ticket(10);
            Console.WriteLine(ticket_1.Equals(ticket_2));

        }
    }
}
