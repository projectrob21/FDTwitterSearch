using System;
using System.Collections.Generic;

namespace TwitterSearch.Shared
{
	public class TweetOriginal
	{

		public string name { get; set; }
		public string text { get; set; }
		public string date { get; set; }

		//public string user, content, date;

		public TweetOriginal(string user, string content, string date)
		{
			this.name = user;
			this.text = content;
			this.date = date;
		}

		public IEnumerable<TweetOriginal> Items { get; set; }

	}
}

