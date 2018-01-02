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
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;

        public Request(string ua, double timeOut, WebProxy proxy)
        {
            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.Proxy = proxy;

            _httpClient = new HttpClient(_httpClientHandler)
            {
                Timeout = TimeSpan.FromSeconds(timeOut)
            };
            _httpClient.DefaultRequestHeaders.Add("User-Agent", ua);

        }

        public async Task<string> RequestString(string uri)
        {
            try
            {
                using (HttpResponseMessage responseMessage = await _httpClient.GetAsync(uri))
                {
                    var response = await responseMessage.Content.ReadAsStringAsync();
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
            _httpClient.Dispose();
            _httpClientHandler.Dispose();
        }
    }
}
