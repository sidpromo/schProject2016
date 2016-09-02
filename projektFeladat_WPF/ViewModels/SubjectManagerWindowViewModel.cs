using Repository;
using Repository.UserRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
   public class SubjectManagerWindowViewModel : Bindable
    {
        private IEnumerable<Users> teacherList;

        public IEnumerable<Users> TeacherList
        {
            get { return teacherList; }
            set { teacherList = value;OnPropertyChanged(); }
        }

        private Users selectedTeacher;

        public Users SelectedTeacher
        {
            get { return selectedTeacher; }
            set { selectedTeacher = value;OnPropertyChanged(); }
        }

        private Subjects editedSubject;

        public Subjects EditedSubject
        {
            get { return editedSubject; }
            set { editedSubject = value;OnPropertyChanged(); }
        }

        //static EducationDatabaseEntities ent = new EducationDatabaseEntities();
        //ISubjectsRepository subjectRepo = new SubjectsRepository(ent);
        //IUsersRepository userRepo = new UsersRepository(ent);

        IService _service = new Service();

        public ICommand SaveCommand { get; private set; }

        public SubjectManagerWindowViewModel()
        {
            //TeacherList = _service();
        }

    }
}
