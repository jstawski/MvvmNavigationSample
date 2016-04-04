using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmNavigationSample.Droid.Views
{
    [Activity(Label = "Registration")]
    public class RegisterView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RegisterView);
        }
    }
}