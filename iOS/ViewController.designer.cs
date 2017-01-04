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
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
		UIKit.UITableView TwitterTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
			if (TwitterTableView != null)
			{
				TwitterTableView.Dispose();
				TwitterTableView = null;
			}
        }
    }
}