using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterScraper
{
    class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string message) : base(message)
        {

        }
    }
}
