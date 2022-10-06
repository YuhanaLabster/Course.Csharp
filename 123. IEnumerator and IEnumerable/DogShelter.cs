using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123._IEnumerator_and_IEnumerable
{
    internal class DogShelter : IEnumerable<Dog>
    {
        // list of type List<Dog>
        public List<Dog> dogs;

        //this constuctor will initialize the dog list with some values

        public DogShelter()
        {
            // initialize the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog ("casper", false),
                new Dog ("sif", true),
                new Dog ("Oreo", false),
                new Dog ("asu", false),
            };
        }

        // this method below was generated through VS solution.
        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        // this method bellow will not be used as we will not use the Non-generic
        // if we delete this, it will create an error, so we can leave as it is
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
