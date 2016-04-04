using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmNavigationSample.Droid.Views
{
    [Activity(Label = "Contacts")]
    public class ContactsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ContactsView);
        }
    }
}