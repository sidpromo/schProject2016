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
    class ExamIdToRegisteredStudentNoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                int id = (int)value;
                ServiceClient client = new ServiceClient();
               int count=0;
                var EUList = client.GetAllExamsUsers().Where(eu => eu.ExamId == id);
                foreach (var item in EUList)
                {
                    var usr = client.GetUserById((int)item.UserId);
                    if (usr.UserType.ToUpper() == "STUDENT")
                    {
                        count++;
                    }
                }
                return count;
            }
            else return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
