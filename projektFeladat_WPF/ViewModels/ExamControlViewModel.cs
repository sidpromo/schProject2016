using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using projektFeladat_WPF.Views;
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

        ServiceClient client = new ServiceClient();
        public ExamControlViewModel()
        {
            RefreshMethod();
            AddCommand = new RelayCommand(Add);
        }

        void RefreshMethod()
        {
            ExamList = new List<Exams>();
            StudentList = new List<Users>();
            ExamList = client.GetAllExams();
            StudentList = client.GetExamStudents(SelectedExam.Id);
            // TODO: StudentList=
        }

        void DeleteMethod()
        {
        }

        void Add()
        {
            ExamManagerWindow newWindow = new ExamManagerWindow();
            newWindow.Show();
        }
        void Register()
        {

        }





    }
}
