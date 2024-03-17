using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class IntGenericPerson : GenericPerson<int>
    {
        public IntGenericPerson(int id, string name) : base(id, name)
        {
        }
    }
}
