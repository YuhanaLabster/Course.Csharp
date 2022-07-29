using System;

namespace Coding_Exercise_1_Test_your_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string masukkan = "belajar";
            LowUpper(masukkan);
            hitung(masukkan);
        }

        static void LowUpper (string masukkan)
        {
            string jadi_kecil = masukkan.ToLower();
            string jadi_besar = masukkan.ToUpper();
            Console.WriteLine(jadi_kecil + jadi_besar);
        }

        static void hitung (string masukkan)
        {
            Console.WriteLine($"panjangnya {masukkan.Length}");
        }
    }
}
