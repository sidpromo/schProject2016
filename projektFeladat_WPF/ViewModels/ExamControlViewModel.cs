using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace projektFeladat_WPF.ViewModels
{
    public class ExamControlViewModel : Bindable
    {
        private IEnumerable<Exams> examList;

        public IEnumerable<Exams> ExamList
        {
            get { return examList; }
            set { examList = value;OnPropertyChanged(); }
        }

        private IEnumerable<Users> studentList;

        public IEnumerable<Users> StudentList
        {
            get { return studentList; }
            set { studentList = value;OnPropertyChanged(); }
        }

        private Users selectedStudent;

        public Users SelectedStudent
        {
            get { return selectedStudent; }
            set { selectedStudent = value;OnPropertyChanged(); }
        }

        private Exams selectedExam;

        public Exams SelectedExam
        {
            get { return selectedExam; }
            set { selectedExam = value;OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public ExamControlViewModel()
        {

        }
    }

    
}
