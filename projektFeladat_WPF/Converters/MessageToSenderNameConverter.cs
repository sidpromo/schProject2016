using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Globalization;
using System.Windows.Data;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Converters
{
    class MessageToSenderNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {            
            if (value!=null)
            {
                int? id = (int?)value;
                ServiceClient service = new ServiceClient();
                Users user = service.GetUserById((int)id);
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
