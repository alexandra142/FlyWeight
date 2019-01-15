using System.Windows;

namespace Diamonds
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IDiamond none = new DiamondNone();
            none.Draw(10, 10, MyCanvas);

            IDiamond square = new DiamondSquare();
            square.Draw(110,10,MyCanvas);

            IDiamond star = new DiamondStar();
            star.Draw(210, 10, MyCanvas);

            IDiamond circle = new DiamondCircle();
            circle.Draw(310, 10, MyCanvas);

            IDiamond diamondX = new DiamondX();
            diamondX.Draw(410, 10, MyCanvas);

            IDiamond diamondPlus = new DiamondPlus();
            diamondPlus.Draw(510, 10, MyCanvas);
        }
    }
}
