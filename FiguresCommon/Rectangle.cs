namespace FiguresCommon
{
    public abstract class Rectangle : Figure
    {
        public float Height { get; set; }

        public float Width { get; set; }

        public Rectangle() : base()
        {
            Title = "Прямоугольник";
        }
    }
}
