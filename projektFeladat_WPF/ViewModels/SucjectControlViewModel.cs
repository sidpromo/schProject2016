using projektFeladat_WPF.Commands.SubjectControlCommands;
using projektFeladat_WPF.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace projektFeladat_WPF.ViewModels
{
    class SubjectControlViewModel:Bindable
    {
        public CollectionViewSource Collection { get; private set; }
        private EducationDatabaseEntities _ctx;

        #region SelectedItem
        private SubjectsUser _selectedItem;

        public SubjectsUser SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
                ButtonAddContent = "Add";
            }
        }

        #endregion

        #region ButtonAddContent Full Property
        private string _buttonAddContent;
        public string ButtonAddContent
        {
            get
            {
                return _buttonAddContent;
            }

            set
            {
                _buttonAddContent = value;
                OnPropertyChanged(); ;
            }
        }
        #endregion

        #region Commands
        public NextCommand NextEvent { get; private set; }
        public PreviousCommand PreviousEvent { get; set; }
        //public AddCommand AddEvent { get; set; }
        //public SaveCommand SaveEvent { get; set; }
        //public RefreshCommand RefreshEvent { get; set; }
        #endregion
            
        public SubjectControlViewModel()
        {
            Collection = new CollectionViewSource();
            LoadData();
            
        }

        private void LoadData()
        {
            Refresh();
            SelectedItem = Collection.View.CurrentItem as SubjectsUser;
            
        }

        private void Refresh()
        {
            _ctx = new EducationDatabaseEntities(); //TODO:betölteni a táblát
            
            

        }
    }
}
