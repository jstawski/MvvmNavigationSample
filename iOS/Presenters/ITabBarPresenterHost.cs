using System;

namespace MvvmNavigationSample.iOS.Presenters
{
	public interface ITabBarPresenterHost
	{
		ITabBarPresenter TabBarPresenter { get; set; }
	}
}

