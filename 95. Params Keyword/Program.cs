using System;

namespace _95._Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string items = "macbook";
            int prices = 1000;
            int amount = 2;
            char chars = '$';
            float pi = 3.14f;

            // static void IntroducingParams(params ) // the params mean : it will take any object, not specific to datatype like int, string, char
            Console.WriteLine($"{items} and for single item the prices is {prices} and for {amount} you need to pay {prices*amount}");
            /* this example above Console.WriteLine() could handle more than single datatype
             * it could handle string and int and even calculations {prices*amount}
             * it even able to handle empty parameters
             */
            ParamsMethod("this", "is example", "of param", "method");

            AnotherParams(items, prices , amount, chars, pi);
        }

        public static void ParamsMethod(params string[] setence)
        {
            for (int i = 0; i < setence.Length; i++)
            {
                Console.Write($"{setence[i]} ");
            }
        }

        public static void AnotherParams (params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
        }

    }
}
