using FiguresDrawing.Figures;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.Generic;
using System;
using System.Windows.Controls;

namespace FiguresDrawing
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public Dictionary<string, Func<Figure>> GenerateFigureMethodsDict = new Dictionary<string, Func<Figure>>();
        public ObservableCollection<string> FiguresTitleCollection { get; set; }
        public object DrawingPlace { get; set; }

        private ICommand _drawCurrentFigureCommand;
        public ICommand DrawCurrentFigureCommand
        {
            get
            {
                if (_drawCurrentFigureCommand == null)
                {
                    _drawCurrentFigureCommand = new Command(DrawCurrentFigure);
                }
                return _drawCurrentFigureCommand;
            }
        }

        private ICommand _clearDrawingPlaceCommand;
        public ICommand ClearDrawingPlaceCommand
        {
            get
            {
                if (_clearDrawingPlaceCommand == null)
                {
                    _clearDrawingPlaceCommand = new Command(parameter => (DrawingPlace as Canvas)?.Children.Clear());
                }
                return _clearDrawingPlaceCommand;
            }
        }

        private double _figureHeigth;
        public double FigureHeigth
        {
            get { return _figureHeigth; }
            set
            {
                if (_figureHeigth != value)
                {
                    _figureHeigth = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _figureWidth;
        public double FigureWidth
        {
            get { return _figureWidth; }
            set
            {
                if (_figureWidth != value)
                {
                    _figureWidth = value;
                    OnPropertyChanged();
                }
            }
        }

        private double _figureStrokeWidth;
        public double FigureStrokeWidth
        {
            get { return _figureStrokeWidth; }
            set
            {
                if (_figureStrokeWidth != value)
                {
                    _figureStrokeWidth = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainWindowViewModel()
        {
            GenerateFigureMethodsDict.Add("Окружность", () => new Circle());
            GenerateFigureMethodsDict.Add("Прямоугольник", () => new Rectangle());

            FiguresTitleCollection = new ObservableCollection<string>(GenerateFigureMethodsDict.Keys);
        }

        private string _currentFigureTitle;
        public string CurrentFigureTitle
        {
            get{ return _currentFigureTitle; }
            set
            {
                if (_currentFigureTitle != value)
                {
                    _currentFigureTitle = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DrawCurrentFigure(object drawingPlace)
        {
            var figure = GenerateFigureMethodsDict[CurrentFigureTitle]?.Invoke();
            figure.Height = FigureHeigth;
            figure.Width = FigureWidth;
            figure.StrokeThickness = FigureStrokeWidth;
            figure.BodyColor = System.Drawing.Color.BurlyWood;
            figure.StrokeColor = System.Drawing.Color.Black;
            figure.Draw(drawingPlace);
        }
    }

}
