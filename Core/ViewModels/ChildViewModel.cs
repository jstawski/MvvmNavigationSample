using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace MvvmNavigationSample.Core.ViewModels
{
	public class ChildViewModel : BaseViewModel
	{
		public ChildViewModel()
		{
			Title = "Child";
		}
		MvxCommand goCommand;
		public ICommand Go
		{
			get
			{
				return goCommand ?? (goCommand = new MvxCommand(() => {
					ShowViewModel<GrandChildViewModel>();	
				}));
			}
		}
	}
}

