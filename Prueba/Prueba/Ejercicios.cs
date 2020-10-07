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
        //____________________________________________
        public static void Ejercicio01()
        {
            int contador = 0;
            while (contador < 100)
            {

                contador += 1;
            }
        }
        
        //Ejercicio: hacer una funcion que imprima
        //todos los números pares desde 0 hasta n
        //________________________________________
        public static void Ejercicio02(int n)
        {
            int i = 0;
            while (i <= n)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(i);
                i ++;
            }
        }

        public static void Ejercicio03(int number)
        {
            bool is_prime;
            is_prime = Maths.IsPrime(number);
            if (is_prime)
                System.Console.WriteLine("El número " + number + " es primo.");
            else
                System.Console.Write("El número " + number + " es primo.");
        }
        public static void Ejercicio04()
        {
            for (int i = 0; i < 90 ; i++) //while para un contador
            {
                System.Console.WriteLine(i);
            }


        }
    }
}
