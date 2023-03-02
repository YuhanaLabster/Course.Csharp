using System;
using System.Collections.Generic;

namespace Coding_Exercise_15__Lambda_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the dictionary with string keys and Func<float, float, float> values
            Dictionary<string, Func<float, float, float>> operations = new Dictionary<string, Func<float, float, float>>();

            // Define lambda expressions for each arithmetic operation
            Func<float, float, float> add = (a, b) => a + b;
            Func<float, float, float> subtract = (a, b) => a - b;
            Func<float, float, float> multiply = (a, b) => a * b;
            Func<float, float, float> divide = (a, b) => a / b;

            // Add the lambda expressions to the dictionary
            operations.Add("+", add);
            operations.Add("-", subtract);
            operations.Add("*", multiply);
            operations.Add("/", divide);

            // Test the dictionary by performing arithmetic operations
            float x = 5.0f;
            float y = 2.0f;
            Console.WriteLine("x + y = " + operations["+"](x, y)); // should output 7.0
            Console.WriteLine("x - y = " + operations["-"](x, y)); // should output 3.0
            Console.WriteLine("x * y = " + operations["*"](x, y)); // should output 10.0
            Console.WriteLine("x / y = " + operations["/"](x, y)); // should output 2.5
        }
    }
}
