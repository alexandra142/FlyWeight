using System.Windows.Controls;

namespace Diamonds
{
    public interface IDiamondBoard
    {
        void DrawBoard();
        void Change(int row1, int column1, int row2, int column2);
    }
}
