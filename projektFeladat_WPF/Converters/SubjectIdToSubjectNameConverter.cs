using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Globalization;
using System.Windows.Data;

namespace projektFeladat_WPF.Converters
{
    class SubjectIdToSubjectNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ServiceClient client = new ServiceClient();
            if (value!=null)
            {
                int id = (int)value;
                return client.GetSubjectById(id).SubjectName; 
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
