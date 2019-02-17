using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Diamonds
{
    public class DiamondNone : IDiamond
    {
        public void Draw(int x, int y, Canvas canvas)
        {
            var rect = new Rectangle
            {
                Stroke = Brushes.White,
                Fill = Brushes.White,
                StrokeThickness = 10,
                Width = Constants.ColumnWidth,
                Height = Constants.RowWidth
            };
            Canvas.SetLeft(rect, x-10);
            Canvas.SetTop(rect, y-10);
            canvas.Children.Add(rect);
        }
    }
}
