using Interfaces.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.BaseImpl
{
    public abstract class Device : IDisplayable
    {
        public abstract void DisplayInformation(string information);
    }
}
