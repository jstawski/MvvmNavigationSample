using System;

using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using MvvmNavigationSample.Core;
using MvvmNavigationSample.Core.ViewModels;
using Cirrious.CrossCore;
using MvvmNavigationSample.iOS.Presenters;

namespace MvvmNavigationSample.iOS.Views
{
	public sealed class MainScreenController : MvxTabBarViewController, ITabBarPresenter
	{
		public new MainScreenViewModel ViewModel
		{
			get { return base.ViewModel as MainScreenViewModel; }
		}

		public MainScreenController()
		{
			ViewDidLoad();
			Mvx.Resolve<ITabBarPresenterHost>().TabBarPresenter = this;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			if (ViewModel == null)
			{
				return;
			}
			var viewControllers = new UIViewController[] {	
				CreateTabFor ("Contacts", UITabBarSystemItem.Contacts, ViewModel.ContactsViewModel),
				CreateTabFor ("Favorites", UITabBarSystemItem.Favorites, ViewModel.FavoritesViewModel),
			};
			this.ViewControllers = viewControllers;
			CustomizableViewControllers = new UIViewController[] { };
			SelectedViewController = ViewControllers [0];
			Title = ((MainScreenViewModel)ViewModel).Title;
		}

		public UIViewController CreateTabFor (string title, UITabBarSystemItem systemTab, IMvxViewModel viewModel)
		{
			var controller = new UINavigationController ();
			controller.NavigationBarHidden = false;
			controller.NavigationBar.TintColor = UIColor.Black;
			var screen = this.CreateViewControllerFor (viewModel) as UIViewController;
			screen.Title = title;
			screen.TabBarItem = new UITabBarItem(systemTab, 0);
			//SetTitleAndTabBarItem (screen, title, imageName, selectedImageName);
			controller.PushViewController (screen, false);
			return controller;
		}

		public bool ShowView(IMvxTouchView view)
		{
			if (TryShowViewInCurrentTab(view))
				return true;

			return false;
		}

		private bool TryShowViewInCurrentTab(IMvxTouchView view)
		{
			var navigationController = (UINavigationController)SelectedViewController;
			navigationController.PushViewController((UIViewController)view, true);
			return true;
		}

	}
}


