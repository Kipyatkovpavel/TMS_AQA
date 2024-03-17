using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) 
        {
        }

        public EmailMessage() : base("Email Message by default.")
        {
        }
    }
}
