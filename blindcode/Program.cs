using System;

namespace blindcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tebak();
            //infinite(); 
        }
        static void tebak(){Console.WriteLine("ketik y");string jawaban = Console.ReadLine();if (jawaban == "y"){Console.WriteLine(jawaban + "benar");}{Console.WriteLine(jawaban + "salah");}}

        static void infinite()
        {
            int i = 0;
            while (i < 7)
            {
                Console.WriteLine($"perulangan ke {i}");
                i++;
            }
        }

    }
}
