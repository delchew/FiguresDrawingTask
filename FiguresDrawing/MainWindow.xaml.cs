using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FiguresDrawing
{
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel { DrawingPlace = canvas };

            Binding bindingDrawCommand = new Binding
            {
                Source = _viewModel.DrawCurrentFigureCommand,
                Mode = BindingMode.OneWay
            };
            drawButton.SetBinding(Button.CommandProperty, bindingDrawCommand);

            Binding bindingCommandParameter = new Binding
            {
                Source = canvas,
                Mode = BindingMode.OneWay
            };
            drawButton.SetBinding(Button.CommandParameterProperty, bindingCommandParameter);

            Binding bindingClearCanvasCommand = new Binding
            {
                Source = _viewModel.ClearDrawingPlaceCommand,
                Mode = BindingMode.OneWay
            };
            clearButton.SetBinding(Button.CommandProperty, bindingClearCanvasCommand);

            Binding bindingCollection = new Binding
            {
                Source = _viewModel.FiguresTitleCollection,
                Mode = BindingMode.OneWay
            };
            figuresBox.SetBinding(ComboBox.ItemsSourceProperty, bindingCollection);

            Binding bindingFigureTitle = new Binding
            {
                Source = _viewModel,
                Path = new PropertyPath(nameof(_viewModel.CurrentFigureTitle)),
                Mode = BindingMode.OneWayToSource
            };
            figuresBox.SetBinding(ComboBox.SelectedValueProperty, bindingFigureTitle);
            figuresBox.SelectedIndex = 0;

            Binding bindingFigureHeigth = new Binding
            {
                Source = _viewModel,
                Path = new PropertyPath(nameof(_viewModel.FigureHeigth)),
                Mode = BindingMode.OneWayToSource
            };
            heightSlider.SetBinding(Slider.ValueProperty, bindingFigureHeigth);

            Binding bindingFigureWidth = new Binding
            {
                Source = _viewModel,
                Path = new PropertyPath(nameof(_viewModel.FigureWidth)),
                Mode = BindingMode.OneWayToSource
            };
            widthSlider.SetBinding(Slider.ValueProperty, bindingFigureWidth);

            Binding bindingFigureStrokeWidth = new Binding
            {
                Source = _viewModel,
                Path = new PropertyPath(nameof(_viewModel.FigureStrokeWidth)),
                Mode = BindingMode.OneWayToSource
            };
            strokeWidthSlider.SetBinding(Slider.ValueProperty, bindingFigureStrokeWidth);
        }
    }
}
