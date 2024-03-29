﻿using System;
using System.Collections.Generic;
using static _156._Creating_your_own_Delegates.Program;

namespace _156._Creating_your_own_Delegates
{
    internal class Program
    {
        //defining a delegate type called FilterDelegate that takes a person object and return boolean
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // create 4 person objects
            Person p1 = new Person() { Name = "Aiden",Age = 41};
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the object to a list called people
            List<Person> people = new List<Person>() { p1,p2,p3,p4};

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adult", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

        }
        //a method to display the list of people that passes the filter condition
        // (returns true)
        // this method will take a title to be displayed, the list of people,
        //land a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach(Person p in people) 
            {
                // check if the persons passes the filter
                if (filter(p))
                {
                    // print the person name and age
                    Console.WriteLine($"{p.Name} with age {p.Age}");
                }
            }
        }

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
