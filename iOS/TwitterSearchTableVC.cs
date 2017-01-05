using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using TwitterSearch.Shared;
using UIKit;


namespace TwitterSearch.iOS
{
	public partial class TwitterSearchTableVC : UIViewController
	{

		private TwitterFeedTableSource source;

		//Tweet potus1 = new Tweet("Potus", "I am going to miss this job", "Jan 1st 2017");
		//Tweet potus2 = new Tweet("Potus", "Vacation will be nice though!", "Jan 2nd 2017");

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			source = new TwitterFeedTableSource(Enumerable.Empty<Tweet>());
			Console.WriteLine("TwitterSearchTableVC loaded");
			Console.WriteLine("source = {0}", source);

			twitterTableView = new UITableView(Rectangle.Empty) { Source = source };

				
			//RefreshControl = new UIRefreshControl();
			// built in refresh when you drag down screen


			//Tweet[] tweets = new Tweet[] { potus1, potus2 };
			//TwitterTableView.Source = new TwitterFeedTableSource(tweets);
			//Add(TwitterTableView);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}

		//private async void ReflectControlOnValueChanged(object sender, EventArgs eventArgs)
		//{
		//	await LoadEntriesAsync();
		//	RefreshControl.EndRefreshing();
		//}

		//private async override ViewDidAppear(bool animated)
		//{
		//	base.ViewDidAppear(animated);
		//	await LoadEntriesAsync();
		//}

		//private async Task LoadEntriesAsync()
		//{
		//	var data = await repository.TopEntriesAsync();
		//	source.Entries = new List<Tweet>(data);
		//	TableView.ReloadData();
		//}

	}
}
