using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Doctors.Models;

namespace Doctors.Android
{
    [Activity(Label = "@string/DetailsTitle", Icon = "@drawable/icon")]
    public class DoctorDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.DoctorDetails);

            var position = Intent.GetIntExtra("position", -1);
            var doctor = DoctorFactory.Doctors[position];

            var photo = FindViewById<ImageView>(Resource.Id.photoImageView);
            var name = FindViewById<TextView>(Resource.Id.nameTextView);
            var incarnation = FindViewById<TextView>(Resource.Id.incarnationTextView);
            var startingDate = FindViewById<TextView>(Resource.Id.startingDateTextView);
            var age = FindViewById<TextView>(Resource.Id.ageTextView);

            if (!String.IsNullOrWhiteSpace(doctor.ImageUrl))
            {
                var ImageUrl = "images/" + doctor.ImageUrl;
                photo.SetImageDrawable(ImageAssetManager.Get(this, ImageUrl));
            }
            name.Text = doctor.Actor;
            incarnation.Text = doctor.Incarnation;

            startingDate.Text = doctor.StartDate.ToShortDateString();
            age.Text = doctor.Age.ToString();
        }
    }
}