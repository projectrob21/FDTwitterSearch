//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LinqToTwitter;



using System.Diagnostics;



namespace TwitterSearch.Shared
{

	// ORIGINAL BASIC API CALL FORMAT

	//public class TweetRepository : ITweetRepository
	//{
	//	string testURL = "https://api.twitter.com/1.1/statuses/user_timeline.json?oauth_consumer_key=mhMSvHsLgdmVe7UxVY3abssFw&oauth_token=3351338813-GBcOFZKDLgsfJTQpdRQmj5a5HIEEj2EnJpgj00h&oauth_signature_method=HMAC-SHA1&oauth_timestamp=1483483433&oauth_nonce=A43ldc&oauth_version=1.0&oauth_signature=GCjjlUe5KjnfynA4yYjybo4SnGo%3D&screen_name=potus";
	//	public async Task<IEnumerable<TweetOriginal>> TopEntriesAsync()
	//	{

	//		var client = new HttpClient();
	//		var result = await client.GetStringAsync(testURL);

	//		return JsonConvert.DeserializeObject<TweetOriginal>(result).Items;
	//	}
	//}

	//public interface ITweetRepository
	//{
	//	Task<IEnumerable<TweetOriginal>> TopEntriesAsync();
	//}


	public class TweetRepository : INotifyPropertyChanged
	{

		public List<TweetPlugin> _tweets;
		public List<TweetPlugin> Tweets
		{
			get { return _tweets; }
			set
			{
				if (_tweets == value)
					return;

				_tweets = value;
				OnPropertyChanged();
			}
		}

		public TweetRepository()
		{
			Debug.WriteLine("Tweet Repository is running");
			 InitTweetsAsync();
		}

		public async Task InitTweetsAsync()
		{
			Debug.WriteLine("initTweetsAsync is running");

			var auth = new ApplicationOnlyAuthorizer()
			{
				CredentialStore = new InMemoryCredentialStore
				{
					ConsumerKey = "mhMSvHsLgdmVe7UxVY3abssFw",
					ConsumerSecret = "o0cAYqy9JHyuwrOcrnUqlzUfwpF3NvN3PxvzrwHDE0vj39Ynxd",
				},
			};

			Debug.WriteLine("Line 76");
			await auth.AuthorizeAsync();
			Debug.WriteLine("Line 78");
			Debug.WriteLine("AUTH is : {$0}", auth.OAuth2InvalidateToken);
			var ctx = new TwitterContext(auth);
			Debug.WriteLine("CTX is : {$0}", ctx);

			var tweets = await
				(from tweet
			 	in ctx.Status
			 	where tweet.Type == StatusType.User
				   && tweet.ScreenName == "POTUS"
				   && tweet.Count == 3
			 	select tweet)
				.ToListAsync();

			Debug.WriteLine("TWWWEEETTS {$0}", tweets);

			Tweets = 
				(from tweet
				  in tweets
					  select new TweetPlugin
					  {
						  StatusID = tweet.StatusID,
						  ScreenName = tweet.User.ScreenNameResponse,
						  Text = tweet.Text,
						  ImageUrl = tweet.User.ProfileImageUrl,
						  MediaUrl = tweet?.Entities?.MediaEntities?.FirstOrDefault()?.MediaUrl
					  })
				.ToList();


			//Search searchResponse = await
			//    (from search in ctx.Search
			//     where search.Type == SearchType.Search &&
			//           search.Query == "VisualStudio"
			//     select search)
			//    .SingleAsync();

			//Tweets =
			//    (from tweet in searchResponse.Statuses
			//     select new Tweet
			//     {
			//         StatusID = tweet.StatusID,
			//         ScreenName = tweet.User.ScreenNameResponse,
			//         Text = tweet.Text,
			//         ImageUrl = tweet.User.ProfileImageUrl
			//     })
			//    .ToList();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}

}

