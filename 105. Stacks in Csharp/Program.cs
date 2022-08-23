using System;
using System.Collections.Generic;
namespace _105._Stacks_in_Csharp
{
    internal class Program
    {
        public static Stack<int> stack = new Stack<int>();
        public static int[] ReverseNumber = new int[]{8,2,3,4,7,6,9};
        public static Stack<int> ContainerForReverse = new Stack<int>();


        static void Main(string[] args)
        {
            //CheckElementBeforeRemoveElement();
            //AddElements(); // add 3 elements (1,2,3)
            //RemoveElementUsingWhileLoop();
            //RemoveElement(); // remove the last element (3)
            //ViewElement(); // it will display the last element (2)
            ReversingList();
        }
        public static void AddElements()
        {
            stack.Push(1); //add element 1 into the Stack
            stack.Push(2); //add element 2 into the Stack
            stack.Push(3); //add element 3 into the Stack
        }
        public static string ViewElement()
        {
            if (stack.Count != 0)
            {
                return stack.Peek().ToString();
            }
            else
            {
                return "No elements found";
            }
        }

       public static void RemoveElement()
        {
            // if we remove an empty element it will throw an exceptions System.InvalidOperationException: 'Stack empty.'
            stack.Pop();
        }

        public static void CheckElementBeforeRemoveElement()
        {
            // check the counter before removing element, it will throw and an else statement if element not found
            if (stack.Count < 0)
            {
                stack.Pop();
            }
            else
            {
                Console.WriteLine("element not found");
            }
        }

        public static void RemoveElementUsingWhileLoop()
        {
            while (stack.Count > 0)
            {
                Console.WriteLine($"removing stack {ViewElement()}");
                stack.Pop();
            }
            Console.WriteLine("All values are deleted");
        }

        public static void ReversingList()
        {
            foreach (var element in ReverseNumber)
            {
                Console.Write($"{element} ");
                ContainerForReverse.Push(element);
            }
            Console.WriteLine("\nnumbers in reverse are");
            while (ContainerForReverse.Count > 0)
            {
                int number = ContainerForReverse.Pop();
                Console.Write(number + " ");
            }
        }
    }
}
