using System;

namespace _116._Virtual_and_Override_Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Anjing = new Dog("helly", 10);
            Console.WriteLine($"{Anjing.Name} is {Anjing.Age} years old");
            Anjing.MakeSound();
            Anjing.Play();
            Anjing.Eat();


            /* STORY 
                * We have Animal that act as parent class
                * But we want to modify function inside Animal class from child class (Dog)
              
                HOW : 
                * PARENT CLASS (Animal)
                    * add "virtual" into the function name
                * CHILD CLASS (Dog)
                    * add "override" into the function name
                    * If we want to have the same function as Parent, we can add "Base.Function", example "base.Eat()"
             */

        }
    }
}
