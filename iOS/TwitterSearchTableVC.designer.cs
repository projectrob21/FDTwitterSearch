// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TwitterSearch.iOS
{
    [Register ("TwitterSearchTableVC")]
    partial class TwitterSearchTableVC
    {
        [Outlet]
		UIKit.UITableView twitterTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
			if (twitterTableView != null)
			{
				twitterTableView.Dispose();
				twitterTableView = null;
			}
        }
    }
}