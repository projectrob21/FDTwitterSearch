using System;
using System.Collections.Generic;

using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitterSearch.Shared
{

	public class TweetRepository : ITweetRepository
	{
		public async Task<IEnumerable<Tweet>> TopEntriesAsync()
		{
			var client = new HttpClient();

		}
	}

	public interface ITweetRepository
	{
		Task<IEnumerable<Tweet>> TopEntriesAsync();
	}
}

