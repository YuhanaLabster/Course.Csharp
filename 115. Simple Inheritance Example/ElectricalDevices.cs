using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115._Simple_Inheritance_Example
{
    // parent class / base
    internal class ElectricalDevices
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevices(bool IsON, string brand)
        {
            IsON = IsON;
            brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
