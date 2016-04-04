using System;

using UIKit;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvvmNavigationSample.Core.ViewModels;
using Cirrious.MvvmCross.Touch.Views;

namespace MvvmNavigationSample.iOS.Views
{
	public partial class RegisterViewController : MvxViewController
	{
		public RegisterViewController() : base("RegisterViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<RegisterViewController, RegisterViewModel>();
			set.Bind(btnRegister).To(vm => vm.RegisterCommand);
			set.Apply();
			Title = ((RegisterViewModel)ViewModel).Title;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


