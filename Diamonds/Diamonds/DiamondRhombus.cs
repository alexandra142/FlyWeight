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
                new Point(x+Constants.Modul/2, y),
                new Point(x+Constants.Modul, y + Constants.Modul/2),
                new Point(x + Constants.Modul/2, y + Constants.Modul),
                new Point(x, y + Constants.Modul/2)
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

