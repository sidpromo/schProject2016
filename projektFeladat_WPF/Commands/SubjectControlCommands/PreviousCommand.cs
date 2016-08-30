using projektFeladat_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace projektFeladat_WPF.Commands.SubjectControlCommands
{
    class PreviousCommand : ICommand
    {
        private SubjectControlViewModel _viewModel;

        public PreviousCommand(SubjectControlViewModel viewModel)
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
            if (_viewModel.Collection.View.CurrentPosition > 0)
                _viewModel.Collection.View.MoveCurrentToPrevious();
        }
    }
}
