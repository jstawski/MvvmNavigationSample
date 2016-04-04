using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmNavigationSample.Droid.Views
{
    [Activity(Label = "Registration 2")]
    public class Register2View : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Register2View);
        }
    }
}