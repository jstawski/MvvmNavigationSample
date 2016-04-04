using System;
using Cirrious.MvvmCross.Droid.Views;
using Android.App;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;

namespace MvvmNavigationSample.Droid.Presenters
{
    public class CustomPresenter : MvxAndroidViewPresenter
    {
        private readonly IMvxAndroidViewModelLoader _viewModelLoader;
        private FragmentManager _fragmentManager;

        public CustomPresenter(IMvxAndroidViewModelLoader viewModelLoader)
        {
            _viewModelLoader = viewModelLoader;
        }

        public void RegisterFragmentManager(FragmentManager fragmentManager, MvxFragment initialFragment)  
        {
            _fragmentManager = fragmentManager;

            ShowFragment(initialFragment, false);
        }

        public override void Show(MvxViewModelRequest request)
        {
            if (request.PresentationValues != null)
            {
                if (request.PresentationValues.ContainsKey("NavigationMode") && request.PresentationValues["NavigationMode"] == "ClearStack")
                {
                    Activity.FragmentManager.PopBackStackImmediate(null, PopBackStackFlags.Inclusive);
                }
            }
            base.Show(request);
            //Type fragmentType;
//            if (_fragmentManager == null || !_fragmentTypeLookup.TryGetFragmentType(request.ViewModelType, out fragmentType))
//            {
//                base.Show(request);
//
//                return;
//            }

            //var fragment = (MvxFragment)Activator.CreateInstance(fragmentType);

            //fragment.ViewModel = _viewModelLoader.Load(request, null);
            //fragment.ViewModel = _viewModelLoader.LoadViewModel(request, null);

            //ShowFragment(fragment, true);
        }

        public override void Close(IMvxViewModel viewModel)  
        {
            //var currentFragment = _fragmentManager.FindFragmentById(Resource.Id.tabcontent) as MvxFragment;
//            if (currentFragment != null && currentFragment.ViewModel == viewModel)
//            {
//                _fragmentManager.PopBackStackImmediate();
//
//                return;
//            }

            base.Close(viewModel);
        }

        private void ShowFragment(MvxFragment fragment, bool addToBackStack)  
        {
            var transaction = _fragmentManager.BeginTransaction();

            if (addToBackStack)
                transaction.AddToBackStack(fragment.GetType().Name);

//            transaction
//                .Replace(Resource.Id.tabcontent, fragment)
//                .Commit();
        }
    }
}

