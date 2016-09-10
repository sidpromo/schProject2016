using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Globalization;
using System.Windows.Data;
using WcfServiceLibrary;

namespace projektFeladat_WPF.Converters
{
    class SubjectToTeacherNameConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Subjects subject = (Subjects)value;

            if (subject!=null)
            {
                ServiceClient service = new ServiceClient();
                var teacher = service.GetSubjectTeacher(subject);
                if (teacher!=null)
                {
                    return $"{teacher.FirstName} {teacher.MiddleName} {teacher.LastName}";  
                }
            }
            return "SubjectToTeacherName error";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
