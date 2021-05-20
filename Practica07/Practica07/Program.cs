using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica07
{
    class Program
    {
        public static void EnterParaContinuar()
        {
            Console.Write("Pulsa enter para continuar: ");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            tListadeAlumnos listaAlumnos = new tListadeAlumnos();
            tListadeProfesores listaProfesores = new tListadeProfesores();
            tListadeCursos listaCursos = new tListadeCursos();

            string opcion = "";
            bool salir = false;
            do
            {
                Console.WriteLine("-- Gestión Instituto --");
                Console.WriteLine("1.- Gestión cursos");
                Console.WriteLine("2.- Gestión alumnos");
                Console.WriteLine("3.- Gestión profesores");
                Console.WriteLine("0.- Salir");
                Console.Write("Elige una opción: ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Gestion_Cursos.MenuPrincipal(listaCursos, listaAlumnos);
                        break;
                    case "2":
                        Console.Clear();
                        GestionAlumnos.MenuPrincipal(listaCursos, listaAlumnos);
                        break;
                    case "3":
                        Console.Clear();
                        GestionProfesores.MenuPrincipal(listaProfesores);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                EnterParaContinuar();
                Console.Clear();
            } while (salir == false);            
        }
    }
}
