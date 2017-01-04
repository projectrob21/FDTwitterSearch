using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using TwitterSearch.Shared;

namespace TwitterSearch.iOS
{
	public class TwitterFeedTableSource : UITableViewSource
	{

		public IList<Tweet> Tweets { get; set; }

		public TwitterFeedTableSource(IEnumerable<Tweet> tweets)
		{
			Tweets = new List<Tweet>(tweets);
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
			cell.TextLabel.Text = tweet.user;
			cell.DetailTextLabel.Text = tweet.content;

			return cell;		
		}
	}
}

