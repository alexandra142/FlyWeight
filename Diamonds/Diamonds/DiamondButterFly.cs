using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Diamonds
{
    internal class DiamondButterFly : IDiamond
    {
        public void Draw(int x, int y, Canvas canvas)
        {
            PointCollection points = new PointCollection
            {
                new Point(x, y),
                new Point(x+Constants.Modul, y + Constants.Modul),
                new Point(x + Constants.Modul, y ),
                new Point(x, y + Constants.Modul)
            };

            var polygon = new Polygon
            {
                Points = points,
                Fill = Brushes.GreenYellow
            };

            Canvas.SetLeft(polygon, 1);
            Canvas.SetTop(polygon, 3);
            canvas.Children.Add(polygon);
        }
    }
}
