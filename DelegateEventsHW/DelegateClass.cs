using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFirstTaskHW
{
    public class DelegateClass
    {
       public delegate int NoParameters();

       public int RunRandomNumbers()
        {
            Random random = new Random();
            return random.Next(0, 10);
        }
    }
}
