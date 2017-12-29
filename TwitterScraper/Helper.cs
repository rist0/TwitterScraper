using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;

namespace TwitterScraper
{
    class Helper
    {
        public static async Task<string> GetChangelog(string ua, double timeout, WebProxy proxy)
        {
            string changeLog;
            using (Request r = new Request(ua, timeout, proxy))
            {
                changeLog = await r.requestString("http://smmnova.com/tools/twitter/twitterscraper/changelog.txt");
            }
            return changeLog.Replace("\n", Environment.NewLine);
        }

        public static async Task<string> GetLatestNews(string ua, double timeout, WebProxy proxy)
        {
            string news;
            using (Request r = new Request(ua, timeout, proxy))
            {
                news = await r.requestString("http://smmnova.com/tools/twitter/twitterscraper/news.txt");
            }
            return news.Replace("\n", Environment.NewLine);
        }

        public static async Task<string> GetLatestVersion(string ua, double timeout, WebProxy proxy)
        {
            string version;
            using (Request r = new Request(ua, timeout, proxy))
            {
                version = await r.requestString("http://smmnova.com/tools/twitter/twitterscraper/latestversion.txt");
            }
            return version;
        }
        
        public static string GetCurrentVersion()
        {
            return Application.ProductVersion;
        }

        public static string[] ReadAllLinesFromFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public static string GetUserAgent()
        {
            return new[]
            {
                "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.94 Safari/537.36",
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.112 Safari/537.36",
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.86 Safari/537.36",
                "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.112 Safari/537.36",
                "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.110 Safari/537.36",
                "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:45.0) Gecko/20100101 Firefox/45.0",
                "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.112 Safari/537.36",
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.112 Safari/537.36",
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.112 Safari/537.36",
                "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:45.0) Gecko/20100101 Firefox/45.0",
                "Mozilla/5.0 (Windows NT 5.1; rv:45.0) Gecko/20100101 Firefox/45.0",
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.110 Safari/537.36",
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_4) AppleWebKit/601.5.17 (KHTML, like Gecko) Version/9.1 Safari/601.5.17",
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.110 Safari/537.36",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Safari/537.36 Edge/13.10586",
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/49.0.2623.87 Safari/537.36"
            }[new Random().Next(0, 15)];
        }
    }
}
