using Entities;
using projektFeladat_WPF.Commands;
using projektFeladat_WPF.Views;
using Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using WcfServiceLibrary;

namespace projektFeladat_WPF.ViewModels
{
   public class SubjectControlViewModel : Bindable
    {
        private IEnumerable<Subjects> subjectList;

        public IEnumerable<Subjects> SubjectList
        {
            get { return subjectList; }
            set { subjectList = value; OnPropertyChanged(); }
        }

        private Subjects _selectedItem;

        public Subjects SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; private set; }
        public ICommand EdiCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand RefreshCommand { get; private set; }


        IService _service = new Service(); //nem service példány, csak egy kliens
         
        public SubjectControlViewModel()
        {
            RefreshMethod();
            RefreshCommand = new RelayCommand(RefreshMethod);
            AddCommand = new RelayCommand(AddMethod);
            EdiCommand = new RelayCommand(EditMethod);
            DeleteCommand = new RelayCommand(DeleteMethod);
        }

        void RefreshMethod()
        {
            List<Subjects> newList = new List<Subjects>();
            SubjectList = newList;
            SubjectList = _service.GetAllSubjects();            
        }

        public void AddMethod()
        {
            var newWindow = new SubjectManagerWindow();
            newWindow.Show();
        }

        public void EditMethod()
        {
            if (SelectedItem != null)
            {
                var newWindow = new SubjectManagerWindow(SelectedItem);
                newWindow.Show();
            }
           
        }

        public void DeleteMethod()
        {
            if (SelectedItem != null)
            {
                _service.RemoveSubjectById(SelectedItem.Id); //<== ezzel a módszerrel töröl
                //_service.RemoveSubject(SelectedItem);      //ez a módszer hiát dob
                RefreshMethod();
            }
           
        }

        void MoveNextMethod()
        {
            
        }
    }
}
