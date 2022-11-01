using RestSharp;

namespace RedditLab.Models
{
    public class RedditDAL
    {
        public RedditPost GetPost()
        {
            var client = new RestClient($"https://www.reddit.com/r/aww/.json");
            var request = new RestRequest();
            var response = client.GetAsync<RedditPost>(request);
            RedditPost sp = response.Result;

            return sp;
        }
    }
}
