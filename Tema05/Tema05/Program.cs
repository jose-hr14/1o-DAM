using System;

namespace Tema05
{
    class Program
    {
        public static void Array_Ejemplo(int TamañoArray)
        {            
            // Declaramos y damos tamaño al vector.
            int[] Array = new int[TamañoArray];
            int i;
            // Leemos todos los elementos del vector.
            Array_Ejemplo_Leer(Array);
            // Mostramos los elementos del vector.
            Array_Ejemplo_Imprimir(Array);
            
        }
        public static void Array_Ejemplo_Leer(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Introduzca el elemento: " + i + ": ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void Array_Ejemplo_Imprimir(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
                Console.WriteLine("Vector[" + i + "] = " + Array[i]);
        }
        public static void Ejemplo02(int NumElementos, int pos)
        {
            int[] Array = new int[NumElementos];
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Introduzca el elemento: " + i + ": ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }                
            for (int i = 0; i < Array.Length; i++)
                Array[i] /= pos;
        }
        static void Main(string[] args)
        {
            Array_Ejemplo(5);
            //Ejemplo02(10, 2);
        }
    }
}
