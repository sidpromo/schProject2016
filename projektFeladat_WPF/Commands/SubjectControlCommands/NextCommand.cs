using projektFeladat_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace projektFeladat_WPF.Commands.SubjectControlCommands
{
    class NextCommand : ICommand
    {
        private SubjectControlViewModel _viewModel;

        public NextCommand(SubjectControlViewModel viewModel)
        {
            _viewModel = viewModel;
            
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (_viewModel.Collection.View.CurrentPosition < _viewModel.Collection.View.SourceCollection.Cast<object>().Count() - 1)
                _viewModel.Collection.View.MoveCurrentToNext();
        }
    }
}
