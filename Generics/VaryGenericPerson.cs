using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class VaryGenericPerson<T> : GenericPerson<int>
    {
        public T code;
        public VaryGenericPerson(int id, string name) : base(id, name)
        {
        }
    }
}
