using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using DoctorXF.Data;
using DoctorXF.Resources;
using Xamarin.Forms;
using DoctorXF;

namespace DoctorXF.views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(DoctorActor doctor)
        {
            this.Title = LocalizationResources.DetailsTitle;  // Does not work
            BindingContext = doctor;
            InitializeComponent();
        }
    }
}
