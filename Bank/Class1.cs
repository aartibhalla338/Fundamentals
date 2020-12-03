using System;
using System.Collections.Generic;
using System.Text;

namespace example.Bank
{
    public class InsufficientFoundException : Exception
    {
        public InsufficientFoundException(string message) : base(message)
        {

        }
    }
}
