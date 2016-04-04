using System;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace MvvmNavigationSample.Core.ViewModels
{
	public class FavoritesViewModel : BaseViewModel
	{
		public FavoritesViewModel()
		{
			Title = "Favorites";
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

