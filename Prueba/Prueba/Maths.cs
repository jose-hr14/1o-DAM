using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    class Maths
    {
        //Ejercicio de hacer un programa que imprima si un numero es primo o no
        //Para comprobar primo, no debe tener ningún divisor que de un resto cero
        public static bool IsPrime(int number)
        {
            
            int i = 2;

                while (i < number)
                {
                    if ((number % i) == 0)
                    {
                        return false;
                    }

                    else

                    {
                        i += 1;
                    }
                }
                return true;
        }
    }
}
