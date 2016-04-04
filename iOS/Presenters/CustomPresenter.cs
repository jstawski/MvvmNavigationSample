using System;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using MvvmNavigationSample.iOS.Presenters;

namespace MvvmNavigationSample.iOS.Presenters
{
	public class CustomPresenter : MvxModalSupportTouchViewPresenter, ITabBarPresenterHost
	{
		public CustomPresenter(UIApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}

		protected override UINavigationController CreateNavigationController(UIViewController viewController)
		{
			var toReturn = base.CreateNavigationController(viewController);
			return toReturn;
		}

		public ITabBarPresenter TabBarPresenter { get; set; }

		public override void Show(IMvxTouchView view)
		{
			if (TabBarPresenter != null && view != TabBarPresenter)
			{
				TabBarPresenter.ShowView(view);
				return;
			}

			base.Show(view);
		}

		public override void Show(MvxViewModelRequest request)
		{
			if (request.PresentationValues != null)
			{
				if (request.PresentationValues.ContainsKey("NavigationMode") && request.PresentationValues["NavigationMode"] == "ClearStack")
				{
					MasterNavigationController.PopToRootViewController(false);
				}
				if (request.PresentationValues.ContainsKey("NavigationVisibility"))
				{
					var visibility = request.PresentationValues["NavigationVisibility"];

					MasterNavigationController.NavigationBarHidden = String.Equals(visibility, "true", StringComparison.OrdinalIgnoreCase);
				}
			}
			base.Show(request);
		}
	}
}

