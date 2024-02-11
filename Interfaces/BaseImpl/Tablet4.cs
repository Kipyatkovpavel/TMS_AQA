using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.BaseImpl
{
    public class Tablet4 : Device1
    {
        public override void DisplayInformation(string information)
        {
            Console.WriteLine($"Tablet4 Display: {information}");
        }
    }
}
