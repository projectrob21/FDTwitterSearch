using System;
using UIKit;
using System.Linq;
using System.Linq.Expressions;

namespace TwitterSearchiOS
{
	public class FeedTableViewSource : UITableViewSource
	{
		private string[] _items;
		public FeedTableViewSource(params string[] items)
		{
			_items = items;
		}

	
		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = new UITableViewCell();
			cell.TextLabel.Text = _items[indexPath.Row];
			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return _items.Length;
		}

	}
}

