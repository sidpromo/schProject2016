﻿using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Globalization;
using System.Windows.Data;

namespace projektFeladat_WPF.Converters
{
    class ExamIdToLecturerNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {            
            if (value != null)
            {
                int id = (int)value;
                ServiceClient client = new ServiceClient();
                //var teacher = client.GetExamTeacher(id);
                //return $"{teacher.FirstName} {teacher.MiddleName} {teacher.LastName}";
                return "converter err";
            }
            else return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
