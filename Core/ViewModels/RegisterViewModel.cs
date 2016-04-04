using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace MvvmNavigationSample.Core.ViewModels
{
	public class RegisterViewModel : BaseViewModel
    {
		public RegisterViewModel()
		{
			Title = "Registration";
		}

		MvxCommand registerCommand;
		public ICommand RegisterCommand
		{
			get
			{
				return registerCommand ?? (registerCommand = new MvxCommand(() => {
					ShowViewModel<Register2ViewModel>();	
				}));
			}
		}
    }
}
