using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;
using UIKit;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.CrossCore;

namespace MvvmNavigationSample.iOS
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter)
            : base(applicationDelegate, presenter)
		{
			
		}

		protected override IMvxApplication CreateApp()
		{
			InitializeContainers();
			return new Core.App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		private void InitializeContainers()
		{
			
		}
	}
}