using FiguresCommon;
using FiguresDrawing.Figures;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Drawing;

namespace FiguresDrawing
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Figure> FiguresCollection { get; set; }
        public object DrawingPlace { get; set; }
        private ICommand _drawCurrentFigureCommand;
        public ICommand DrawCurrentFigureCommand
        {
            get
            {
                if(_drawCurrentFigureCommand == null)
                {
                    _drawCurrentFigureCommand = new DrawingCommand((drawingPlace) => CurrentFigure.Draw(drawingPlace));
                }
                return _drawCurrentFigureCommand;
            }
        }

        public MainWindowViewModel()
        {
            FiguresCollection = new ObservableCollection<Figure>
            {
                new WPFCircle
                { 
                    Title = "Blue stroke circle filled red",
                    BodyColor = Color.AliceBlue,
                    StrokeColor = Color.DarkBlue,
                    Radius = 20,
                    Scale = 1,
                    StrokeThickness = 3
                     
                } 
            };
        }

        private Figure _currentFigure;
        public Figure CurrentFigure
        {
            get 
            { 
                if (_currentFigure == null)
                {
                    _currentFigure = FiguresCollection[0];
                }
                return _currentFigure;
            }
            set
            {
                if (_currentFigure != null && !_currentFigure.Equals(value))
                {
                    _currentFigure = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
