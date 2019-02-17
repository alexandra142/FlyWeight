using System;
using System.Windows.Controls;

namespace Diamonds
{
    public class DiamondBoard : IDiamondBoard
    {
        public IDiamond[,] _board;
        private readonly Canvas _canvas;
        private readonly int _rows;
        private readonly int _columns;
        private readonly IDiamondDrawer _drawer;

        public DiamondBoard(IDiamondDrawer drawer, int rows, int columns, Canvas canvas)
        {
            _board = new IDiamond[rows, columns];
            _rows = rows;
            _columns = columns;
            _drawer = drawer;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    _board[i, j] = drawer.Next();
            _canvas = canvas;
            DrawBoard();
        }

        public void Change(int row1, int column1, int row2, int column2)
        {
            IDiamond diamond1 = _board[row1, column1];
            IDiamond diamond2 = _board[row2, column2];
            _board[row1, column1] = diamond2;
            _board[row2, column2] = diamond1;

            Redraw();
        }

        private void Redraw()
        {
            _canvas.Children.RemoveRange(0, _canvas.Children.Count);

            DrawBoard();
        }

        public void DrawBoard()
        {
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _columns; j++)
                    _board[i, j].Draw(10 + Constants.ColumnWidth * j, 10 + Constants.RowWidth * i, _canvas);

            RemoveTripple();
        }

        private void RemoveTripple()
        {
           //CheckRows();
        }
    }
}
