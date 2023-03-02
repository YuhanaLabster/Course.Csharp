using System;

namespace Coding_Exercise_14_Delegates
{
    internal class Program
    {
        public delegate float OperationDelegate(float x, float y);

        static void Main(string[] args)
        {
            Console.WriteLine(Divide(5, 3));
        }

        public static float Subtract(float x, float y) { return x - y; }
        public static float Add(float x, float y){return x + y;}
        public static float Multiply(float x, float y) { return x * y; }
        public static float Divide(float x, float y) { return x / y; }

        public static float ApplyOperation(float x, float y, OperationDelegate operation)
        {
            float result;
            result= operation(x, y);
            return result;
        }
    }
}
