using System;

using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvvmNavigationSample.Core.ViewModels;

namespace MvvmNavigationSample.iOS.Views
{
	public partial class FavoritesViewController : MvxViewController
	{
		public FavoritesViewController() : base("FavoritesViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<FavoritesViewController, FavoritesViewModel>();
			set.Bind(btnGo).To(vm => vm.Go);
			set.Apply();
			Title = ((FavoritesViewModel)ViewModel).Title;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


