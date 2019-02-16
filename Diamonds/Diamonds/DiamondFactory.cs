namespace Diamonds
{
    public class DiamondFactory
    {
        public IDiamond CreateDiamond(DiamondType diamondType)
        {
            switch (diamondType)
            {
                case DiamondType.Square: return new DiamondSquare();
                case DiamondType.Star: return new DiamondStar();
                case DiamondType.Circle: return new DiamondCircle();
                case DiamondType.X: return new DiamondX();
                case DiamondType.Plus: return new DiamondPlus();
                case DiamondType.Rhombus: return new DiamondRhombus();
                case DiamondType.ButterFly: return new DiamondButterFly();
                default: return new DiamondNone();
            }
        }
    }
}
