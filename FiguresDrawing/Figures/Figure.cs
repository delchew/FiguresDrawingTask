using System;
using System.Drawing;

namespace FiguresDrawing.Figures
{
    public abstract class Figure
    {
        public double Height { get; set; }

        public double Width { get; set; }

        public Color BodyColor { get; set; }

        public Color StrokeColor { get; set; }

        public double StrokeThickness { get; set; }

        private double _scale;
        public double Scale
        {
            get { return _scale; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Scale can't be less than 0!");
                }
                _scale = value;
            }
        }

        public abstract void Draw(object drawingPlace);

        public Figure()
        {
            Scale = 1;
            StrokeThickness = 0;
            BodyColor = Color.Gray;
            StrokeColor = Color.Black;
        }
    }
}
