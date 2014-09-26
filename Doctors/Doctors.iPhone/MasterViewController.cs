using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Doctors.Models;

namespace Doctors.iPhone
{
    public partial class MasterViewController : UITableViewController
    {
        private List<DoctorActor> doctors;

        DataSource dataSource;

        public MasterViewController(IntPtr handle)
            : base(handle)
        {
            Title = NSBundle.MainBundle.LocalizedString("Master", "Master");

            // Custom initialization
        }


        //void AddNewItem(object sender, EventArgs args)
        //{
        //    dataSource.Objects.Insert(0, DateTime.Now);

        //    using (var indexPath = NSIndexPath.FromRowSection(0, 0))
        //        TableView.InsertRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Automatic);
        //}

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
            //NavigationItem.LeftBarButtonItem = EditButtonItem;

            //var addButton = new UIBarButtonItem(UIBarButtonSystemItem.Add, AddNewItem);
            //NavigationItem.RightBarButtonItem = addButton;


			doctors = DoctorFactory.Doctors;

            TableView.Source = dataSource = new DataSource(doctors, this);
        }

        class DataSource : UITableViewSource
        {
			static readonly NSString CellIdentifier = new NSString("DoctorCell");
            //static readonly NSString CellIdentifier = new NSString("Cell");
            readonly List<DoctorActor> objects = new List<DoctorActor>();
            readonly MasterViewController controller;

            public DataSource(List<DoctorActor> objects, MasterViewController controller)
            {
                this.objects = objects;
                this.controller = controller;
            }

            public IList<DoctorActor> Objects
            {
                get { return objects; }
            }
            // Customize the number of sections in the table view.
            public override int NumberOfSections(UITableView tableView)
            {
                return 1;
            }

            public override int RowsInSection(UITableView tableview, int section)
            {
                return objects.Count;
            }
            // Customize the appearance of table view cells.
//            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
//            {
//                var cell = (UITableViewCell)tableView.DequeueReusableCell(CellIdentifier, indexPath);
//
//                cell.TextLabel.Text = objects[indexPath.Row].Actor;
//
//                return cell;
//            }

			public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell (CellIdentifier) as DoctorCell;

				if (cell == null) {
					cell = new DoctorCell(CellIdentifier);
				}
				var speaker = objects [indexPath.Row];

                cell.UpdateCell(speaker);

				return cell;
			}
            //public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            //{
            //    var cell = tableView.DequeueReusableCell(CellIdentifier);

            //    if (cell == null)
            //    {
            //        cell = new UITableViewCell(UITableViewCellStyle.Subtitle, CellIdentifier);
            //    }
            //    var speaker = objects[indexPath.Row];

            //    cell.TextLabel.Text = speaker.Actor;
            //    cell.DetailTextLabel.Text = speaker.Incarnation;

            //    cell.ImageView.Image = UIImage.FromBundle("images/" + speaker.ImageUrl);

            //    return cell;
            //}

			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
			{
				// Take action based on the Section
				controller.PerformSegue ("showDetail", controller);
			}

            public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
            {
                // Return false if you do not want the specified item to be editable.
                return false;
            }

            public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
            {
                if (editingStyle == UITableViewCellEditingStyle.Delete)
                {
                    // Delete the row from the data source.
                    objects.RemoveAt(indexPath.Row);
                    controller.TableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
                }
                else if (editingStyle == UITableViewCellEditingStyle.Insert)
                {
                    // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view.
                }
            }
            /*
            // Override to support rearranging the table view.
            public override void MoveRow (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
            {
            }
            */
            /*
            // Override to support conditional rearranging of the table view.
            public override bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
            {
                // Return false if you do not want the item to be re-orderable.
                return true;
            }
            */
        }


        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "showDetail")
            {
                var indexPath = TableView.IndexPathForSelectedRow;
                var item = dataSource.Objects[indexPath.Row];

                ((DetailViewController)segue.DestinationViewController).SetDetailItem(item);
            }
        }
    }
}
