using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TwitterScraper
{
    class Proxy
    {
        private readonly string _ipAddress;
        private readonly string _port;
        private readonly string _userName;
        private readonly string _userPassword;

        public WebProxy WebProxy
        {
            get
            {
                if (Uri.IsWellFormedUriString("http://" + _ipAddress + ":" + _port, UriKind.Absolute))
                {
                    return new WebProxy(_ipAddress + ":" + _port)
                    {
                        Credentials = new NetworkCredential(_userName, _userPassword)
                    };
                }
                return null;
            }
            set
            {
                
            }
        }

        public Proxy(string input, char delimiter)
        {
            if (input.Split(delimiter).Count() == 2)
            {
                _ipAddress = input.Split(delimiter)[0];
                _port = input.Split(delimiter)[1];
            }
            else if (input.Split(delimiter).Count() == 4)
            {
                _userName = input.Split(delimiter)[2];
                _userPassword = input.Split(delimiter)[3];
            }
        }

        public Proxy()
        {

        }
    }
}
