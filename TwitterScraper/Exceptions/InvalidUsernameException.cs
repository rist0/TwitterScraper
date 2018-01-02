using System;

namespace TwitterScraper.Exceptions
{
    class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string message) : base(message)
        {

        }
    }
}
