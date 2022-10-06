using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123._IEnumerator_and_IEnumerable
{
    internal class Dog
    {
        // properties of dog name
        public string Name { get; set; }
        
        // properties of is this naughty dog
        public bool isNaughtyDog { get; set; }
        
        // simple constructor 
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name= name;
            this.isNaughtyDog = isNaughtyDog;
        }

        //this method will print how many treats the dog received
        public void GiveTreat (int numberofTreats)
        {
            // print a message containing the number of treats and the name of the dog
            Console.WriteLine($"Dog : {Name} said guk guk {numberofTreats} times");
        }
    }
}
