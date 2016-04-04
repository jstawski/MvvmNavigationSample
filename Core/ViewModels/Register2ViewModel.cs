using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using System.Collections.Generic;

namespace MvvmNavigationSample.Core.ViewModels
{
    public class Register2ViewModel : BaseViewModel
    {
		public Register2ViewModel()
		{
			Title = "Register 2";
		}

		MvxCommand nextCommand;
		public ICommand NextCommand
		{
			get
			{
				return nextCommand ?? (nextCommand = new MvxCommand(() => {
					var presentationBundle = new MvxBundle(new Dictionary<string, string> 
					{ 
						{ "NavigationMode", "ClearStack" },
						{ "NavigationVisibility", "true" }
					});

					ShowViewModel<MainScreenViewModel>(presentationBundle: presentationBundle);	
				}));
			}
		}
    }
}
