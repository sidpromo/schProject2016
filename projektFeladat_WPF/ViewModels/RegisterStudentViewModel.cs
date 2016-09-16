using projektFeladat_WPF.Common;
using projektFeladat_WPF.NeptunServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
    public class RegisterStudentViewModel : Bindable
    {
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
        public ICommand AddCommand { get; private set; }
        ServiceClient client = new ServiceClient();
        int _examID;
        public RegisterStudentViewModel(int examID)
        {
            StudentList = client.GetAllUsers().Where(s => s.UserType.ToUpper() == "STUDENT");
            _examID = examID;
            AddCommand = new RelayCommand(Add);
        }

        void Add()
        {
            ExamsUsers examU = new ExamsUsers { ExamId = _examID, UserId = SelectedStudent.Id, InsertDate = DateTime.Now, ModifyDate = DateTime.Now, ModifiedBy = Singleton.Instance.ID };
            client.AddExamsUser(examU);
        }


    }
}
