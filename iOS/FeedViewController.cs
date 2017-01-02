using System;

using UIKit;

namespace TwitterSearchiOS
{
	public partial class FeedViewController : UIViewController
	{

		public FeedViewController()
			: base("FeedViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			FeedTableViewSource source = new FeedTableViewSource("Ramen", "Falafel", "Dim Sum", "Fried Chicken", "Champagne", "Burrito");
			twitterFeedTableView.Source = source;

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
