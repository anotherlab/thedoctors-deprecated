using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Doctors.Models;

namespace Doctors.Android
{
    [Activity(Label = "@string/ApplicationTitle", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Title = Resources.GetString(Resource.String.ApplicationTitle);

            var doctorList = FindViewById<ListView>(Resource.Id.doctorListView);

            doctorList.FastScrollEnabled = true;
            doctorList.ItemClick += OnItemClick;

            doctorList.Adapter = new DoctorAdapter(this, DoctorFactory.Doctors);
        }
        void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(this, typeof(DoctorDetailsActivity));

            intent.PutExtra("position", e.Position);

            StartActivity(intent);
        }
    }
}

