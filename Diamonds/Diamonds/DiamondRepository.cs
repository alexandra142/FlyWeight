using System;

namespace Diamonds
{
    internal class DiamondRepository
    {
        public int DiamondKinds = Enum.GetNames(typeof(DiamondType)).Length;
        public Random Random = new Random();
        public IDiamond[] diamonds;

        public DiamondRepository()
        {
            diamonds = new IDiamond[DiamondKinds];

        }

        /// <summary>
        /// Get Next index of not none diamond
        /// </summary>
        /// <returns></returns>
        public int NextIndexOfDiamond()
        {
            return Random.Next(1, DiamondKinds);
        }

        public DiamondType Next()
        {
            return (DiamondType)NextIndexOfDiamond();
        }
    }
}
