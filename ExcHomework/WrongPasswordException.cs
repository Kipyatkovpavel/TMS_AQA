﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcHomework
{
    public class WrongPasswordException : Exception
    { 
        public WrongPasswordException() { }

        public WrongPasswordException(string message) : base(message) { }
    }
}

