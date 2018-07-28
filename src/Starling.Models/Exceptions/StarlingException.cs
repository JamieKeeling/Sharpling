using System;

namespace Sharpling.Models.Exceptions
{
    public class StarlingException : Exception
    {
        public StarlingException(string message) : base(message) { }

        public StarlingException(string message, Exception innerException) : base(message, innerException) { }
    }
}