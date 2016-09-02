using Entities;
using Repository;
using System;
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
           Subjects subejct = (Subjects)value;
            IService service = new Service();

            //SubjectsUsers subjUser = new SubjectsUsers();
            //subjUser = subjectUserRepo.GetAll().Where(u => u.SubjectId == subejct.Id).FirstOrDefault();

            //Teachers teacher = new Teachers();
            //teacher = teacherRepo.GetAll().Where(t => t.UserId == subjUser.UserId).FirstOrDefault();
            //if (teacher.UserId != null)
            //{
            //    Users CurrentUser = userRepo.GetAll().Where(u => u.Id == teacher.UserId).FirstOrDefault();
            //    string name = $"{CurrentUser.FirstName} {CurrentUser.MiddleName} {CurrentUser.LastName}";
            //    return name;
            //}

            return "Converter error";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
