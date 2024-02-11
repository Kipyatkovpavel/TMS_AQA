using Interfaces.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.BaseImpl
{
    public  class Device2 : IDisplayable
    {
        public new void DisplayInformation(string information)
        {
            Console.WriteLine($"Device2 Display: {information}");
        }
    }
}
