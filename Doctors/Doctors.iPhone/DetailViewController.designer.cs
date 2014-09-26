// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Doctors.iPhone
{
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Actor { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Age { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel AgeLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Incarnation { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel IncarnationLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView photo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel StartDate { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel StartDateLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Actor != null) {
				Actor.Dispose ();
				Actor = null;
			}
			if (Age != null) {
				Age.Dispose ();
				Age = null;
			}
			if (AgeLabel != null) {
				AgeLabel.Dispose ();
				AgeLabel = null;
			}
			if (Incarnation != null) {
				Incarnation.Dispose ();
				Incarnation = null;
			}
			if (IncarnationLabel != null) {
				IncarnationLabel.Dispose ();
				IncarnationLabel = null;
			}
			if (photo != null) {
				photo.Dispose ();
				photo = null;
			}
			if (StartDate != null) {
				StartDate.Dispose ();
				StartDate = null;
			}
			if (StartDateLabel != null) {
				StartDateLabel.Dispose ();
				StartDateLabel = null;
			}
		}
	}
}
