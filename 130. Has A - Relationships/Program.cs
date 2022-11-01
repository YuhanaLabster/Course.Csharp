using System;
using System.Collections.Generic;

namespace _130._Has_A___Relationships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * CASE : we want to add additional information for car class in general
             * 
             * How : 
             * 1. Create CarIDInfo along with its property of ID and Owner (check the CarIDInfo class for more detail)
             * 2. Create "protected CarIDInfo carIDInfo = new CarIDInfo();" (check the CarIDInfo class for more detail)
             * 3. Create method "public void SetCarIDInfo(int idNum, string owner)" (check the CarIDInfo class for more detail)
             * 4. Create method "public void GetCarIDInfo()" (check the CarIDInfo class for more detail)
             * 5. Add information to the object
             */
            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "purple", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            // add info
            bmwZ3.SetCarIDInfo(1234, "yuhana");
            audiA3.SetCarIDInfo(1235, "Bambang");
            
            // calling the info
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();


            Console.ReadKey();
        }
    }
}
 