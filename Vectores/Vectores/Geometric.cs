using System;

namespace Vectores
{
    class Geometric
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux = (x * x) + (y * y);
            return System.Math.Sqrt(aux);
            
        }
        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux = (x * x) + (y * y) + (z * z);
            return System.Math.Sqrt(aux);
        }

        public static double GetCircleArea(double value)
        {
            double Area = Math.PI * value * value;
            return Area;
        }

        public static double GetDistance2D(double x1, double y1, double x2, double y2)
        {
            double xt = x2 - x1;
            double yt = y2 - y1;
            return GetVector2DLength(xt, yt);
        }

        //Funcion que devuelve si dos circulos chocan o no, x, y, radio
        public static bool DoOverlap(double r1, double r2, double x1, double y1, double x2, double y2)
        {
            double length = GetDistance2D(x1, y1, x2, y2);
            double radio = r1 + r2;
            if (radio <= length)
                return true;
            else
                return false;
        }

    }
}
