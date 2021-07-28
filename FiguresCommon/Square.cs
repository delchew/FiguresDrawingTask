namespace FiguresCommon
{
    public abstract class Square : Figure
    {
        public float Side { get; set; }

        public Square() : base()
        {
            Title = "Квадрат";
        }
    }
}
