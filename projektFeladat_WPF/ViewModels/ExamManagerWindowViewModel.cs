using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            set { teacherList = value; OnPropertyChanged(); }
        }

        private IEnumerable<Subjects> subjectList;

        public IEnumerable<Subjects> SubjectList
        {
            get { return subjectList; }
            set { subjectList = value; OnPropertyChanged(); }
        }

        private Exams editedExam;

        public Exams EditedExam
        {
            get { return editedExam; }
            set { editedExam = value; OnPropertyChanged(); }
        }

        private Users selectedTeacher;

        public Users SelectedTeacher
        {
            get { return selectedTeacher; }
            set { selectedTeacher = value; OnPropertyChanged(); }
        }
        private Subjects selectedSubject;

        public Subjects SelectedSubject
        {
            get { return selectedSubject; }
            set { selectedSubject = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; private set; }
        ServiceClient client = new ServiceClient();
        public Array ExamType
        {
            get { return Enum.GetValues(typeof(ExamTypes)); }
        }
        public DateTime Now { get; private set; }
        public ExamManagerWindowViewModel()
        {
            CommonMethod();
            EditedExam = new Exams();
        }

        public ExamManagerWindowViewModel(Exams examToEdit)
        {
            CommonMethod();
            EditedExam = client.GetExamById(examToEdit.Id);
            SelectedSubject = client.GetAllSubjects().Where(s => s.Id == examToEdit.SubjectID).FirstOrDefault();           
            //TODO: SelectedTeacher=...

        }
        void CommonMethod()
        {
            SubjectList = client.GetAllSubjects();
            TeacherList = client.GetTeachersFromUsers();
            SaveCommand = new RelayCommand(SaveMethod);
            Now = DateTime.Now;
        }

        void Add()
        {
            EditedExam.ModifiedBy = Singleton.Instance.ID;
            EditedExam.ModifyDate = DateTime.Now;
            EditedExam.InsertDate = DateTime.Now;
            int id=client.AddExam(EditedExam);
            client.AddExamsUser(
                new ExamsUsers
                {
                    InsertDate = DateTime.Now,
                    ModifyDate = DateTime.Now,
                    ModifiedBy=Singleton.Instance.ID,
                    ExamId=id,
                    UserId=SelectedTeacher.Id
                });
        }

        void SaveMethod()
        {
            if (client.GetExamById(EditedExam.Id) == null)
            {
                Add();
            }
            else
            {

                client.UpdateExam(EditedExam);
            }
            EditedExam = new Exams();

           //Limit - registered stud no.
           //exam gen
           //charts..
           //conv  check
           //documents not only pdf
            
        }


    }
}
