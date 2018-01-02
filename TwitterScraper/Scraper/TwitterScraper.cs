using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterScraper.Exceptions;

namespace TwitterScraper.Scraper
{
    public interface IScraper
    {
        Task<TwitterScraperData> GetDetails(string ua, string user, double requestTimeout, WebProxy proxy);
    }

    public class MyTwitterScraper : IScraper
    {
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
            TwitterScraperData scraperData = new TwitterScraperData();
            string startUpPath = Application.StartupPath;
            
            if(response.Contains("Sorry, that page"))
            {
                throw new InvalidUsernameException($"Username {username} is not valid");
            }

            string regex;
            string temp;

            // check if account is verified by Twitter
            scraperData.IsUserVerified = response.Contains("/help/verified");

            // get user's username
            regex = "\\(@(.*?)\\) ";
            scraperData.Username = Regex.Match(response, regex).Groups[1].Value;

            // get user's description
            regex = "meta name=\"description\" content=\"(.*?)>";
            temp = Regex.Match(response, regex).Groups[1].Value;

            regex = "\\). (.*?)\"";
            scraperData.UserDescription = Regex.Match(temp, regex).Groups[1].Value;

            // get user's location
            regex = "class=\"ProfileHeaderCard-locationText u-dir\" dir=\"ltr\">\n            (.*?)\n\n      </span>";
            scraperData.UserLocation = Regex.Match(response, regex).Groups[1].Value;
            if(scraperData.UserLocation.Contains("a href"))
            {
                regex = "\">(.*?)<";
                temp = scraperData.UserLocation;
                scraperData.UserLocation = Regex.Match(temp, regex).Groups[1].Value;
            }

            // get user's registration date
            regex = "Joined (.*?)<\\/span>";
            scraperData.UserRegistrationDate = Regex.Match(response, regex).Groups[1].Value;

            // get user's birth date
            regex = "Born on (.*?)\n<\\/span>";
            scraperData.UserBirthDate = Regex.Match(response, regex).Groups[1].Value;

            // get user's amount of medias
            regex = "PhotoRail-headingWithCount js-nav\">\n                \n                (.*?) Photos";
            scraperData.UserAmountOfMedias = Regex.Match(response, regex).Groups[1].Value;

            // get user's amount of tweets
            regex = "Tweets, current page.</span>\n            <span class=\"ProfileNav-value\"  data-count=(.*?) data-is-compact";
            scraperData.UserAmountOfTweets = Regex.Match(response, regex).Groups[1].Value;

            // get user's amount of followings
            regex = "Following</span>\n          <span class=\"ProfileNav-value\" data-count=(.*?) data-is-compact";
            scraperData.UserAmountOfFollowings = Regex.Match(response, regex).Groups[1].Value;

            // get user's amount of followers
            regex = "Followers</span>\n          <span class=\"ProfileNav-value\" data-count=(.*?) data-is-compact";
            scraperData.UserAmountOfFollowers = Regex.Match(response, regex).Groups[1].Value;

            // get user's amount of likes
            regex = "Likes</span>\n          <span class=\"ProfileNav-value\" data-count=(.*?) data-is-compact";

            scraperData.UserAmountOfLikes = String.IsNullOrEmpty(Regex.Match(response, regex).Groups[1].Value)
                                            ? scraperData.UserAmountOfLikes = "0"
                                            : scraperData.UserAmountOfLikes = Regex.Match(response, regex).Groups[1].Value;

            if(!Directory.Exists(startUpPath + "\\logs"))
            {
                Directory.CreateDirectory(startUpPath + "\\logs");
            }

            File.WriteAllLines(startUpPath + "\\logs\\" + scraperData.Username + ".txt", ScraperDataToList(scraperData));

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
