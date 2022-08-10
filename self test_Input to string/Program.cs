using System;
using System.Collections.Generic;

namespace self_test_Input_to_string
{
    internal class Program
    {
        public static Dictionary<int, string> nominalCurrency = new Dictionary<int, string>();
        public static Dictionary<int, string> intToString = new Dictionary<int, string>();
        public static List<string> Combined = new List<string>();
        public static List<string> Collection = new List<string>();
        public static List<int> stringToInt = new List<int>();

        public static int [] separated = new int [0];
        static void Main(string[] args)
        {
            addValue();
            Console.WriteLine("input number");
            string input = Console.ReadLine();
            int inputLength = input.Length;
            AddToList(input);
            LengthMaching(inputLength);
            CombiningResult();
        }

        static void AddToList (string input)
        {
            foreach (char item in input)
            {
                string charToString = item.ToString();
                int charToInt = Convert.ToInt32(charToString);
                stringToInt.Add(charToInt);
            }
        }

        static void InputBreakerNominalCurrency()
        {
            foreach (KeyValuePair<int, string> entry in nominalCurrency)
            {
                foreach (int item in stringToInt)
                {
                    if (item == entry.Key)
                    {
                        Combined.Add(entry.Value);
                        Console.WriteLine($"InputBreakerNominalCurrency {entry.Value}");
                    }
                }
            }
        }

        static void InputBreakerIntToString()
        {
            foreach (KeyValuePair<int, string> entry in intToString)
            {
                foreach (int item in stringToInt)
                {
                    if (item == entry.Key)
                    {
                        Combined.Add(entry.Value);
                    }
                }
            }
        }

        static void CombiningResult()
        {
            InputBreakerNominalCurrency();
            InputBreakerIntToString();
            foreach (string item in Combined)
            {
                Console.WriteLine($"CombiningResult() {item}");
            }
        }

        static void LengthMaching(int inputLength)
            {
            switch (inputLength)
                {
                    case 2:
                    CombiningResult();
                    break;
                    case 3:
                    CombiningResult();
                    break;
                    case 4:
                    CombiningResult();
                    break;
                    case 5:
                    CombiningResult();
                    break;
                    case 6:
                    CombiningResult();
                    break;
                    case 7:
                    CombiningResult();
                    break;
                    case 8:
                    CombiningResult();
                    break;
                    case 9:
                    CombiningResult();
                    break;
                    case 10:
                    CombiningResult();
                    break;
                    case 11:
                    CombiningResult();
                    break;
                    case 12:
                    break;
                    case 13:
                    CombiningResult();
                    break;
                    default:
                    Console.WriteLine("Maximum 13 digits");
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
            intToString.Add(11, "rupiah");
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
