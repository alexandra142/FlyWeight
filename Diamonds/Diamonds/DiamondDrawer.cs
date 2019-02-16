using System;
using System.Windows.Controls;

namespace Diamonds
{
    public class DiamondDrawer : IDiamondDrawer
    {
        public Random Random = new Random();
        public int DiamondKinds = Enum.GetNames(typeof(DiamondType)).Length;
        private IDiamond[] _diamonds;

        public DiamondDrawer()
        {
            DiamondRepository diamondRepository = new DiamondRepository();
            _diamonds = diamondRepository.diamonds;
        }

        /// <summary>
        /// Get Next index of not none diamond
        /// </summary>
        /// <returns></returns>
        public int NextIndexOfDiamond()
        {
            return Random.Next(1, DiamondKinds);
        }

        /// <summary>
        /// Returnes a type of next diamond
        /// </summary>
        /// <returns></returns>
        public IDiamond Next()
        {
            return _diamonds[NextIndexOfDiamond()];
        }

        public void Draw(IDiamond diamond, int x, int y, Canvas canvas)
        {
            diamond.Draw(x, y, canvas);
        }

    }
}
