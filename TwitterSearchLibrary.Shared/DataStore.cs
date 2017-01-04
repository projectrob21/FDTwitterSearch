using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitterSearch.Shared
{

	public class TweetRepository : ITweetRepository
	{
		string testURL = "https://api.twitter.com/1.1/statuses/user_timeline.json?oauth_consumer_key=mhMSvHsLgdmVe7UxVY3abssFw&oauth_token=3351338813-GBcOFZKDLgsfJTQpdRQmj5a5HIEEj2EnJpgj00h&oauth_signature_method=HMAC-SHA1&oauth_timestamp=1483483433&oauth_nonce=A43ldc&oauth_version=1.0&oauth_signature=GCjjlUe5KjnfynA4yYjybo4SnGo%3D&screen_name=potus";
		public async Task<IEnumerable<Tweet>> TopEntriesAsync()
		{
			var client = new HttpClient();
			var result = await client.GetStringAsync(testURL);
			return JsonConvert.DeserializeObject<Tweet>(result).Items;
		}
	}

	public interface ITweetRepository
	{
		Task<IEnumerable<Tweet>> TopEntriesAsync();
	}
}

