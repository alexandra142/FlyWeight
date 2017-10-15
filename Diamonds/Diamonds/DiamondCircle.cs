using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Diamonds
{
    class DiamondCircle : IDiamond
    {
        public void Draw(int x, int y, Canvas canvas)
        {
            Ellipse el = new Ellipse
            {
                Width = Constants.Modul,
                Height = Constants.Modul,
                Fill = Brushes.Black
            };
            el.SetValue(Canvas.LeftProperty, (double)x);
            el.SetValue(Canvas.TopProperty, (double)y);

            canvas.Children.Add(el);
        }
    }
}
