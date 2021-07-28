using System.Windows.Media;

namespace FiguresDrawing
{
    public static class Extensions
    {
        public static SolidColorBrush ToSolidColorBrush(this System.Drawing.Color color)
        {
            return new SolidColorBrush(new Color
            {
                A = color.A,
                B = color.B,
                R = color.R,
                G = color.G
            });

        }
    }
}
