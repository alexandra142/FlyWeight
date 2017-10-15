using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Diamonds
{
    class DiamondSquare : IDiamond
    {
        public void Draw(int x, int y, Canvas canvas)
        {
            var rect = new Rectangle
            {
                Stroke = Brushes.Blue,
                Fill = Brushes.CornflowerBlue,
                StrokeThickness = 2,
                Width = Constants.Modul,
                Height = Constants.Modul
            };
            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);
            canvas.Children.Add(rect);
        }
    }
}
