using System;
using Cirrious.MvvmCross.ViewModels;

namespace MvvmNavigationSample.Core.ViewModels
{
	public class MainScreenViewModel : BaseViewModel
	{
		public MainScreenViewModel()
		{
			ContactsViewModel = new ContactsViewModel();
			FavoritesViewModel = new FavoritesViewModel();
			Title = "Home";
		}

		public ContactsViewModel ContactsViewModel
		{
			get;
			set;
		}
		public FavoritesViewModel FavoritesViewModel
		{
			get;
			set;
		}
	}
}

