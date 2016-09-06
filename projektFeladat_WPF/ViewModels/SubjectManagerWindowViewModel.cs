using projektFeladat_WPF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        int idToRemove=0;

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
            EditedSubject = new Subjects();
            EditedSubject = _service.GetSubjectById(subjectToEdit.Id);
            //TODO: Betölteni az aktuális tanárt            
            idToRemove = subjectToEdit.Id;
            
        }
        void Add()
        {
            if (idToRemove!=0)
            {
                _service.RemoveSubjectById(idToRemove);
            }
            
            _service.AddSubject(EditedSubject);            
            _service.RegisterUserToSubject(SelectedTeacher, EditedSubject);
            //TODO: Regisztrálni tanárt hozzá!!!!
            
        }
        void SaveMethod()
        {
            Add();
            EditedSubject = new Subjects();
        }

    }
}
