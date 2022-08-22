using System;
using System.Collections;

namespace _100._Hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hastables almost similar to dictionaries
            // has key and value

            Hashtable studentstable = new Hashtable();

            Student stud1 = new Student(1, "yanto", 98);
            Student stud2 = new Student(2, "bambang", 91);
            Student stud3 = new Student(3, "eko", 45);
            Student stud4 = new Student(4, "paryadi", 89);
            Student stud5 = new Student(5, "sutarno", 76);

            studentstable.Add(stud1.Id, stud1);
            studentstable.Add(stud2.Id, stud2);
            studentstable.Add(stud3.Id, stud3);
            studentstable.Add(stud4.Id, stud4);
            studentstable.Add(stud5.Id, stud5);

            Student storedStudent1 = (Student)studentstable[stud1.Id];

            //get individual item from hastables
            foreach (DictionaryEntry entry in studentstable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID {temp.Id}");
                Console.WriteLine($"Student Name {temp.name}");
                Console.WriteLine($"Student GPA {temp.GPA}");
            }
            //get individual item from known id
            Console.WriteLine($"Student ID : {storedStudent1.Id}, Name : {storedStudent1.name}, GPA : {storedStudent1.GPA}");

            //we can access the value directly by calling its method
            foreach (Student value in studentstable.Values)
            {
                Console.WriteLine($"Student ID {value.Id}");
                Console.WriteLine($"Student Name {value.name}");
                Console.WriteLine($"Student GPA {value.GPA}");
            }
        }
    }
}
