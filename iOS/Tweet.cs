using System;

namespace TwitterSearch.iOS
{
	public class Tweet
	{

		private string user, content;

		public Tweet(string user, string content)
		{
			this.user = user;
			this.content = content;
		}

		public string Content
		{
			get { return content; }
		}

		public string User
		{
			get { return user; }
		}
	}
}

