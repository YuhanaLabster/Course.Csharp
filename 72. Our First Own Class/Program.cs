using System;

namespace _72._Our_First_Own_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //create object from class or instante of human
            Human denis = new Human();
            //access public variable from outside of the file Human.cs then change its value
            denis.firstName = "Denis";
            // call method of the class
            denis.Introduce();
            */
            //-----------------Chalange---------------------//
            Human yuhana = new Human();
            yuhana.firstName = "Yuhana";
            yuhana.lastName = "Atmaja";
            yuhana.Introduce();
            Console.Read();
        }
    }
}
