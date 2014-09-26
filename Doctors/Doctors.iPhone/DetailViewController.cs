using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Doctors.Models;

namespace Doctors.iPhone
{
    public partial class DetailViewController : UIViewController
    {
        DoctorActor detailItem;
        private UILabel ActorLabel, Actor, IncarnationLabel, Incarnation, StartDateLabel, StartDate, AgeLabel, Age;

        public DetailViewController(IntPtr handle)
            : base(handle)
        {
            float dy = 20f;
            float dyy = 24f;
            float y = 260f;

            var labelsize = 12f;
            var textside = 18f;

            Title = "DetailsTitle".t();


            ActorLabel = MakeLabel("Actor".t(), y, labelsize);
            y += dy;
            Actor = MakeLabel("Actor".t(), y, textside);

            y += dyy;
            IncarnationLabel = MakeLabel("Incarnation".t(), y, labelsize);
            y += dy;
            Incarnation = MakeLabel("Actor".t(), y, textside);

            y += dyy;
            StartDateLabel = MakeLabel("StartDate".t(), y, labelsize);
            y += dy;
            StartDate = MakeLabel("Actor".t(), y, textside);

            y += dyy;
            AgeLabel = MakeLabel("AgeAtStart".t(), y, labelsize);
            y += dy;
            Age = MakeLabel("Actor".t(), y, textside);
        }

        public void SetDetailItem(DoctorActor newDetailItem)
        {
            if (detailItem != newDetailItem)
            {
                detailItem = newDetailItem;

                // Update the view
                ConfigureView();
            }
        }

        private UILabel MakeLabel(string Caption, float y, float size)
        {
            var label = new UILabel()
            {
                Text = Caption,
                Font = UIFont.FromName("TrebuchetMS", size),
                Frame = new RectangleF(10, y, 250, 25)
            };

            View.Add(label);

            return label;
        }

        void ConfigureView()
        {
            // Update the user interface for the detail item
            if (IsViewLoaded && (detailItem != null))
            {
				photo.Image = UIImage.FromBundle("images/" + detailItem.ImageUrl);

                Actor.Text = detailItem.Actor;
                Incarnation.Text = detailItem.Incarnation;
				StartDate.Text = detailItem.StartDate.ToShortDateString ();
				Age.Text = detailItem.Age.ToString ();
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            ConfigureView();
        }
    }
}
