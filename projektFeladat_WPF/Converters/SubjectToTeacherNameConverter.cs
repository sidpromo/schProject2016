using Repository;
using Repository.UserRepos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace projektFeladat_WPF.Converters
{
    class SubjectToTeacherNameConverter : IValueConverter
    {
        static EducationDatabaseEntities ent = new EducationDatabaseEntities();
        static SubjectsRepository subjectRepo = new SubjectsRepository(ent);
        static SubjectsUsersRepository subjectUserRepo = new SubjectsUsersRepository(ent);
        static TeachersRepository teacherRepo = new TeachersRepository(ent);
        static UsersRepository userRepo = new UsersRepository(ent); 

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Subjects subejct = (Subjects)value;

            SubjectsUsers subjUser = new SubjectsUsers();
            subjUser = subjectUserRepo.GetAll().Where(u => u.SubjectId == subejct.Id).FirstOrDefault();

            Teachers teacher = new Teachers();
            teacher = teacherRepo.GetAll().Where(t => t.UserId == subjUser.UserId).FirstOrDefault();

           Users CurrentUser = userRepo.GetAll().Where(u => u.Id == teacher.UserId).FirstOrDefault();
           string name = $"{CurrentUser.FirstName} {CurrentUser.MiddleName} {CurrentUser.LastName}";

            return name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
