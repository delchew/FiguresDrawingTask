using System;
using System.Drawing;

namespace FiguresCommon
{
    public abstract class Figure
    {
        private float _scale;

        public string Title { get; set; }

        public Color BodyColor { get; set; }

        public Color StrokeColor { get; set; }

        public uint StrokeThickness { get; set; }

        public abstract void Draw(object drawingPlace);

        public float Scale
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

        public Figure()
        {
            Scale = 1;
            StrokeThickness = 0;
            BodyColor = Color.White;
            StrokeColor = Color.Black;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
