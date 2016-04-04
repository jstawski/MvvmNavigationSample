using System;

using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvvmNavigationSample.Core.ViewModels;

namespace MvvmNavigationSample.iOS.Views
{
	public partial class ChildViewController : MvxViewController
	{
		public ChildViewController() : base("ChildViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<ChildViewController, ChildViewModel>();
			set.Bind(BtnGo).To(vm => vm.Go);
			set.Apply();

			Title = ((ChildViewModel)ViewModel).Title;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


