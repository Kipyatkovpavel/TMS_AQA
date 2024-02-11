using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.BaseImpl
{
    public class Tablet3 : Device
    {
        public override void DisplayInformation(string information)
        {
            Console.WriteLine($"Tablet3 Display: {information}");
        }
    }
}
