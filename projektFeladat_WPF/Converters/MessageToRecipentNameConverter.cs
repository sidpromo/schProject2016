using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Globalization;
using System.Windows.Data;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Converters
{
    class MessageToRecipentNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Messages msg = (Messages)value;
            if (msg != null)
            {
                ServiceClient client = new ServiceClient();

                Users user = client.GetUserById((int)msg.ToUserId);
                if (user != null)
                {
                    string name = $"{user.FirstName} {user.MiddleName} {user.LastName}";
                    return name;
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
