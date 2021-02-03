using System;

namespace Tema05
{
    class Program
    {
        public static void Array_Ejemplo(int TamañoArray)
        {            
            // Declaramos y damos tamaño al vector.
            int[] Array = new int[TamañoArray];            
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
        public static int SumarArrays(int[] Array)
        {
            int result = 0;
            for (int i = 0; i < Array.Length; i++)
                result += Array[i];
            return result;
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
        public static int Ejemplo03(int pos)
        {
            int[] Array = new int[pos];
            Array_Ejemplo_Leer(Array);
            return SumarArrays(Array) / Array.Length;
        }

        public static int[] Default_Array() //Crear un array para hacer pruebas
        {
            int[] Array = new int[10];
            for (int i = 0; i < Array.Length; i++)            
                Array[i] = i * 2;            
            return Array;
        }
        public static int[] Default_Array_02()
        {
            int[] Array = new int[10];
            Array[0] = 5;
            Array[1] = 8;
            Array[2] = 1;
            Array[3] = 4;
            Array[4] = 12;
            Array[5] = 11;
            Array[6] = 16;
            Array[7] = 9;
            Array[8] = 7;
            Array[9] = 17;
            return Array;
        }
        public static int Buscar_Array(int[] Array, int Num)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Num)
                    return i;
            }
            return -1;
        }
        public static void ordenarVector(int[] vector)
        {
            int i, j;
            int aux, tam;
            tam = vector.Length;
            for (i = 0; i < tam - 1; i++)
                for (j = i + 1; j < tam; j++)
                    if (vector[j] < vector[i])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
        }
        static void Main(string[] args)
        {
            //Array_Ejemplo(5);
            //Ejemplo02(10, 2);
            //int b = Ejemplo03(5);
            Default_Array();
            ordenarVector(Default_Array_02());
            int b = string.Compare("hola", "adios");

            
        }
    }
}
