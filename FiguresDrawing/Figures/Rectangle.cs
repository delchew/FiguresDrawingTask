using System.Windows.Controls;

namespace FiguresDrawing.Figures
{
    public class Rectangle : Figure
    {
        public override void Draw(object drawingPlace)
        {
            var el = new System.Windows.Shapes.Rectangle();
            el.Width = 2 * Width * Scale;
            el.Height = 2 * Height * Scale;
            el.Fill = BodyColor.ToSolidColorBrush();
            el.Stroke = StrokeColor.ToSolidColorBrush();
            el.StrokeThickness = StrokeThickness;
            var canvas = drawingPlace as Canvas;
            var left = (canvas.ActualWidth - el.ActualWidth) / 2;
            Canvas.SetLeft(el, left);
            var top = (canvas.ActualHeight - el.ActualHeight) / 2;
            Canvas.SetTop(el, top);
            canvas?.Children.Add(el);
        }
    }
}
