using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122._Creating_And_Using_Your_Own_Interfaces
{
    internal interface IDestroyable
    {
        String DestructionSound { get; set; }

        void Destroy();
    }
}
