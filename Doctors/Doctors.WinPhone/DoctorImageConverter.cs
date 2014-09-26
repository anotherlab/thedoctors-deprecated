using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Doctors.Models;

namespace Doctors.WinPhone
{
    public class DoctorImageConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DoctorActor doctor = value as DoctorActor;
            if (doctor == null) return null;

            var image = new BitmapImage(new Uri("assets/images/" + doctor.ImageUrl, UriKind.Relative));

            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
