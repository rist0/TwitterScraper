using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TwitterScraper
{
    internal class Request : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClientHandler _httpClientHandler;

        public Request(string ua, double timeOut, WebProxy proxy)
        {
            _httpClientHandler = new HttpClientHandler
            {
                Proxy = proxy
            };

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
                    string response = null;

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        response = await responseMessage.Content.ReadAsStringAsync();
                    }

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
