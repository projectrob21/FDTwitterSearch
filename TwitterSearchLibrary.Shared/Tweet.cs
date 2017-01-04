using System;

namespace TwitterSearch.Shared
{
	public class Tweet
	{

		public string user { get; set; }
		public string content { get; set; }
		public string date { get; set; }

		//public string user, content, date;

		public Tweet(string user, string content, string date)
		{
			this.user = user;
			this.content = content;
			this.date = date;
		}



	}
}

