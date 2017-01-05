using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using TwitterSearch.Shared;

namespace TwitterSearch.iOS
{
	public class TwitterFeedTableSource : UITableViewSource
	{

		public IList<TweetOriginal> Tweets { get; set; }

		public TwitterFeedTableSource(IEnumerable<TweetOriginal> tweets)
		{
			Tweets = new List<TweetOriginal>(tweets);
		}

		string CellIdentifier = "TableCell";

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return Tweets.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{

			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			if (cell == null)
			{ cell = new UITableViewCell(UITableViewCellStyle.Subtitle, CellIdentifier); }

			var tweet = Tweets[indexPath.Row];
			cell.TextLabel.Text = tweet.name;
			cell.DetailTextLabel.Text = tweet.text;

			return cell;		
		}
	}
}

