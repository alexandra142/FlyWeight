using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Diamonds
{
    public class DiamondBoard : IDiamondBoard
    {
        public IDiamond[,] _board;
        int _rows;
        int _columns;
        public DiamondBoard(IDiamondDrawer drawer, int rows, int columns, Canvas canvas)
        {
            _board = new IDiamond[rows,columns];
            _rows = rows;
            _columns = columns;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    _board[i, j] = drawer.Next();

            DrawBoard(canvas);
        }

        public void DrawBoard(Canvas canvas)
        {
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _columns; j++)
                    _board[i, j].Draw(10 + Constants.ColumnWidth*j, 10+Constants.RowWidth*i, canvas);
        }

    }
}
