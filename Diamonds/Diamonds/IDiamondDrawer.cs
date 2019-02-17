using System.Windows.Controls;

namespace Diamonds
{
    public interface IDiamondDrawer
    {
        /// <summary>
        /// Get Next index of not none diamond
        /// </summary>
        /// <returns></returns>
        int NextIndexOfDiamond();

        /// <summary>
        /// Get next diamond
        /// </summary> 
        /// <returns></returns>
        IDiamond Next();

        void Draw(IDiamond diamond, int x, int y, Canvas canvas);
    }
}
