using System;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temen_1 = "bambang";
            string temen_2 = "eko";
            string temen_3 = "kempul";
            panggil_teman(temen_1, temen_2, temen_3);

        }
        
        static void panggil_teman(string temen_1, string temen_2, string temen_3)
        {
            Console.WriteLine("halo " + temen_1);
            Console.WriteLine("halo " + temen_2);
            Console.WriteLine("halo " + temen_3);
            Console.WriteLine($"halo {temen_1}, {temen_2}, {temen_3} testing");

        }

    }
}
