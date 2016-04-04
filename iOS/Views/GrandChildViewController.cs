using System;

using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using MvvmNavigationSample.Core.ViewModels;

namespace MvvmNavigationSample.iOS.Views
{
	public partial class GrandChildViewController : MvxViewController
	{
		public GrandChildViewController() : base("GrandChildViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			Title = ((GrandChildViewModel)ViewModel).Title;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


