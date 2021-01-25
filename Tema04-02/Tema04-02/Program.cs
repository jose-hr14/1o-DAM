using System;

namespace Tema04_02
{
    class Program
    {
        //19. Realizar un programa con dos botones, uno para calcular el factorial utilizando una función
        //iterativa(no recursiva) y otro para calcularlo utilizando una función recursiva.
        public static int Ejercicio19_01(int a)
        {
            int result = 1;
            for (int i = 0; i < a; i++)
            {
                result *= (i + 1);
            }
            return result;
        }
        public static int Ejercicio19_02(int a)
        {
            int factorial;
            int b;
            //4! = 4 * 3 * 2 * 1;
            //caso base
            if (a == 1)
                return 1;
            else if (a == 0)
                    return 0;
            else
            {
                b = Ejercicio19_02(a - 1);
                return factorial = a * b; 
            }                
        }
        //20. Realizar dos funciones para calcular una potencia. Hacer una iterativa y otra recursiva. Las
        //funciones tendrán como parámetros la base y el exponente(Ejercicio Resuelto).
        public static int Ejercicio20(int a, int b)
        {
            // 5^3 = 5 * 5^2
            // 5^2 = 5 * 5^1
            // 5^1 = 5 * 1
            int solution;
            //caso base
            if (b <= 1)
                return 1;
            else
                return solution = a * Ejercicio20(a, (b - 1));
        }
        //21. Realizar una función que realice una multiplicación mediante sumas sucesivas.Hacer una
        //función iterativa y otra recursiva recursiva.Las funciones tendrán como parámetro dos
        //números enteros, que serán positivos.Por ejemplo: 5 * 4 = 4 + 4 + 4 + 4 + 4
        public static int Ejercicio21(int a, int b)
        {
            // 5 * 3 = 5 + 5 * 2
            //5 * 2 = 5 + 5 * 1
            if (b == 1)
                return a;
            else if (b == 0)
                return 0;
            else
                return a + Ejercicio21(a, (b - 1));
        }
        //22. Realizar una función iterativa y otra recursiva para determinar el número de dígitos de un
        //número entero(ej.para la entrad “1244” se produce la salida “4”, para la entrada “13” se
        //produce la salida “2”, etc.). 
        public static int Ejercicio21_01(int a)
        {
            int aux = 1;
            int solution = 0;
            for (int i = 0; aux <= a; i++)
            {
                aux *= 10;
                solution = i + 1;
            }
            return solution;
        }
        public static int Ejercicio21_02(float a)
        {
            // !1224 = 1224 / 10 = 122,4
            // !122,4 = 122,4 / 10 = 12,24
            // !12,24 = 12,24 / 10 = 1,224
            // !1,224 = 1,224 / 10 = 0,1224
            if (a < 10)  //caso base
                return 1;
            else
                return 1 + Ejercicio21_02(a / 10);
        }
        //23. Realizar dos funciones una iterativa y otra recursiva que calculen la división entera de dos
        //números enteros positivos mediante restas sucesivas(Ejercicio Resuelto).
        public static int Ejercicio22(int a, int b)
        {
            // 10 / 2 = 10 - (8 - 2) = 8 - (6 - 2) = 4 - (2 - 2) = 0
            if (a <= 0)
                return 0;
            else
            {
                return 1 + Ejercicio22((a - b), b);
            }

        }
        public static int Ejercicio23(int a)
        {            
            int resultado = 0;
            while (a > 0)
            {
                resultado = resultado * 10 + a % 10;
                a /= 10;
            }
            return resultado;            
        }
        static void Main(string[] args)
        {
            int a = Ejercicio19_01(4);
            int b = Ejercicio19_02(4);
            b = Ejercicio20(5, 3);
            b = Ejercicio21(5, 4);
            b = Ejercicio21_01(999);
            b = Ejercicio21_02(1224);
            b = Ejercicio22(16, 2);
            b = Ejercicio23(563);

        }
    }
}
