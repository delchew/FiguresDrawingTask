namespace FiguresCommon
{
    public abstract class Circle : Figure
    {
        public float Radius { get; set; }
        public Circle() : base()
        {
            Title = "Окружность";
        }
    }
}
