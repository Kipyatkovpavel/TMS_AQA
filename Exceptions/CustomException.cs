using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions;

public class CustomException : Exception
{
    // Конструктор с возможностью передачи сообщения об ошибке
    public CustomException(string message) : base(message)
    {
    }
}