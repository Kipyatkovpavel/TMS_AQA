using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Explicitlmpl
{
    public class HeroAction : BaseAction1, IMovable

    {
        void IMovable.Move()
        {
            Console.WriteLine("Move in HeroAction class...");
        }
    }
}
