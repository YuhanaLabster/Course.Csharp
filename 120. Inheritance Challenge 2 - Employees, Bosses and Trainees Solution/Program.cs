using System;

namespace _120._Inheritance_Challenge_2___Employees__Bosses_and_Trainees_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee michael =  new Employee("michael", "yanto", 10000);
            michael.Work();
            michael.Pause();

            Boss checkNorris = new Boss("toyota", "bambang yanto", "kampret", 12222);
            checkNorris.Lead();

            Trainees newbie = new Trainees("bambang gentolet", "bambang",5000,10, 50);
            newbie.Learn();
            newbie.Work();
        }
    }
}
