using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions;

public class InvalidInputException : Exception
{
    public InvalidInputException(string fieldName, string message)
        : base($"Неверный ввод в поле '{fieldName}': {message}")
    {
    }
}