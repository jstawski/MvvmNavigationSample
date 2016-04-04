using System;
using Cirrious.MvvmCross.Touch.Views;

namespace MvvmNavigationSample.iOS.Presenters
{
	public interface ITabBarPresenter
	{
		bool ShowView(IMvxTouchView view);
	}
}

