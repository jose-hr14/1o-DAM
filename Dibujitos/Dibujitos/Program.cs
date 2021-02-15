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
        // Nos va a pedir el array (introduce el tamaño del array), y nos va a pedir celda por celda que introduzcamos el valor y los imprimirá todo
        public static void Ejercicio01()
        {
            Console.Write("Introduce el tamaño del Array: ");
            int tamaño_array = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[tamaño_array];
            LeerArray(Array);
            ImprimirArray(Array);

        }
        static void Main(string[] args)
        {
            //Dibujito01(20, 10);
            //Dibujito01Solution(40000, 40000);
            Ejercicio01();

            
        }
    }
}
