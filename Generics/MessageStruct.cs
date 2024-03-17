using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public struct MessageStruct
    {
        public string Text { get; }

        public MessageStruct(string text)
        {
            Text = text;
        }
    }
}
