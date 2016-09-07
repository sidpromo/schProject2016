using projektFeladat_WPF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    public class ExamManagerWindowViewModel : Bindable
    {
        private IEnumerable<Users> teacherList;

        public IEnumerable<Users> TeacherList
        {
            get { return teacherList; }
            set { teacherList = value;OnPropertyChanged();}
        }

        private IEnumerable<Subjects> subjectList;

        public IEnumerable<Subjects> SubjectList
        {
            get { return subjectList; }
            set { subjectList = value;OnPropertyChanged(); }
        }

        private Exams editedExam;

        public Exams EditedExam
        {
            get { return editedExam; }
            set { editedExam = value;OnPropertyChanged(); }
        }

        private Users selectedTeacher;

        public Users SelectedTeacher
        {
            get { return selectedTeacher; }
            set { selectedTeacher = value;OnPropertyChanged(); }
        }
        private Subjects selectedSubject;

        public Subjects SelectedSubject
        {
            get { return selectedSubject; }
            set { selectedSubject = value;OnPropertyChanged(); }
        }

        public IComparable AddCommand { get; private set; }
        IService _service = new Service();
        public Array ExamType
        {
            get { return Enum.GetValues(typeof(ExamTypes)); }
        }
        public ExamManagerWindowViewModel()
        {
            CommonMethod();
            EditedExam = new Exams();            
        }

        public ExamManagerWindowViewModel(Exams examToEdit)
        {
            CommonMethod();
            EditedExam = examToEdit;
            SelectedSubject = _service.GetAllSubjects().Where(s => s.Id == examToEdit.SubjectID).First();
            
        } 
        void CommonMethod()
        {
            SubjectList = _service.GetAllSubjects();
            TeacherList = _service.GetTeachersFromUsers();
            //TODO: AddCommand=new RelayCommand(..)
        }      

        void Add()
        {
            _service.AddExam(EditedExam);
                
        }
    }
}
