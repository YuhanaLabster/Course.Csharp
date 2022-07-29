using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_6_Constructors
{
    internal class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDate;
        public Phone()
        {
            this.Company = "Unknown";
            this.Model = "Unknown";
            this.ReleaseDate = "Unknown";
        }
        
        public Phone( string Company, string Model, string ReleaseDate)
        {
            this.Company = Company;
            this.Model = Model;
            this.ReleaseDate = ReleaseDate; 
        }

        public Phone(string Company, string Model)
        {
            this.Company = Company;
            this.Model = Model;
            this.ReleaseDate= "Unknown";
        }
   
        public void Introduce()
        {
            Console.WriteLine($"It is {Model}, created by {Company}, and it was released at {ReleaseDate}");
        }

        public void Run ()
        {
            Console.WriteLine($"{Company}{Model}{ReleaseDate}");
        }
    }
}
