using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Diamonds
{
    internal class DiamondRhombus : IDiamond
    {
        public void Draw(int x, int y, Canvas canvas)
        {
            PointCollection points = new PointCollection
            {
                new Point(x+40, y),
                new Point(x+80, y + 40),
                new Point(x + 40, y + 80),
                new Point(x, y + 40)
            };

            var polygon = new Polygon
            {
                Points = points,
                Fill = Brushes.Gold
            };

            Canvas.SetLeft(polygon, 1);
            Canvas.SetTop(polygon, 3);
            canvas.Children.Add(polygon);
        }
    }
}

