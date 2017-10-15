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
            DiamondSquare square = new DiamondSquare();
            square.Draw(10,10,MyCanvas);
        }
    }
}
