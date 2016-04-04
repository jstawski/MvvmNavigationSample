// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvvmNavigationSample.iOS.Views
{
	[Register ("ChildViewController")]
	partial class ChildViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton BtnGo { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (BtnGo != null) {
				BtnGo.Dispose ();
				BtnGo = null;
			}
		}
	}
}
