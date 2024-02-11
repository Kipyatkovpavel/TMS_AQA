using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.BaseImpl
{
    public class Tablet5 : Device2
    {
        public new void DisplayInformation(string information)
        {
            Console.WriteLine($"Tablet5 Display: {information}");
        }
    }
}
