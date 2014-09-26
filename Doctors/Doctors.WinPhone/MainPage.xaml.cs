using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Doctors.WinPhone.Resources;

using Doctors;
using Doctors.Models;

namespace Doctors.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            DataContext = App.Doctors;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem == null)
                return;

            NavigationService.Navigate(new Uri("/DetailsPage.xaml?selectedItem=" + (listBox.SelectedIndex.ToString()), UriKind.Relative));

            listBox.SelectedItem = null;
        }
    }
}