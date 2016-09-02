using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    class SubjectControlViewModel : Bindable
    {
        private IEnumerable<Subjects> subjectList;

        public IEnumerable<Subjects> SubjectList
        {
            get { return subjectList; }
            set { subjectList = value; OnPropertyChanged(); }
        }

        private Subjects _selectedItem;

        public Subjects SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }
        private string teachername;

        public string TeacherName
        {
            get { return teachername; }
            set { teachername = value;OnPropertyChanged(); }
        }


        public SubjectsUsers CurrentSubjectUser { get; private set; }
        //public Teachers CurrentTeacher { get; private set; }
        public Users CurrentUser { get; private set; }



        //static EducationDatabaseEntities ent = new EducationDatabaseEntities();
        //static SubjectsRepository subjectRepo = new SubjectsRepository(ent);
        //static SubjectsUsersRepository subjectUserRepo = new SubjectsUsersRepository(ent);
        //static TeachersRepository teacherRepo = new TeachersRepository(ent);
        //static UsersRepository userRepo = new UsersRepository(ent);       
        IService _service = new Service();
      
        public SubjectControlViewModel()
        {
            SubjectList = _service.GetAllSubjects();
            
            
        }

    }
}
