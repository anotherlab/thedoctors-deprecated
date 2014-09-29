using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorXF.Data;
using Xamarin.Forms;

namespace DoctorXF.views
{
    public partial class DoctorsPage : ContentPage
    {
        public DoctorsPage()
        {
            BindingContext = DoctorFactory.Doctors;


            InitializeComponent();
        }

        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            DoctorActor doctor = e.Item as DoctorActor;

            await this.Navigation.PushAsync(new DetailsPage(doctor));
        }

    }
}
