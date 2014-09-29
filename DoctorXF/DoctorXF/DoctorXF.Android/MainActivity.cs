using System;
using System.Globalization;
using System.Threading;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;

namespace DoctorXF.Droid
{
    [Activity(Label = "DoctorXF", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            //Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            SetPage(App.GetMainPage());
        }
    }
}

