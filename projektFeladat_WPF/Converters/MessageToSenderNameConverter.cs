using System;
using System.Globalization;
using System.ServiceModel;
using System.Windows.Data;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Converters
{
    class MessageToSenderNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Messages msg = (Messages)value;
            if (msg!=null)
            {
                ChannelFactory<IService> channelFactory = new ChannelFactory<IService>("ServiceEndpoint");
                IService service = channelFactory.CreateChannel();

                Users user = service.GetUserById((int)msg.FromUserId);
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
