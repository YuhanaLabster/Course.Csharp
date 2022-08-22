using System;
using System.Collections;

namespace _101._Hashtables___Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* write program that will iterate through each element of the students array and insert them into hastables
             * If a student with the same ID already exist in the hashtables skip it and display the following error :
             * "sorry, A student with the same ID already Exists"
             * Hint : Use method ContainsKey() to check wether a student with the same ID already exist
             */
            Hashtable table = new Hashtable();


            Student[] students = new Student[5];

            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);
            
            foreach (Student s in students)
            {
                if (!table.ContainsKey(s.Id))
                {
                    table.Add(s.Id, s);
                    Console.WriteLine($"{s.Id} was added");
                }
                else
                {
                    Console.WriteLine($"sorry, A student with the same ID {s.Id} already Exists");
                }
            }
        }
    }
}
