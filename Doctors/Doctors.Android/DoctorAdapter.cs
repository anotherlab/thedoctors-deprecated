using System;
using Android.Widget;
using Android.App;
using System.Collections.Generic;
using Android.Views;
using System.IO;
using Doctors.Models;

namespace Doctors.Android
{
    public class DoctorAdapter : BaseAdapter<DoctorActor>
    {
        Activity context;
        List<DoctorActor> doctors;
        public DoctorAdapter(Activity context, List<DoctorActor> doctors)
        {
            this.context = context;
            this.doctors = doctors;
        }
        public override DoctorActor this[int position]
        {
            get
            {
                return doctors[position];
            }
        }

        public override int Count
        {
            get
            {
                return doctors.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.DoctorRow, parent, false);

                var p = view.FindViewById<ImageView>(Resource.Id.photoImageView);
                var n = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var s = view.FindViewById<TextView>(Resource.Id.incarnationTextView);
                var d = view.FindViewById<TextView>(Resource.Id.startingDateTextView);

                view.Tag = new ViewHolder() { Photo = p, Name = n, Incarnation = s, StartingDate = d};
            }

            var holder = (ViewHolder)view.Tag;

            if (!String.IsNullOrWhiteSpace(doctors[position].ImageUrl))
            {
                holder.Photo.SetImageDrawable(ImageAssetManager.Get(context, "images/" + doctors[position].ImageUrl));
            }

            holder.Name.Text = doctors[position].Actor;
            holder.Incarnation.Text = doctors[position].Incarnation;
            holder.StartingDate.Text = doctors[position].StartDate.ToString("MMMM yyyy");

            return view;
        }

    }
}