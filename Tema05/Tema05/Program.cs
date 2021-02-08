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

        //Realiza un programa en Visual C# que lea 10 números por teclado, y después los
        //muestre.Utiliza para ello un vector.
        public static void Ejercicio01()
        {
            int[] Array = new int[10];
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Inserta un número para la posición " + i + ": ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("La posición " + i + " del Array es: " + Array[i]);
            }
        }
        public static int[] CrearArray(int Length)
        {
            int[] Array = new int[Length];
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Inserta un número para la posición " + i + ": ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return Array;
        }
        public static int Media(int[] Array)
        {
            int Media = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                Media += Array[i];
            }
            return Media / Array.Length;
        }
        //Realizar un programa que lea los elementos de un array o vector de 10 enteros y visualice
        //su media.La media se calculará mediante una función. (Ejercicio Resuelto)
        public static void Ejercicio02()
        {
            Console.WriteLine("La media es: " + Media(CrearArray(10)));

        }
        //Realizar un programa que lea los elementos de un vector de 10 enteros y nos visualice
        //posteriormente el menor de ellos.Utilizar programación modular, una función que lea el
        //vector, otra que lo muestre y otra que devuelva el menor número del vector.
        public static void OrdenarArray(int[] Array)
        {
            int aux;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        aux = Array[i];
                        Array[i] = Array[j];
                        Array[j] = aux;
                    }
                }
            }
        }
        public static void Ejercicio03()
        {
            int[] Array = CrearArray(10);
            OrdenarArray(Array);
            Console.WriteLine("El menor de los elementos del vector es " + Array[0]);
        }
        static void Main(string[] args)
        {
            //Array_Ejemplo(5);
            //Ejemplo02(10, 2);
            //int b = Ejemplo03(5);
            //Ejercicio01();
            //Ejercicio02();
            Ejercicio03();
        }
    }
}
