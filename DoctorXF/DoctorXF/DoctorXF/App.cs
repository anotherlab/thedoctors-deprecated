using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using DoctorXF.views;
using Xamarin.Forms;

namespace DoctorXF
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new DoctorsPage());
        }
    }
}
