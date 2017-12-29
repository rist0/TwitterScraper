using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterScraper
{
    public class TwitterScraperData
    {
        public bool DumpDebugData { get; set; }

        public string Username { get; set; }

        public bool IsUserVerified { get; set; }

        public string UserDescription { get; set; }

        public string UserLocation { get; set; }

        public string UserRegistrationDate { get; set; }

        public string UserBirthDate { get; set; }

        public string UserAmountOfMedias { get; set; }

        public string UserAmountOfTweets { get; set; }

        public string UserAmountOfFollowings { get; set; }

        public string UserAmountOfFollowers { get; set; }

        public string UserAmountOfLikes { get; set; }
    }
}
