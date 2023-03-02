using System;
using System.Collections.Generic;

namespace _159._Lambda_Expressions
{
    internal class Program
    {
        //defining a delegate type called FilterDelegate that takes a person object and return boolean
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // create 4 person objects
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the object to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adult", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

            // here we created a new variable called filter of type FilterDelegate
            // then we assigned an anonymous method to it instead of an already defined method

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("p.Age >= 20 && p.Age <=30;", people, filter);
            DisplayPeople("ALL", people, delegate (Person p) { return true; });

            string searchKeyword = "A";
            DisplayPeople("Age > 20 with search keyword : " + searchKeyword, people,p => 
            {
                if (p.Name.Contains(searchKeyword) && p.Age >20)
                {
                    return true;
                }
                return false;
            });

            DisplayPeople("Exactly 25:", people, p => p.Age == 25);
        }
        //a method to display the list of people that passes the filter condition
        // (returns true)
        // this method will take a title to be displayed, the list of people,
        //land a filter delegate
        public static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in people)
            {
                // check if the persons passes the filter
                if (filter(p))
                {
                    // print the person name and age
                    Console.WriteLine($"{p.Name} with age {p.Age}");
                }
            }
        }
        // statement lambda
        // a search keyword to filter the names 

        // filters
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }

        
    }
}
