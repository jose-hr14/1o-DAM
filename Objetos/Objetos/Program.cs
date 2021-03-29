using System;

namespace Objetos
{
    class Program
    {
        // Las lineas de codigo para crear un vector de enteros de 10 elementos, nos tiene que decir si el numero introducido está en el vector o no
        public static void EjProfe()
        {
            int[] Vector = new int[10] { 1, 7, 9, 8, 6, 11, 12, 13, 14, 5 };
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] == num)
                {
                    Console.WriteLine("El número está");
                    break;
                }
                    
                if (i == Vector.Length - 1)
                    Console.WriteLine("El número no está");
            }
        }
        public static void EjProfeSolucion()
        {
            int[] Vector = new int[10] { 1, 7, 9, 8, 6, 11, 12, 13, 14, 5 };
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] == num)
                {
                    Console.WriteLine("El número está");
                    break;
                }
                else if (i == Vector.Length - 1)
                    Console.WriteLine("El número no está");
            }
        }
        static void Main(string[] args)
        {
            //EjProfe();
            Cliente profe_juanfran = new Cliente();
            profe_juanfran.nombre = "Juan Francisco";
            profe_juanfran.apellidos = "Bueno";
            profe_juanfran.edad = 45;
            profe_juanfran.dni = "123456789";
        }
    }
}
