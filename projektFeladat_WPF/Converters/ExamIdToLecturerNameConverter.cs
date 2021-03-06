﻿using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Collections.Generic;
using System.Linq;
using WcfServiceLibrary;

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
                Users teacher = new Users();
                var EUList = client.GetAllExamsUsers().Where(eu => eu.ExamId == id);
                foreach (var item in EUList)
                {                    
                    var usr = client.GetUserById((int)item.UserId);
                    if (usr.UserType.ToUpper()=="TEACHER")
                    {
                        teacher = usr;
                        break;
                    }
                }
                
                return $"{teacher.FirstName} {teacher.MiddleName} {teacher.LastName}";
                //return "converter err";
            }
            else return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
