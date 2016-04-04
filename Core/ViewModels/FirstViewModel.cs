using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using System.Collections.Generic;

namespace MvvmNavigationSample.Core.ViewModels
{
	public class FirstViewModel : BaseViewModel
    {
		public FirstViewModel()
		{
			Title = "Main";
		}

		MvxCommand loginCommand;
		public ICommand Login
		{
			get
			{
				return loginCommand ?? (loginCommand = new MvxCommand(() => {
					var presentationBundle = new MvxBundle(new Dictionary<string, string> 
					{ 
						{ "NavigationMode", "ClearStack" },
						{ "NavigationVisibility", "true" }
					});
					ShowViewModel<MainScreenViewModel>(presentationBundle: presentationBundle);	
				}));
			}
		}

		MvxCommand registerCommand;
		public ICommand RegisterCommand
		{
			get
			{
				return registerCommand ?? (registerCommand = new MvxCommand(() => {
					ShowViewModel<RegisterViewModel>();	
				}));
			}
		}
    }
}
