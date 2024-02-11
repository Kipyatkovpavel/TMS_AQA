using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Explicitlmpl
{
    public class BaseAction1 : IAction
    {
        public void Move()
        {
           Console.WriteLine("Move in BaseAction class...");
        }
    }
}
