using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ChildGenericPerson<T> : GenericPerson<T>
    {
        public ChildGenericPerson(T id, string name) : base(id, name)
        {
        }
    }
}
