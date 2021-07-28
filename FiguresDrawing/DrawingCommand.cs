using System;
using System.Windows.Input;

namespace FiguresDrawing
{
    public class DrawingCommand : ICommand
    {
        private Action<object> _drawingAction;
        public DrawingCommand(Action<object> drawingAction)
        {
            _drawingAction = drawingAction;
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
            _drawingAction?.Invoke(parameter);
        }
    }
}
