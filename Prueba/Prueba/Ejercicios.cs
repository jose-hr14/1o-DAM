using System;
using System.Collections.Generic;
using System.Text;
using Vectores;

namespace Prueba
{
    class Ejercicios
    {
        //Ejercicios: hacer una funcion que imprima por 
        //pantalla los numeros del 0 al 99
        public static void Ejercicio01()
        {
            int contador = 0;
            while (contador < 100)
            {
                Console.WriteLine(contador);
                contador += 1;
            }
        }
        //Ejercicio: hacer una funcion que imprima
        //todos los números pares desde 0 hasta n
        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i <= n)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(i);
                i ++;
            }
        }
    }
}
