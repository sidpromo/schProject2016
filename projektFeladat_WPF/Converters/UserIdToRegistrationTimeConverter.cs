using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace projektFeladat_WPF.Converters
{
    class UserIdToRegistrationTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id = (int)value;
            ServiceClient client =new ServiceClient();
            return client.GetAllExamsUsers().Where(u => u.UserId == id).First().InsertDate;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
