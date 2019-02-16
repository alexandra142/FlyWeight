using System;

namespace Diamonds
{
    internal class DiamondRepository
    {
        public int DiamondKinds = Enum.GetNames(typeof(DiamondType)).Length;
        public IDiamond[] diamonds;

        public DiamondRepository()
        {
            diamonds = new IDiamond[DiamondKinds];

            DiamondFactory diamondFactory = new DiamondFactory();

            for (int i = 0; i < DiamondKinds; i++)
                diamonds[i] = diamondFactory.CreateDiamond((DiamondType)i);
        }

    
    }
}
