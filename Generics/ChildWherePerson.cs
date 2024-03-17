using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ChildWherePerson<T> : GenericPerson<T> where T : class
    {
        public ChildWherePerson(T id, string name) : base(id, name)
        {
        }
    }
}
