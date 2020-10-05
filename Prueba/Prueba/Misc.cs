using System;
using System.Collections.Generic;
using System.Text;

namespace Vectores
{
    class Misc
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }


        public static int GetMaxValue(int a, int b)
        {
            if (a > b)
                return a;

            else
                return b;
        }

        //This function returns true if the number is even (par) and false otherwise
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                    return false;
        }

        public static bool IsPositive(int value)
        {
            if (value >= 0)
                return true;
            else
                return false;
        }


    }
}
