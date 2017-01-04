using System;
using UIKit;

namespace TwitterSearch.iOS
{
	public partial class ViewController : UIViewController
	{

		Tweet potus1 = new Tweet("Potus", "I am going to miss this job");
		Tweet potus2 = new Tweet("Potus", "Vacation will be nice though!");

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			TwitterTableView = new UITableView(View.Bounds);
			Tweet[] tweets = new Tweet[] { potus1, potus2 };
			TwitterTableView.Source = new TwitterFeedTableSource(tweets);
			Add(TwitterTableView);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}

	}
}
