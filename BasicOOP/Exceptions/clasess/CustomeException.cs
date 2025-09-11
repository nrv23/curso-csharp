using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.clasess
{
    public class CustomeException : Exception
    {

        private int StatusCode { get; }
        public CustomeException()
        {

        }

        public CustomeException(string? message, int statusCode, Exception exception) : base(message, exception)
        {
            StatusCode = statusCode;
        }

        public CustomeException(string? message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }


        public CustomeException(string? message) : base(message)
        {

        }

        public CustomeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
