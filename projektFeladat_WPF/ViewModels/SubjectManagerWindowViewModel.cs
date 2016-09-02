using Entities;
using projektFeladat_WPF.Commands;
using Repository;
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

        IService _service = new Service();

        public ICommand SaveCommand { get; private set; }

        void CommonMethods()
        {
            TeacherList = _service.GetTeachersFromUsers();
            SaveCommand = new RelayCommand(SaveMethod);
        }

        public SubjectManagerWindowViewModel()
        {
            CommonMethods();
            EditedSubject = new Subjects();
        }
       
        public SubjectManagerWindowViewModel(Subjects subjectToEdit)
        {
            CommonMethods();
            EditedSubject = subjectToEdit;
            _service.RemoveSubject(_service.GetSubjectById(subjectToEdit.Id));
        }
        void Add()
        {
            _service.AddSubject(EditedSubject);
            //TODO: Regisztrálni tanárt hozzá!!!!
        }
        void SaveMethod()
        {
            Add();
            EditedSubject = new Subjects();
        }

    }
}
