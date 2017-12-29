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
        private string IpAddress;
        private string Port;
        private string UserName;
        private string UserPassword;

        public WebProxy webProxy
        {
            get
            {
                if (Uri.IsWellFormedUriString("http://" + IpAddress + ":" + Port, UriKind.Absolute))
                {
                    return new WebProxy(IpAddress + ":" + Port)
                    {
                        Credentials = new NetworkCredential(UserName, UserPassword)
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
                IpAddress = input.Split(delimiter)[0];
                Port = input.Split(delimiter)[1];
            }
            else if (input.Split(delimiter).Count() == 4)
            {
                UserName = input.Split(delimiter)[2];
                UserPassword = input.Split(delimiter)[3];
            }
        }

        public Proxy()
        {

        }
    }
}
