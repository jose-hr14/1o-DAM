using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        //
        //
        public static void PrintFechas(List<Fecha> Lista)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Lista[i].PrintFecha();
            }
        }
        public static void OrderFechaByDia(List<Fecha> Lista)
        {
            Lista.Sort();
        }
        public static void OrderByAño(List<Fecha> Lista)
        {
            //Lista.Sort((x, y) => x.GetAño().CompareTo(y.GetAño()));
            Fecha aux;
            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j =i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i].GetAño() > Lista[j].GetAño())
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
                }
            }
        }
        public static void OrderByMes(List<Fecha> Lista)
        {
            //Lista.Sort((x, y) => x.GetAño().CompareTo(y.GetAño()));
            Fecha aux;
            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i].GetMes() > Lista[j].GetMes() && Lista[i].GetAño() == Lista[j].GetAño())
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
                }
            }
        }
        public static void OrderByDia(List<Fecha> Lista)
        {
            //Lista.Sort((x, y) => x.GetAño().CompareTo(y.GetAño()));
            Fecha aux;
            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i].GetMes() > Lista[j].GetMes() && Lista[i].GetAño() == Lista[j].GetAño() && Lista[i].GetMes() == Lista[j].GetMes())
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
                }
            }
        }
        public static bool ValidateFecha(int dia, int mes, int año)
        {
            if (mes < 0 && mes > 13)
                return false;
            if (dia < 0 && dia > 31)
                return false;
            if ((mes == 4 || mes == 6 || mes == 9 || mes == 1) && dia > 30)
                return false;
            return true;

        }
        public static void Ej03()
        {
            List<Fecha> Lista = new List<Fecha>();
            Fecha fecha01 = new Fecha();
            Fecha fecha02 = new Fecha();
            Fecha fecha03 = new Fecha();
            Fecha fecha04 = new Fecha();

            fecha01.SetAño(1996);
            fecha01.SetMes(04);
            fecha01.SetDia(02);

            fecha02.SetAño(1996);
            fecha02.SetMes(05);
            fecha02.SetDia(01);

            fecha03.SetAño(1996);
            fecha03.SetMes(05);
            fecha03.SetDia(03);

            fecha04.SetAño(1992);
            fecha04.SetMes(02);
            fecha04.SetDia(01);

            Lista.Add(fecha01);
            Lista.Add(fecha02);
            Lista.Add(fecha03);
            Lista.Add(fecha04);

            OrderByAño(Lista);
            OrderByMes(Lista);
            OrderByDia(Lista);

        }
        static void Main(string[] args)
        {
            Ej03();
        }
    }
}
