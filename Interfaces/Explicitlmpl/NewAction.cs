using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Explicitlmpl
{
    public class NewAction : IAction, IMovable
    {
        void IAction.Move()
        {
            Console.WriteLine("IAction: движемся...");
        }

        void IMovable.Move()
        {
            Console.WriteLine("IMovable: движемся...");
        }
    }
}
