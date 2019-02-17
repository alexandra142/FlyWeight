using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace Diamonds
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDiamondBoard _diamondBoard;
        public MainWindow()
        {
            InitializeComponent();
            // TestDrawRow1(10,10);
            Play(10, 10 + Constants.RowWidth);

        }

        private void TestDrawRow1(int xStart, int yStart)
        {
            IDiamond none = new DiamondNone();
            none.Draw(xStart, yStart, MyCanvas);

            xStart += Constants.ColumnWidth;
            IDiamond square = new DiamondSquare();
            square.Draw(xStart, yStart, MyCanvas);

            xStart += Constants.ColumnWidth;
            IDiamond star = new DiamondStar();
            star.Draw(xStart, yStart, MyCanvas);

            xStart += Constants.ColumnWidth;
            IDiamond circle = new DiamondCircle();
            circle.Draw(xStart, yStart, MyCanvas);

            xStart += Constants.ColumnWidth;
            IDiamond diamondX = new DiamondX();
            diamondX.Draw(xStart, yStart, MyCanvas);

            xStart += Constants.ColumnWidth;
            IDiamond diamondPlus = new DiamondPlus();
            diamondPlus.Draw(xStart, yStart, MyCanvas);

            xStart += Constants.ColumnWidth;
            IDiamond diamondRhombus = new DiamondRhombus();
            diamondRhombus.Draw(xStart, yStart, MyCanvas);

            xStart += Constants.ColumnWidth;
            IDiamond diamondButterfly = new DiamondButterFly();
            diamondButterfly.Draw(xStart, yStart, MyCanvas);
        }

        private void Play(int xStart, int yStart)
        {
            IDiamondDrawer drawer = new DiamondDrawer();
             _diamondBoard = new DiamondBoard(drawer, 7, 7, MyCanvas);

            //System.Threading.Thread.Sleep(5000);

            //for (int i = 0; i < 7; i++)
            //{
            //    var diamond = drawer.Next();
            //    diamond.Draw(xStart, yStart, MyCanvas);
            //    xStart += Constants.ColumnWidth;
            //}

        }

        private void Test(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                Debug.WriteLine(e.GetPosition(this));

            _diamondBoard.Change(1, 1, 1, 2);
        }
    }
}
