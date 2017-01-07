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

		TweetOriginal potus1 = new TweetOriginal("Potus", "I am going to miss this job", "Jan 1st 2017");
		TweetOriginal potus2 = new TweetOriginal("Potus", "Vacation will be nice though!", "Jan 2nd 2017");

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Console.WriteLine("TwitterSearchTableVC loaded");

			//source = new TwitterFeedTableSource(Enumerable.Empty<TweetOriginal>());
			//Console.WriteLine("source = {0}", source);
			//var repo = new TwitterSearch.Shared.TweetRepository();
			//Console.WriteLine("Repo tweets = {0}", repo._tweets);
		
			twitterTableView = new UITableView(View.Bounds);

				
			//RefreshControl = new UIRefreshControl();
			// built-in refresh for when you drag down screen


			TweetOriginal[] tweets = new TweetOriginal[] { potus1, potus2 };
			twitterTableView.Source = new TwitterFeedTableSource(tweets);
			Add(twitterTableView);
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
