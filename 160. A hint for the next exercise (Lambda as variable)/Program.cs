using System;

namespace _160._A_hint_for_the_next_exercise__Lambda_as_variable_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int,int> Add = (x) => x+1;
            Func<int, int> Substract = (x) => x - 1;
            Func<int, int> Multiply = (x) => x * 2;
            Func<int, int> Divided = (x) => x / 2;
            Func<string, string> RemoveCharacter = (x) => x.Replace("L","*");

            int toAdd = Add(10);
            int toSubstract = Substract(10);
            int toMultiply = Multiply(10);
            int toDivide = Divided(10);
            string applyFilter = RemoveCharacter("LABSTER");

            Console.WriteLine
                (
                    $"applyFilter{applyFilter},\n"+
                    $"toAdd {toAdd},\n" +
                    $"toSubstract {toSubstract},\n" +
                    $"toMultiply {toMultiply},\n" +
                    $"toDivide {toDivide}"
                );
        }
    }
}
