using System;

namespace Tema04
{
    class Program
    {
        public static int Ejercicio01(int a, int b)
        {
            return a + b;
        }
        //Realizar un programa que lea 2 números y compruebe si el primero de esos números es divisible por el otro.Hacer con una función (devolverá cierto o falso).
        public static bool Ejercicio02(int a, int b) 
        {
            if (a % b == 0)
                return true;
            else
                return false;
        }
        //Realizar un subprograma que intercambie el valor de 2 variables enteras.Hacer un programa
        //que lea 2 números y visualice los valores intercambiados. (Ejercicio Resuelto).
        public static void Ejercicio03(int a, int b)
        {
            Console.WriteLine("a es " + a + " y b es " + b);
            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine("a es " + a + " y b es " + b);
        }
        //4. Escribir una función que devuelva el valor absoluto de un número real y realizar un programa
        //que lea un numero y visualice su valor absoluto.
        public static int Ejercicio04(int a)
        {
            if (a >= 0)
                return a;
            else
                return a * (- 1);
        }
        //Realiza un programa con una función que se le pasen dos números enteros y devuelva el
        //mayor.
        public static int Ejercicio05(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //int suma = Ejercicio01(a, b);
            //bool ej02 = Ejercicio02(a, b);
            //Ejercicio03(a, b);
            //int ej04 = Ejercicio04(a);
            int ej05 = Ejercicio05(a, b);


        }
    }
}
