using System;

namespace lab5v14
{
    public class InvalidSaleException : Exception
    {
        public InvalidSaleException(string message) : base(message) { }
    }
}
