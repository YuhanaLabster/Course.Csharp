using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115._Simple_Inheritance_Example
{
    // child class
    internal class Radio : ElectricalDevices
    {
        public Radio(bool IsON, string brand) : base(IsON, brand) // All value inside constractor will send to parent or base (ElectricalDevices)
        {

    }
    
    public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("listening Radio");
            }
            else
            {
                Console.WriteLine("Radio off, switch it on first");  
            }
        }

    }
}
