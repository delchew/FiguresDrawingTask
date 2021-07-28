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
                Mode = BindingMode.OneWay,
            };
            drawButton.SetBinding(Button.CommandProperty, bindingDrawCommand);

            Binding bindingCommandParameter = new Binding
            {
                Source = canvas,
                Mode = BindingMode.OneWay,
            };
            drawButton.SetBinding(Button.CommandParameterProperty, bindingCommandParameter);

            Binding bindingCollection = new Binding
            {
                Source = _viewModel.FiguresCollection,
                Mode = BindingMode.OneWay,
            };
            figuresBox.SetBinding(ComboBox.ItemsSourceProperty, bindingCollection);

            //Binding bindingCurrentFigure = new Binding
            //{
            //    Source = _viewModel.CurrentFigure,
            //    Mode = BindingMode.OneWayToSource,
            //    Converter = new FigureToObjectConverter()
            //};
            //figuresBox.SetBinding(ComboBox., bindingCurrentFigure);

        }
    }
}
