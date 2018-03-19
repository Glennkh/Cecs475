using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cecs475.Othello.Application
{
    public class UndoCommand : ICommand
    {
        public OthelloViewModel ViewModel { get; set; }

        public UndoCommand(OthelloViewModel vm) {
            this.ViewModel = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.UndoLastMove();
        }
    }
}
