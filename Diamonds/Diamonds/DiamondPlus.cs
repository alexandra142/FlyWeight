﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Diamonds
{
    internal class DiamondPlus : IDiamond
    {
        public void Draw(int x, int y, Canvas canvas)
        {
            AddPolygon1(x, y, canvas);

            AddPolygon2(x, y, canvas);
        }

        private void AddPolygon1(int x, int y, Canvas canvas)
        {
            PointCollection points = new PointCollection
            {
                new Point(x, y+35),
                new Point(x, y + 45),
                new Point(x + 80, y + 45),
                new Point(x + 80, y + 35)
            };

            var polygon = new Polygon
            {
                Points = points,
                Fill = Brushes.DeepSkyBlue
            };

            Canvas.SetLeft(polygon, 1);
            Canvas.SetTop(polygon, 3);
            canvas.Children.Add(polygon);
        }

        private void AddPolygon2(int x, int y, Canvas canvas)
        {
            PointCollection points = new PointCollection
            {
                new Point(x + 35, y),
                new Point(x + 45, y),
                new Point(x + 45, y + 80),
                new Point(x+35, y + 80)
            };

            var polygon2 = new Polygon
            {
                Points = points,
                Fill = Brushes.DeepSkyBlue
            };

            Canvas.SetLeft(polygon2, 1);
            Canvas.SetTop(polygon2, 3);
            canvas.Children.Add(polygon2);
        }
    }
}
