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
                i++;
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
            for (int i = 0; i < 90; i++) //while para un contador que te saca una seria de -0, 1, -2, 3, -4, 5. Si el numero es par, se hace negativo, si es impar, se hace positivo
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(-i);
                else
                    System.Console.WriteLine(i);
            }
        }

        public static void Ejercicio05() //Fibonacci
        {
            
            int number1 = 0;
            int number2 = 1;

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(number1 + number2);
                number2 = number1 + number2;
                number1 = number2 - number1;
            }
        }


    }
}
