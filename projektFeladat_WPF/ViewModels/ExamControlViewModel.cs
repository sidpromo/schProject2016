﻿using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using projektFeladat_WPF.Views;
using System.Collections.Generic;
using System.Linq;
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
            set { selectedExam = value; OnPropertyChanged();OnPropertyChanged("StudentList"); }
        }

        private Users selectedStudent;

        public Users SelectedStudent
        {
            get { return selectedStudent; }
            set { selectedStudent = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand RegisterCommand { get; private set; }
        public ICommand UnregisterCommand { get; private set; }
        public ICommand RefreshCommand { get; private set; }
        public ICommand GenerateCommand { get; private set; }
        public ICommand ShowCommand { get; private set; }

        ServiceClient client = new ServiceClient();
        public ExamControlViewModel()
        {
            RefreshMethod();
            AddCommand = new RelayCommand(AddMethod);
            RefreshCommand = new RelayCommand(RefreshMethod);
            EditCommand = new RelayCommand(EditMethod);
            DeleteCommand = new RelayCommand(DeleteMethod);
            RegisterCommand = new RelayCommand(RegisterMethod);
            UnregisterCommand = new RelayCommand(UnregisterMethod);
            GenerateCommand = new RelayCommand(GenerateRandExamMethod);
            ShowCommand = new RelayCommand(ShowMethod);
        }

        void RefreshMethod()
        {
            ExamList = new List<Exams>();           
            ExamList = client.GetAllExams();
        }

        List<Users> GetStudentList()
        {
            List<Users> userList = new List<Users>();
            var list = client.GetAllExamsUsers().Where(u => u.ExamId == SelectedExam.Id);
            foreach (var item in list)
            {
                var usr = client.GetUserById((int)item.UserId);
                if (usr.UserType.ToUpper() == "STUDENT")
                {
                    userList.Add(usr);
                };
            }
            return userList;
        }

        void ShowMethod()
        {
            if (SelectedExam!=null)
            {
                StudentList = GetStudentList();
            }
        }

        void DeleteMethod()
        {
            if (SelectedExam != null)
            {
                client.RemoveExamById(SelectedExam.Id); 
            }
            RefreshMethod();
        }

        void AddMethod()
        {
            ExamManagerWindow newExamWindow = new ExamManagerWindow();
            newExamWindow.Show();
        }

        void EditMethod()
        {
            if (SelectedExam != null)
            {
                ExamManagerWindow newExamWindow = new ExamManagerWindow(SelectedExam);
                newExamWindow.Show();
            }
        }
        void RegisterMethod()
        {
            if (SelectedExam != null)
            {
                RegisterStudentWindow regWindow = new RegisterStudentWindow(SelectedExam.Id);
                regWindow.Show();
            }
        }

        void UnregisterMethod()
        {
            if (SelectedStudent != null)
            {
                client.RemoveExamsUserById
                    (
                    client.GetAllExamsUsers().Where(user => user.UserId == SelectedStudent.Id).First().Id
                    );
            }
        }

        void GenerateRandExamMethod()
        {
            ExamGenerator examGen = new ExamGenerator();
            examGen.GenerateExam();
            RefreshMethod();
        }
    }
}
