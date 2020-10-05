using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    class Maths
    {
        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
