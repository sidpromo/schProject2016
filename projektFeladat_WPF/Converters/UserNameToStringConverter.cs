using System;
using System.Globalization;
using System.Windows.Data;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Converters
{
    class UserNameToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Users user = (Users)value;
            if (user!=null)
            {
                string name = $"{user.FirstName} {user.MiddleName} {user.LastName}";
                return name;
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
