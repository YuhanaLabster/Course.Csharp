using System;

namespace _97._Overview_Generic_and_Non_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* what is collections?
             * 
             * Collections are classes that we can use to store a collection of objects
             * Not limited to one type of objects
             * No size constraints, it can grow in size as we add more elements
             * 
             * 
             * Why do we need Collections? 
             * We use them to store, manage and manipulate groups of objects more efficently
             * Why not using array? array has limited size and will be an issue if we're going
             * to expand more area
             * 
             * in collections we can : 
             * 1. Adding
             * 2. Deleting
             * 3. Replacing
             * 4. Searching
             * 5. Copying
             * 
             * 
             * Types of collections : 
             * 1. Non Generic
                    * Can store any type of objects (more than single datatype)
                    * Located in : System.Collections namespace
                    * Example : 
                        int num1 = 5;
                        float num2 = 3.14f;
                        string name = "yuhana";
                        Array Myarray = new Array();
                        Myarray.Add(num1);
                        Myarray.Add(num2);
                        Myarray.Add(name);
                        
                        foreach (object element in Myarray){} // to access it. we should declare iterator with objects
                        
             * 2. Generic
                    * limited to one type of objects
                    * Located in : System.Collections.Generic namespace
                    * Example : 
                        string animal1 = "cat";
                        string animal2 = "dog";
                        string animal3 = "chicken";
                        List<string> myAnimal = new List<string>();
             */
         
        }

    }
}
