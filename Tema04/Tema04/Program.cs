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
        public static void Ejercicio06(int a, int b, out int solution, out int rest)
        {
            solution = a / b;
            rest = a % b;
        }
        public static int Ejercicio07(int a, int b)
        {
            int solution = 0;
            if (a <= 0 || b <= 0)
                return 0;
            for (int i = 0; i <= a || i <= b; i++)
            {
                if (a % (i + 1) == 0 && b % (i + 1) == 0)
                    solution = i;
            }
            return solution + 1;
        }
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int suma = Ejercicio01(a, b);
            //bool ej02 = Ejercicio02(a, b);
            //Ejercicio03(a, b);
            //int ej04 = Ejercicio04(a);
            //int ej05 = Ejercicio05(a, b);
            //int solucion;
            //int resto;
            //Ejercicio06(8, 4, out solucion, out resto);
            int MCD = Ejercicio07(1254, 5896);

        }
    }
}
