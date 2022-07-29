using System;

namespace _43_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hitung(10,20,50,100); 
            Console.WriteLine(maths());
        }
        static void hitung (int angka_1, int angka_2, int angka_3, int angka_4)
        {
            Console.WriteLine(angka_1 + angka_2 + angka_3 + angka_4);
        }

        static int maths()
        {
            Console.WriteLine("masukkan angka pertama");
            string pertama = Console.ReadLine();
            Console.WriteLine("masukkan angka kedua");
            string kedua = Console.ReadLine();
            int angka1 = int.Parse(pertama); // harus di convert ke INT, karena ga bisa langsung assigned ke INT, karena readline return nya string
            int angka2 = int.Parse(kedua); // harus di convert ke INT, karena ga bisa langsung assigned ke INT, karena readline return nya string 
            return angka1 + angka2;

        }

    }
}
