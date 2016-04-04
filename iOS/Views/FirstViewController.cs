using System;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvvmNavigationSample.Core.ViewModels;

namespace MvvmNavigationSample.iOS.Views
{
	public partial class FirstViewController : MvxViewController
	{
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			var set = this.CreateBindingSet<FirstViewController, FirstViewModel>();
			set.Bind(btnLogin).To(vm => vm.Login);
			set.Bind(btnRegister).To(vm => vm.RegisterCommand);
			set.Apply();

			Title = ((FirstViewModel)ViewModel).Title;
		}

	}
}


