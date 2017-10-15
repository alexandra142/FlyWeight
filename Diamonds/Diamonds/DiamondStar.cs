using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Diamonds
{
    class DiamondStar : IDiamond
    {
        private const int NumPoints = 5;
        public void Draw(int x, int y, Canvas canvas)
        {
            var polygon = new Polygon
            {
                Points = StarPoints(x, y),
                Fill = Brushes.OrangeRed
            };
            Canvas.SetLeft(polygon, 1);
            Canvas.SetTop(polygon, 3);
            canvas.Children.Add(polygon);
        }

        private PointCollection StarPoints(int x, int y)
        {
            PointCollection points = new PointCollection();

            double rx = (double)Constants.Modul / 2;
            double ry = (double)Constants.Modul / 2;
            double cx = x + rx;
            double cy = y + ry;

            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / NumPoints;
            for (int i = 0; i < NumPoints; i++)
            {
                var point = new Point(
                    (float)(cx + rx * Math.Cos(theta)),
                    (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
                points.Add(point);
            }

            return points;
        }
    }
}
