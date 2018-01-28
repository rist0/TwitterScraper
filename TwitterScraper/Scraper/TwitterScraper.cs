using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterScraper.Exceptions;

namespace TwitterScraper.Scraper
{
    public interface IScraper
    {
        bool DebugMode { get; set; }
        Task<TwitterScraperData> GetDetails(string ua, string user, double requestTimeout, WebProxy proxy);
    }

    public class MyTwitterScraper : IScraper
    {
        private TwitterHtmlParser _parser;
        
        // TODO: Check if it works
        public bool DebugMode { get; set; }

        public async Task<TwitterScraperData> GetDetails(string ua, string user, double requestTimeout, WebProxy proxy)
        {
            string requestUri = $"https://twitter.com/{user}";
            using (Request r = new Request(ua, requestTimeout, proxy))
            {
                string response = await r.RequestString(requestUri);
                return GetDetails(response, user);
            }
        }

        private TwitterScraperData GetDetails(string response, string username)
        {
            _parser = new TwitterHtmlParser(response);
            var scraperData = new TwitterScraperData();
            var startUpPath = Application.StartupPath;
            
            if(response.Contains("Sorry, that page"))
            {
                throw new InvalidUsernameException($"Username {username} is not valid");
            }

            // check if account is verified by Twitter
            scraperData.IsUserVerified = response.Contains("/help/verified");

            // get user's username
            scraperData.Username = _parser.GetUsername();

            // get user's description
            scraperData.UserDescription = _parser.GetDescription();

            // get user's location
            scraperData.UserLocation = _parser.GetLocation();

            // get user's registration date
            scraperData.UserRegistrationDate = _parser.GetRegistrationDate();

            // get user's birth date
            scraperData.UserBirthDate = _parser.GetBirthDate();

            // get user's amount of medias
            scraperData.UserAmountOfMedias = _parser.GetUserMediaCount();

            // get user's amount of tweets
            scraperData.UserAmountOfTweets = _parser.GetTweetsCount();

            // get user's amount of followings
            scraperData.UserAmountOfFollowings = _parser.GetFollowingsCount();

            // get user's amount of followers
            scraperData.UserAmountOfFollowers = _parser.GetFollowersCount();

            // get user's amount of likes
            scraperData.UserAmountOfLikes = _parser.GetLikesCount();

            if (!DebugMode) return scraperData;

            if(!Directory.Exists(startUpPath + "\\logs"))
            {
                try
                {
                    Directory.CreateDirectory(startUpPath + "\\logs");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($@"Failed to createe dictionary.\n Stack trace: {ex.StackTrace}\n Error message: {ex.Message}");
                }
                
            }

            File.WriteAllLines(startUpPath + @"\logs\" + scraperData.Username + ".txt", ScraperDataToList(scraperData));

            return scraperData;
        }

        private List<string> ScraperDataToList(TwitterScraperData data)
        {
            var dataToList = new List<string>();
            foreach(var v in data.GetType().GetProperties())
            {
                dataToList.Add("Name: " + v.Name + ", Value: " + v.GetValue(data));
            }
            return dataToList;
        }
    }

}
