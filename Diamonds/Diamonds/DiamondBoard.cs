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
        private readonly IDiamond noneDiamond = new DiamondNone();

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

            DrawBoard();
        }

        public void DrawBoard()
        {

            RemoveTripple();

            _canvas.Children.RemoveRange(0, _canvas.Children.Count);

            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _columns; j++)
                    _board[i, j].Draw(10 + Constants.ColumnWidth * j, 10 + Constants.RowWidth * i, _canvas);
        }

        private void RemoveTripple()
        {
            var found = true;

            while (found)
            {
                if (CheckRows())
                {
                    Fall();
                    continue;
                };
                if (CheckColumns())
                {
                    Fall();
                    continue;
                };
                return;
            }
        }

        private void Fall()
        {
            for (int j = 0; j < _columns; j++)
            {
                var none = 0;
                for (int i = _rows - 1; i >= 0; i--)
                {
                    if (_board[i, j] == noneDiamond)
                    {
                        none++;
                        continue;
                    }
                    if (none > 0)
                    {
                        _board[i + none, j] = _board[i, j];
                        _board[i, j] = noneDiamond;
                    }
                    ;
                }
            }

        }

        private bool CheckColumns()
        {
            var found = false;

            for (int j = 0; j < _columns; j++)
            {
                var i = -1;
                var match = 0;
                while (i < _rows - 2)
                {
                    i++;
                    if (_board[i, j] == noneDiamond || _board[i, j] != _board[i + 1, j])
                    {
                        if (match >= 2)
                        {
                            for (int k = 0; k <= match; k++)
                                _board[i - k, j] = noneDiamond;

                            found = true;
                        }

                        match = 0;
                        continue;
                    }

                    match++;

                }
                i++;
                if (match >= 2)
                {
                    for (int k = 0; k <= match; k++)

                        _board[i - k, j] = noneDiamond;
                    found = true;
                }


            };

            return found;
        }

        private bool CheckRows()
        {
            var found = false;
            for (int i = 0; i < _rows; i++)
            {
                var j = -1;
                var match = 0;
                while (j < _columns - 2)
                {
                    j++;
                    if (_board[i, j] == noneDiamond || _board[i, j + 1] != _board[i, j])
                    {
                        if (match >= 2)
                        {
                            for (int k = 0; k <= match; k++)
                                _board[i, j - k] = noneDiamond;
                            found = true;
                        }

                        match = 0;
                        continue;
                    }

                    match++;

                }
                j++;
                if (match >= 2)
                {
                    for (int k = 0; k <= match; k++)
                        _board[i, j - k] = noneDiamond;
                    found = true;

                }
            };

            return found;

        }
    }
}
