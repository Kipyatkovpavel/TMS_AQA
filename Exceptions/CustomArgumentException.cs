using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions;

public class CustomArgumentException : ArgumentException
{
    public int Value { get; }

    public CustomArgumentException(string message, int val)
        : base(message)
    {
        Value = val;
    }
}