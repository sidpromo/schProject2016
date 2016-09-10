﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                IService service = new Service();
                string name = service.GetSubjectTeacher(subject);

                if (name != null)
                {
                    return name;
                }

            }
            return "Converter error";
            ////////////////////////////////////////


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
