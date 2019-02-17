using System;
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
        private IDiamondBoard _diamondBoard;
        private Point Change1Point;
        private Point Change2Point;
        private int rowsMax = 6;
        private int columnsMax = 6;
        public MainWindow()
        {
            InitializeComponent();
            IDiamondDrawer drawer = new DiamondDrawer();
            _diamondBoard = new DiamondBoard(drawer, rowsMax + 1, columnsMax + 1, MyCanvas);
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


        private void Test(object sender, DragEventArgs e)
        {

        }

        private void Leave(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.GetPosition(this));
        }

        private void DragLeave(object sender, DragEventArgs e)
        {
          

        }

        private void MouseUp(object sender, MouseButtonEventArgs e)
        {
            Change2Point = e.GetPosition(this);
            int column1 = (int)Change1Point.X / Constants.RowWidth;
            int row1 = (int)Change1Point.Y / Constants.ColumnWidth;

            if (Math.Abs(Change1Point.X - Change2Point.X) > Math.Abs(Change1Point.Y - Change2Point.Y))
            {
                if (Change2Point.X > Change1Point.X)
                {
                    if (column1 == columnsMax)
                        return;

                    _diamondBoard.Change(row1, column1, row1, column1 + 1);
                    return;
                }

                if (Change2Point.X < Change1Point.X)
                {
                    if (column1 == 0)
                        return;

                    _diamondBoard.Change(row1, column1, row1, column1 - 1);
                    return;
                }
            }

            if (Change2Point.Y > Change1Point.Y)
            {
                if (row1 == rowsMax)
                    return;

                _diamondBoard.Change(row1, column1, row1 + 1, column1);
                return;
            }
            if (Change2Point.Y < Change1Point.Y)
            {
                if (row1 == 0)
                    return;

                _diamondBoard.Change(row1, column1, row1 - 1, column1);
                return;
            }
        }

        private void MouseDown(object sender, MouseButtonEventArgs e)
        {
            Change1Point = e.GetPosition(this);

        }
    }
}
