namespace FiguresCommon
{
    public abstract class Rectangle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle() : base()
        {
            Title = "Прямоугольник";
        }
    }
}
