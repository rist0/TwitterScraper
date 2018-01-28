using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace TwitterScraper.Scraper
{
    class TwitterHtmlParser
    {
        private readonly HtmlDocument _htmlDocument;

        public TwitterHtmlParser(string response)
        {
            try
            {
                _htmlDocument = new HtmlDocument();
                _htmlDocument.LoadHtml(response);
            }
            catch (Exception)
            {
                throw new Exception("Failed to load HTML document.");
            }
        }

        internal string GetRegistrationDate()
        {
            try
            {
                var registrationDate = _htmlDocument.DocumentNode
                    .SelectSingleNode(".//span[@class=\"ProfileHeaderCard-joinDateText js-tooltip u-dir\"]")
                    .Attributes["title"]
                    .Value;

                return registrationDate;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetBirthDate()
        {
            try
            {
                var birthDate = _htmlDocument.DocumentNode
                    .SelectSingleNode(".//span[@class=\"ProfileHeaderCard-birthdateText u-dir\"]")
                    .InnerText
                    .Trim();

                return birthDate.Replace("Born on", "").Trim();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetUserMediaCount()
        {
            try
            {
                var mediaCount = _htmlDocument.DocumentNode
                    .SelectSingleNode(".//a[@class=\"PhotoRail-headingWithCount js-nav\"]")
                    .InnerText
                    .Trim();

                return new string(mediaCount.Where(Char.IsDigit).ToArray());
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetTweetsCount()
        {
            try
            {
                var tweetCount = _htmlDocument.DocumentNode
                    .SelectSingleNode(
                        "//*[contains(@class, \"ProfileNav-item--tweets\")]/a/span[@class=\"ProfileNav-value\"]")
                    .Attributes["data-count"]
                    .Value;

                return tweetCount;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetFollowersCount()
        {
            try
            {
                var followersCount = _htmlDocument.DocumentNode
                    .SelectSingleNode(
                        "//*[contains(@class, \"ProfileNav-item--followers\")]/a/span[@class=\"ProfileNav-value\"]")
                    .Attributes["data-count"]
                    .Value;

                return followersCount;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetFollowingsCount()
        {
            try
            {
                var followingsCount = _htmlDocument.DocumentNode
                    .SelectSingleNode(
                        "//*[contains(@class, \"ProfileNav-item--following\")]/a/span[@class=\"ProfileNav-value\"]")
                    .Attributes["data-count"]
                    .Value;

                return followingsCount;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetLikesCount()
        {
            try
            {
                var likesCount = _htmlDocument.DocumentNode
                    .SelectSingleNode(
                        "//*[contains(@class, \"ProfileNav-item--favorites\")]/a/span[@class=\"ProfileNav-value\"]")
                    .Attributes["data-count"]
                    .Value;

                return likesCount;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetLocation()
        {
            try
            {
                var location = _htmlDocument.DocumentNode
                    .SelectSingleNode(".//span[@class=\"ProfileHeaderCard-locationText u-dir\"]")
                    .InnerText
                    .Trim();

                return location;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetUsername()
        {
            try
            {
                var username = _htmlDocument.DocumentNode
                    .SelectSingleNode(".//b[@class=\"u-linkComplex-target\"]")
                    .InnerText
                    .Trim();

                return username;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        internal string GetDescription()
        {
            try
            {
                var description = _htmlDocument.DocumentNode
                    .SelectSingleNode(".//p[@class=\"ProfileHeaderCard-bio u-dir\"]")
                    .InnerText
                    .Trim();

                return WebUtility.HtmlDecode(description);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
