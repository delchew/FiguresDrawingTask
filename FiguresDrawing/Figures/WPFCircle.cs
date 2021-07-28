using FiguresCommon;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace FiguresDrawing.Figures
{
    public class WPFCircle : Circle
    {
        public override void Draw(object drawingPlace)
        {
            var el = new Ellipse();
            el.Width = 2 * Radius * Scale;
            el.Height = 2 * Radius * Scale;
            el.Fill = BodyColor.ToSolidColorBrush();
            el.Stroke = StrokeColor.ToSolidColorBrush();
            el.StrokeThickness = StrokeThickness;
            var canvas = drawingPlace as Canvas;
            canvas?.Children.Add(el);
        }
    }
}
