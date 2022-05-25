using System;

namespace ShoppingApplication
{

    /// <summary>
    /// User defined exception class that inherits the Exception class and sends in the message to its constructor
    /// </summary>
    public class InvalidOptionException : Exception
    {
        public InvalidOptionException(String message) : base(message)
        {

        }
    }
}
