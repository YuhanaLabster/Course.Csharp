using System;

namespace _44._Try_Catch_and_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator();
        }

        static void calculator()
        {
            Console.WriteLine("Angka Pertama");
            try
            {
                int pertama = int.Parse(Console.ReadLine());
                Console.WriteLine("Angka kedua");
                int kedua = int.Parse(Console.ReadLine());
                Console.WriteLine(pertama / kedua);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("engga boleh kosong");
            }
            catch (FormatException)
            {

                Console.WriteLine("format exeptions");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("kosong");
            }
            
        }
    }
}
