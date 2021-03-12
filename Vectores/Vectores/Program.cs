using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double len2d = Geometric.GetVector2DLength(2, 4);
            double len3d = Geometric.GetVector3DLength(4, 6, 8);
            double GetMin = Misc.GetMinValue(6, 5);
            double GetMax = Misc.GetMaxValue(6, 5);
            bool Even = Misc.IsEven(6);
            bool Positive = Misc.IsPositive(5);
            double AreaCircle = Geometric.GetCircleArea(5);
            double BetweenVectorsDistance = Geometric.GetDistance2D(0, 0, 1, 0);
            bool CirclesDoOverlap = Geometric.DoOverlap(50, 60, 1, 2, 5, 5);
        }
    }
}
