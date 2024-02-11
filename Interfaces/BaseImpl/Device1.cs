using Interfaces.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.BaseImpl
{
    public  class Device1 : IDisplayable
    {
        public virtual void DisplayInformation(string information)
        {
            Console.WriteLine($"Device1 Display: {information}");
        }
    }
}
