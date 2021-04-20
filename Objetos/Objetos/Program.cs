using System;
using System.Collections;
using System.Collections.Generic;

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
        public static void ApuntesClases()
        {
            //EjProfe();
            PersonaApuntes.Cliente profe_juanfran = new PersonaApuntes.Cliente();
            profe_juanfran.nombre = "Juan Francisco";
            profe_juanfran.apellidos = "Bueno";
            profe_juanfran.edad = 45;
            profe_juanfran.dni = "123456789";
        }
        public static void Ej01()
        {
            List<Persona> ListaPersonas = new List<Persona>();
            bool salir = false;
            do
            {
                Console.WriteLine("-- Ejercicio 01 --");
                Console.WriteLine("1.- Guardar Persona");
                Console.WriteLine("2.- Mostrar Personas registradas");
                Console.WriteLine("3.- Salir");
                Console.Write("Elige una opción: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        SetPersona(ListaPersonas);
                        Console.Write("Pulse enter para continuar: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        PrintPersona(ListaPersonas);
                        Console.Write("Pulse enter para continuar: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.Write("Opción inválida, pulse enter: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (salir == false);
            

        }
        public static void SetPersona(List<Persona> ListaPersonas)
        {
            Persona NuevaPersona = new Persona();

            Console.Write("Introduce el nombre: ");
            NuevaPersona.SetNombre(Console.ReadLine());
            Console.Write("Introduce la edad: ");
            NuevaPersona.SetEdad(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Introduce el teléfono: ");
            NuevaPersona.SetTelefono(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Introduce el sexo: ");
            NuevaPersona.SetSexo((Console.ReadLine()));
            Console.Write("Introduce el estado civil: ");
            NuevaPersona.SetEstadoCivil((Console.ReadLine()));
            
            ListaPersonas.Add(NuevaPersona);
        }
        public static void PrintPersona(List<Persona> ListaPersonas)
        {
            for (int i = 0; i < ListaPersonas.Count; i++)
            {
                Console.WriteLine("El nombre de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetNombre());
                Console.WriteLine("La edad de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetEdad());
                Console.WriteLine("El teléfono de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetTelefono());
                Console.WriteLine("El sexo de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetSexo());
                Console.WriteLine("El estado civil de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetEstadoCivil());
                Console.WriteLine();
            }            
        }
        static void Main(string[] args)
        {
            Ej01();
        }
    }
}
