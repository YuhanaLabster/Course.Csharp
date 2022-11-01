using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _128._Polymorphic_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* a car can be a BMW, an Audi,a Porsche etc. 
                Polymorphism at work #1: an Audi,BMW, Porsche can all be used whereever a Car is expected.
                No cast is required because an implicit conversion exists from a derived class to its base class.
             */
            var cars = new List<Car>
            {
                new Audi(200,"Red","A4"),
                new BMW(400,"white","X4")
            };

            // Polymorphism at work #2: the virtual method Repair is invoked on each of the derived classes, not the base class.
            foreach (var car in cars)
            {
                car.Repair();
                /* We want to show 
                 *  " The Audi A4 was repaired "
                    " The BMW X4 was repaired "
                 * but if we run this code it will showing "Car was repaired"
                 * So we should override the Repair() method from car class, into each Repair() method inside of the Audi, and BWM class.
                 * 
                 * How?
                 * 1. Add "Virtual" into the Repair method in Car class, from "public void Repair()" be "public virtual void Repair()"
                 * 2. Add "override" into each Repair method in each BMW and AUDI class, from "public void Repair()" be "public override void Repair()"
                 */

            }

            /* We wan to call ShowDetails() inside of each brand classes, not from Car class and we don't want to override it.
             * 
             * How?
             * 1. Add "new" into reach ShowDetails() from each brand classses, from "public void ShowDetails()" to "public new void ShowDetails()"
             */

            // this object bellow will still calling ShowDetails() inside the Car class
            // it will showing ; 
            //The Audi A4 was repaired
                // HP is 200 and its colour is black
                // HP is 100 and its colour is purple

            // its because its referr to Car class when we initiate it
            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "purple", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            //we need to define directly to each brand name
            // and it will showing 
            //  "Brand BMW, HP is 500 and its colour is white : called from brand class"
            //  "Brand Audi, HP is 100 and its colour is purple : called from brand class"

            BMW bmwM5 = new BMW(500, "white", "M5");
            Audi audiQuatro = new Audi(100, "purple", "audiQuatro");
            bmwM5.ShowDetails();
            audiQuatro.ShowDetails();

            // if we still want to call ShowDetails() inside the Car class we can casting it right away
            Car CalledFromCar = (Car)bmwM5;
            CalledFromCar.ShowDetails();
            // and it will showing 
            // HP is 500 and its colour is white

            Console.ReadKey();
        }
    }
}
