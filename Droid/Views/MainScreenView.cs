using Android.App;
using Android.Content;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;
using MvvmNavigationSample.Core.ViewModels;
using Android.OS;
using Android.Views;
using MvvmNavigationSample.Droid.Presenters;
using Cirrious.CrossCore;

namespace MvvmNavigationSample.Droid.Views
{
    [Activity(Label = "Main Screen")]			
    public class MainScreenView : MvxTabActivity
    {
        public new MainScreenViewModel ViewModel
        {
            get { return (MainScreenViewModel)base.ViewModel; }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);

            base.OnCreate(savedInstanceState);
            // Create your application here
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.MainScreen);

            TabHost.TabSpec spec;
            var factory = new TabContentFactory();

            spec = TabHost.NewTabSpec("contacts");
            spec.SetIndicator("Contacts", Resources.GetDrawable(Android.Resource.Drawable.BottomBar, this.Theme));

            spec.SetContent(factory);
            //spec.SetContent(this.CreateIntentFor(ViewModel.ContactsViewModel));
            TabHost.AddTab(spec);

            spec = TabHost.NewTabSpec("favorites");
            spec.SetIndicator("Favorites", Resources.GetDrawable(Android.Resource.Drawable.ButtonStar, this.Theme));
            spec.SetContent(this.CreateIntentFor(ViewModel.FavoritesViewModel));
            TabHost.AddTab(spec);
        }

        class TabContentFactory : TabHost.ITabContentFactory
        {
            #region ITabContentFactory implementation
            public View CreateTabContent(string tag)
            {
                var layout = new FrameLayout(null);

                return layout;
            }
            #endregion
            #region IDisposable implementation
            public void Dispose()
            {
                //do nothing
            }
            #endregion
            #region IJavaObject implementation
            public System.IntPtr Handle
            {
                get
                {
                    throw new System.NotImplementedException();
                }
            }
            #endregion
       }
    }
}

