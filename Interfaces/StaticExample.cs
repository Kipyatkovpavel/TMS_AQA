using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class StaticExample
    {
        public static int StaticVaruable = 0;
        public int InstanceVar;

        public StaticExample() 
        {
            StaticVaruable++;
            InstanceVar = StaticVaruable;
        }
    }
}
