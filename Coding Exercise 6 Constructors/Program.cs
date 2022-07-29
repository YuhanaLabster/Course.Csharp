using System;

namespace Coding_Exercise_6_Constructors
{
    /*
     * The main of this exercise is to create 3 constructors for the class Phone:
     * default constructor that sets all values to "unknown";
     * constructor that takes 2 arguments (company and model) and sets them respectively. The ReleaseDay should be set to "unknown";
     * constructor with 3 arguments (company, model, and release day);
     * Warning: You cannot touch the given parts of the code! 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone one = new Phone();
            Phone two = new Phone("Apple", "IPhone 12");
            Phone three = new Phone("Apple", "IPhone 12", "September 24, 2021");

            one.Introduce();
            two.Introduce();
            three.Introduce();
        }
    }
}
