using System;
using MonoTouch.Foundation;

namespace Doctors.iPhone
{
	public static class LocalizationExtensions
	{
		public static string t(this string translate)
		{
			return NSBundle.MainBundle.LocalizedString(translate, "", "");
		}
	}
}

