using System;

using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvvmNavigationSample.Core.ViewModels;

namespace MvvmNavigationSample.iOS.Views
{
	public partial class Register2ViewController : MvxViewController
	{
		public Register2ViewController() : base("Register2ViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<Register2ViewController, Core.ViewModels.Register2ViewModel>();
			set.Bind(btnNext).To(vm => vm.NextCommand);
			Title = ((Register2ViewModel)ViewModel).Title;
			set.Apply();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


