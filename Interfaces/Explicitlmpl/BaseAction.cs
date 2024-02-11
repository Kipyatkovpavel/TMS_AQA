using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Explicitlmpl
{
    public class BaseAction : IAction
    {
        void IAction.Move() => Console.WriteLine("Move in BaseAction class...");

    }
}
