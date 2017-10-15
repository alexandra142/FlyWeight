using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Diamonds
{
    class DiamondX : IDiamond
    {
        public void Draw(int x, int y, Canvas canvas)
        {
            Line line = new Line();
            line.X1 = 5;
            line.X2 = 85;
            line.Y1 = 5;
            line.Y2 = 85;
            line.StrokeThickness = 5;
            line.Fill = Brushes.Purple;
            Canvas.SetLeft(line, x);
            Canvas.SetTop(line, y);
            canvas.Children.Add(line); 
        }
    }
}
