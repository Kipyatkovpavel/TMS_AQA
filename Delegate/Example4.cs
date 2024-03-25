using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate;

public class Example4
{
    // Тип делегата
    public delegate void NoParameters();

    public void Run()
    {
        NoParameters noPrm = delegate
        {
            Console.WriteLine("Have fun!");
        };

        noPrm();
    }
}
