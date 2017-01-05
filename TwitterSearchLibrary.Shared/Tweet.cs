using System;
using System.Collections.Generic;

namespace TwitterSearch.Shared
{
	public class Tweet
	{

		public string name { get; set; }
		public string text { get; set; }
		public string date { get; set; }

		//public string user, content, date;

		public Tweet(string user, string content, string date)
		{
			this.name = user;
			this.text = content;
			this.date = date;
		}

		public IEnumerable<Tweet> Items { get; set; }

	}
}

