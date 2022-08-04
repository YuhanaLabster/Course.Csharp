using System;
using System.Collections.Generic;

namespace self_test_Input_to_string
{
    internal class Program
    {
        public static Dictionary<int, string> nominalCurrency = new Dictionary<int, string>();
        public static Dictionary<int, string> intToString = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Console.WriteLine($"{nominalCurrency[1]}");
            Console.WriteLine("input number");
            string input = Console.ReadLine();
            long parsed = long.Parse(input);
            int inputLength = input.Length;
            }
        static void Process(int inputLength)
            {
            switch (inputLength)
                {
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    default:
                        break;
                }
            }
        static void addValue()
        {
            nominalCurrency.Add(2, "puluh");
            nominalCurrency.Add(3, "ratus");
            nominalCurrency.Add(4, "ribu");
            nominalCurrency.Add(5, "puluh ribu");
            nominalCurrency.Add(6, "ratus ribu");
            nominalCurrency.Add(7, "juta");
            nominalCurrency.Add(8, "puluh juta");
            nominalCurrency.Add(9, "ratus juta");
            nominalCurrency.Add(10, "milyar");
            nominalCurrency.Add(11, "puluh milyar");
            nominalCurrency.Add(12, "ratus milyar");
            nominalCurrency.Add(13, "trilyun");
            intToString.Add(1, "satu");
            intToString.Add(2, "dua");
            intToString.Add(3, "tiga");
            intToString.Add(4, "empat");
            intToString.Add(5, "lima");
            intToString.Add(6, "enam");
            intToString.Add(7, "tujuh");
            intToString.Add(8, "delapan");
            intToString.Add(9, "sembilan");
            intToString.Add(10, "sepuluh");
        }
    }
}

/* ribu         : 1000                  : 4
 * puluh ribu   : 10 000                : 5
 * ratus ribu   : 100 000               : 6
 * juta         : 1 000000              : 7
 * puluh juta   : 10 000 000            : 8
 * ratus juta   : 100 000 000           : 9
 * milyar       : 1 000 000 000         : 10
 * puluh milyar : 10 000 000 000        : 11
 * ratus milyar : 100 000 000 000       : 12
 * trilyun      : 1 000 000 000 000     : 13
 */
