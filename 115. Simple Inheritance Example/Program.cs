using System;

namespace _115._Simple_Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRAdio = new Radio(true, "sony");
            myRAdio.SwitchOn();
            myRAdio.ListenRadio();

            TV myTV = new TV(true, "samsung");
            myTV.SwitchOn();
            myTV.WatchTv();


            /* We created two objects TV and Radio.
             * both TV and radio has the same pattern : 
                * It has the arguments for is ON or OFF,and Brand Name properties
                * turn on and turn off constructor.
             * now you create both pattern into two different class name.
             * but it will make the code redundant as both object has the same code.
                
                SOLUTION : 
             * from PARENT side : 
                * create the 3rd object which called ElectronicDevices that cover both pattern above and use it as Parent class / base.
                * create the same properties and constructur same as TV and Radio has.
             * from CHILD side :
                * add ": ElectricalDevices" into the object class name for both classes ("internal class Radio : ElectricalDevices","internal class TV : ElectricalDevices")
                * add ": send the arguments from child to parent class or base(arguments) " into the constractor, so it would be like "public Radio(bool IsON, string brand) : base(IsON, brand)" 
                * and in this moment we can remove all of code body as it's similar to the parent constructor or Properties
             * 
             * 
             */
        }
    }
}
