using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace projektFeladat_WPF.Converters
{
    class ExamIdToLecturerNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id = (int)value;
            ServiceClient client = new ServiceClient();
            var teacher = client.GetExamTeacher(id);           
            return $"{teacher.FirstName} {teacher.MiddleName} {teacher.LastName}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
