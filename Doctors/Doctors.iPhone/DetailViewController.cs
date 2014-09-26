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

        public DetailViewController(IntPtr handle)
            : base(handle)
        {
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

        void ConfigureView()
        {
            // Update the user interface for the detail item
            if (IsViewLoaded && (detailItem != null))
            {
				photo.Image = UIImage.FromBundle("images/" + detailItem.ImageUrl);

				//ActorLabel.Text = "Actor".t();
                this.Actor.Text = detailItem.Actor;

				//IncarnationLabel.Text = "Incarnation".t();
                Incarnation.Text = detailItem.Incarnation;

				StartDateLabel.Text = "Start Date".t();
				this.StartDate.Text = detailItem.StartDate.ToShortDateString ();

				this.Age.Text = detailItem.Age.ToString ();
				AgeLabel.Text = "Starting Age".t ();
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
