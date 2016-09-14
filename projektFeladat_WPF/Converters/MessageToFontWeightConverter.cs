using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Converters
{
    class MessageToFontWeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value!=null)
            {
                Messages msg = (Messages)value;
                FontWeight font = new FontWeight();
                if ((bool)!msg.Read)
                {
                    font = FontWeights.Bold;
                }
                else
                {
                    font = FontWeights.Normal;
                }
                return font;
            }
            return FontWeights.Normal;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
