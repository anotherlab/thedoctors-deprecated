using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Doctors.Models;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Doctors.iPhone
{
    public class DoctorCell : UITableViewCell
    {
        private UILabel ActorLabel, IncarnationLabel, StartDateLabel;
        private UIImageView photo;

        public DoctorCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
        {
            SelectionStyle = UITableViewCellSelectionStyle.Gray;

            photo = new UIImageView()
            {
                ContentMode = UIViewContentMode.ScaleToFill
            };
            ActorLabel = new UILabel()
            {
                Font = UIFont.FromName("TrebuchetMS", 22f),
                BackgroundColor = UIColor.Clear
            };
            IncarnationLabel = new UILabel()
            {
                Font = UIFont.FromName("TrebuchetMS", 12f),
                BackgroundColor = UIColor.Clear
            };
            StartDateLabel = new UILabel()
            {
                TextAlignment = UITextAlignment.Right,
                Font = UIFont.FromName("TrebuchetMS", 12f),
                BackgroundColor = UIColor.Clear
            };

            ContentView.AddSubviews(new UIView[] {ActorLabel, IncarnationLabel, StartDateLabel, photo});
        }

        public void UpdateCell(DoctorActor doctor)
        {
            ActorLabel.Text = doctor.Actor;
            IncarnationLabel.Text = doctor.Incarnation;
            StartDateLabel.Text = doctor.StartDate.ToShortDateString();
            photo.Image = UIImage.FromBundle("images/" + doctor.ImageUrl);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            photo.Frame = new RectangleF(0, 0, 44, 44);

            ActorLabel.Frame = new RectangleF(50, 0, ContentView.Bounds.Width - 50, 25);
            IncarnationLabel.Frame = new RectangleF(50, 20, 80, 25);
            StartDateLabel.Frame = new RectangleF(ContentView.Bounds.Width - 84, 20, 80, 25);
        }

    }
}