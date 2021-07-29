namespace FiguresCommon
{
    public abstract class Circle : Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Circle() : base()
        {
            Title = "Окружность";
        }
    }
}
