using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica07
{
    class Program
    {
        static void Main()
        {
            tListadeAlumnos listaAlumnos = new tListadeAlumnos();
            tListadeProfesores listaProfesores = new tListadeProfesores();
            tListadeCursos listaCursos = new tListadeCursos();
            bool salir = false;
            do
            {
                Console.WriteLine("-- Gestión Instituto --");
                Console.WriteLine("1.- Gestión cursos");
                Console.WriteLine("2.- Gestión alumnos");
                Console.WriteLine("3.- Gestión profesores");
                Console.WriteLine("0.- Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Gestion_Cursos.MenuPrincipal(listaCursos, listaAlumnos);
                        break;
                    case "2":
                        Console.Clear();
                        GestionAlumnos.MenuPrincipal(listaAlumnos);
                        break;
                    case "3":
                        Console.Clear();
                        GestionProfesores.MenuPrincipal(listaProfesores);
                        break;
                    case "0":
                        salir = true;
                        Console.WriteLine("Saliendo del programa");
                        Utilidades.PulsaTeclaParaContinuar();
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        Utilidades.PulsaTeclaParaContinuar();
                        break;
                }
                Console.Clear();
            } while (salir == false);            
        }
    }
}
