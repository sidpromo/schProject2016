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
            int id = (int)value;
            return client.GetSubjectById(id).SubjectName;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
