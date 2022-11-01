using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130._Has_A___Relationships
{
    internal class Car
    {
        // properties
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"The car ID is {carIDInfo.IDNum} and {carIDInfo.Owner} is the owner");
        }

        // constructor
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        
        // default constructor, we need this in case we want to specify from each child class
        public Car()
        {
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP is {HP} and its colour is {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
