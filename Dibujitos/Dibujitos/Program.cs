using System;

namespace Dibujitos
{
    class Program
    {
        public static void Dibujito01(int col, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == 0 || i == row - 1 || j == 0 || j == col - 1)
                        System.Console.Write("*");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }
        public static void Dibujito01Solution(int fila, int col)
        {
            for (int cont_fila = 0; cont_fila < fila; cont_fila++)
            {
                for (int cont_col = 0; cont_col < col; cont_col++)
                {
                    if (cont_fila == 0 || cont_fila == fila - 1 || cont_col == 0 || cont_col == col - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void Explicacion01()
        {
            int[] Array = { 1, 2, 3, 4, 5, 6 };
            /*             
            for(int i = 0; i < Array.Length; i++)
                {
                    Console.Write("Introduce un valor para la posición " + i + " del Array: ");
                    Array[i] = Convert.ToInt32(Console.ReadLine());
                }
             */

            for (int i = 0; i < Array.Length; i++)
            {
                //Console.WriteLine("El valor del Array en la posición " + i + " es: " + Array[i]);
                Console.WriteLine("El valor del Array en la posición {0} es {1}", i, Array[i]);
            }
        }
        public static void LeerArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Introduce un valor para la posición " + i + " del Array: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void ImprimirArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                //Console.WriteLine("El valor del Array en la posición " + i + " es: " + Array[i]);
                Console.WriteLine("El valor del Array en la posición {0} es {1}", i, Array[i]);
            }
        }

        public static void ImprimirArrayInverso(int[] Array)
        {
            for (int i = Array.Length; i > 0; i--)
            {
                //Console.WriteLine("El valor del Array en la posición " + i + " es: " + Array[i]);
                Console.WriteLine("El valor del Array en la posición {0} es {1}", i - 1, Array[i - 1]);
            }
        }
        // Nos va a pedir el array (introduce el tamaño del array), y nos va a pedir celda por celda que introduzcamos el valor y los imprimirá todo
        public static void Ejercicio01()
        {
            Console.Write("Introduce el tamaño del Array: ");
            int tam = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[tam];
            LeerArray(Array);
            ImprimirArray(Array);
            Console.WriteLine();
            ImprimirArrayInverso(Array);

        }
        //Crear array predefinido de 10 valores distintos, y luego el programa debe pedir un número y decirnos si el número fue encontrado en la posicion tal
        public static void BuscarArray(int[] Array, int Num)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Num)
                {
                    Console.WriteLine("El número {0} ha sido encontrado en la posición {1} del Array", Num, i);
                    return;
                }
            }
            Console.WriteLine("El número {0} no ha sido encontrado en el Array", Num);
        }
        public static void BuscarArraySolucion()
        {
            int[] Array = { 10, 20, 30, 55, 86, 21, 35, 15, 33, 29 };
            Console.Write("Introduce el valor a buscar: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            bool Encontrado = false;
            int contador = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (valor == Array[i])
                {
                    contador = i;
                    Encontrado = true;
                }
                    
            }
            if (Encontrado)
                Console.WriteLine("El número {0} ha sido encontrado en la posición {1} del Array", valor, contador);
            Console.WriteLine("El número {0} no ha sido encontrado en el Array", valor);
        }
        public static void BuscarArraySolucion02()
        {
            int[] Array = { 10, 20, 30, 55, 86, 21, 35, 15, 33, 29 };
            Console.Write("Introduce el valor a buscar: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Array.Length; i++)
            {
                if (valor == Array[i])
                {
                    Console.WriteLine("El número {0} ha sido encontrado en la posición {1} del Array", valor, i);
                    break;
                }
                else if (i == Array.Length - 1)
                    Console.WriteLine("El número {0} no ha sido encontrado en el Array", valor);
            }
            
        }
        public static void BuscarArraySolucionGoTo()
        {
            int[] Array = { 10, 20, 30, 55, 86, 21, 35, 15, 33, 29 };
            Console.Write("Introduce el valor a buscar: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (valor == Array[i])
                {
                    j = i;
                    goto esta;
                }
                else if (i == Array.Length - 1)
                    Console.WriteLine("El número {0} no ha sido encontrado en el Array", valor);
            }
            esta: Console.WriteLine("El número {0} ha sido encontrado en la posición {1} del Array", valor, j);
        }
        public static void GoTo()
        {
            int a = 7;
            int b = 3;
            int c;
            
            
            suma: c = 7 + 3;
        
        }
        public static void BucleGoTo()
        {
            int a = 7;
            int b = 3;
            int c;
            goto suma;
        producto: c = a * b;
        suma: c = 7 + 3;
            goto producto;

        }
        static void Main(string[] args)
        {
            //Dibujito01(20, 10);
            //Dibujito01Solution(40000, 40000);
            //Ejercicio01();
            int[] Array = { 10, 20, 30, 55, 86, 21, 35, 15, 33, 29 };
            //BuscarArray(Array, 29);
            GoTo();

            
        }
    }
}
