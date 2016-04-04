using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace MvvmNavigationSample.Core.ViewModels
{
	public class ContactsViewModel : BaseViewModel
	{
		public ContactsViewModel()
		{
			Title = "Contacts";
		}
		MvxCommand goCommand;
		public ICommand Go
		{
			get
			{
				return goCommand ?? (goCommand = new MvxCommand(() => {
					ShowViewModel<ChildViewModel>();	
				}));
			}
		}
	}
}

