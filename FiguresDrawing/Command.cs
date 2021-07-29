using System;
using System.Windows.Input;

namespace FiguresDrawing
{
    public class Command : ICommand
    {
        private readonly Action<object> _commandAction;
        public Command(Action<object> drawingAction)
        {
            _commandAction = drawingAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _commandAction?.Invoke(parameter);
        }
    }
}
