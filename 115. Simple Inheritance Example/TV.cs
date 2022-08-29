using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115._Simple_Inheritance_Example
{
    internal class TV : ElectricalDevices

    {

        public TV(bool IsON, string brand) : base(IsON, brand)
        {

        }
        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV");
            }
            else
            {
                Console.WriteLine("TV off, switch it on first");
            }
        }

    }
}
