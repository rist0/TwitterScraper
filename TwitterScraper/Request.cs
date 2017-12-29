using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TwitterScraper
{
    class Request : IDisposable
    {
        private HttpClient httpClient;
        private HttpClientHandler httpClientHandler;

        public Request(string ua, double timeOut, WebProxy proxy)
        {
            httpClientHandler = new HttpClientHandler();
            httpClientHandler.Proxy = proxy;

            httpClient = new HttpClient(httpClientHandler);
            httpClient.Timeout = TimeSpan.FromSeconds(timeOut);
            httpClient.DefaultRequestHeaders.Add("User-Agent", ua);

        }

        public async Task<string> requestString(string uri)
        {
            string response;
            try
            {
                using (HttpResponseMessage responseMessage = await httpClient.GetAsync(uri))
                {
                    response = await responseMessage.Content.ReadAsStringAsync();
                    return response;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public void Dispose()
        {
            httpClient.Dispose();
            httpClientHandler.Dispose();
        }
    }
}
