using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using System.Collections.Generic;
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
            set { teacherList = value; OnPropertyChanged(); }
        }

        private Users selectedTeacher;

        public Users SelectedTeacher
        {
            get { return selectedTeacher; }
            set { selectedTeacher = value; OnPropertyChanged(); }
        }

        private Subjects editedSubject;

        public Subjects EditedSubject
        {
            get { return editedSubject; }
            set { editedSubject = value; OnPropertyChanged(); }
        }

        ServiceClient client = new ServiceClient();

        public ICommand SaveCommand { get; private set; }

        void CommonMethods()
        {
            TeacherList = client.GetTeachersFromUsers();
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
            EditedSubject = client.GetSubjectById(subjectToEdit.Id);
            
            //TODO: Betölteni az aktuális tanárt            


        }
        void Add()
        {
            client.AddSubject(EditedSubject);
            client.RegisterUserToSubject(SelectedTeacher, EditedSubject);
        }
        void SaveMethod()
        {
            if (client.GetSubjectById(EditedSubject.Id)==null)
            {
                Add();
            }
            else
            {
                var subject = client.GetSubjectById(EditedSubject.Id);
                if (client.GetSubjectTeacher(EditedSubject)!=SelectedTeacher)
                {
                    client.RegisterUserToSubject(SelectedTeacher, EditedSubject);
                }
                subject = EditedSubject;
                client.UpdateSubject(subject);
                
            }
        }

    }
}
