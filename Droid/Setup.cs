using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;
using MvvmNavigationSample.Droid.Presenters;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmNavigationSample.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override Cirrious.MvvmCross.Droid.Views.IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var presenter = Mvx.IocConstruct<CustomPresenter>();

            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(presenter);

            return presenter;
        }

        protected override void InitializeIoC()
        {
            base.InitializeIoC();

            //Mvx.ConstructAndRegisterSingleton<IFragmentTypeLookup, FragmentTypeLookup>();
        }
    }
}