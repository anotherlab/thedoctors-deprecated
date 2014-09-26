using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Doctors.Models;

namespace Doctors.iPhone
{
    public class DoctorsTableSource : UITableViewSource
    {
        List<DoctorActor> data;
        UITableViewController controller;

        public DoctorsTableSource(List<DoctorActor> doctors, UITableViewController tvc)
        {
            data = doctors;
            controller = tvc;
            
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            throw new NotImplementedException();
        }

        public override int RowsInSection(UITableView tableview, int section)
        {
            return data.Count;
        }


        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            // Navigation to the next screen by pushing a a new instance of SpeakerViewController passing info from the row selected
            var speaker = data[indexPath.Row];

            //controller.NavigationController.PushViewController(new SpeakerViewController(speaker), true);

            tableView.DeselectRow(indexPath, true);
        }

    }
}