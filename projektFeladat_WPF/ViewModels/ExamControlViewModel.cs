using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    public class ExamControlViewModel : Bindable
    {
        private IEnumerable<Exams> examList;

        public IEnumerable<Exams> ExamList
        {
            get { return examList; }
            set { examList = value; OnPropertyChanged(); }
        }

        private IEnumerable<Users> studentList;

        public IEnumerable<Users> StudentList
        {
            get { return studentList; }
            set { studentList = value; OnPropertyChanged(); }
        }

        private Exams selectedExam;

        public Exams SelectedExam
        {
            get { return selectedExam; }
            set { selectedExam = value; OnPropertyChanged(); }
        }

        private Users selectedStudent;

        public Users SelectedUser
        {
            get { return selectedStudent; }
            set { selectedStudent = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand RegisterCommand { get; private set; }
        public ICommand UnregisterCommand { get; private set; }

        IService _service = new Service();
        public ExamControlViewModel()
        {
            RefreshMethod();
        }

        void RefreshMethod()
        {
            ExamList = new List<Exams>();
            StudentList = new List<Users>();
            ExamList = _service.GetAllExams();
            // TODO: StudentList=
        }

        void DeleteMethod()
        {
        }

        void Add()
        {

        }
        void Register()
        {

        }





    }
}
