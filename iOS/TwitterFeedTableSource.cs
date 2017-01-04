using System;
using UIKit;
using TwitterSearch.Shared;

namespace TwitterSearch.iOS
{
	public class TwitterFeedTableSource : UITableViewSource
	{
		Tweet[] TweetArray;
		string CellIdentifier = "TableCell";

		public TwitterFeedTableSource (Tweet[] tweets)
		{
			TweetArray = tweets;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return TweetArray.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			Tweet tweet = TweetArray[indexPath.Row];
			string content = tweet.content;
			string user = tweet.user;
			string date = tweet.date;

			if (cell == null)
			{ cell = new UITableViewCell(UITableViewCellStyle.Subtitle, CellIdentifier); }

			//cell.TextLabel.ToggleBoldface;
			cell.TextLabel.Text = user;
			cell.DetailTextLabel.Text = content;

			return cell;		
		}
	}
}

