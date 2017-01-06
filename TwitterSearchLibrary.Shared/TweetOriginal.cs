using System;
using System.Collections.Generic;

namespace TwitterSearch.Shared
{

	public class TweetPlugin
	{
		public ulong StatusID { get; set; }

		public string ScreenName { get; set; }

		public string Text { get; set; }

		public string ImageUrl { get; set; }

		public string MediaUrl { get; set; }
	}


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

