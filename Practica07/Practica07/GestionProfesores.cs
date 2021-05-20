using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class GestionProfesores
    {
        public static void ImpimirProfesor(tProfesor profesor)
        {
            Console.WriteLine("Nombre: " + profesor.GetNombre());
            Console.WriteLine("DNI: " + profesor.GetDNI());
            Console.WriteLine("Teléfono: " + profesor.GetTelefono());
            Console.WriteLine("Código de curso: " + profesor.GetCodigoCurso());            
            Console.WriteLine();
        }
        public static void IntroducirProfesor(tListadeProfesores listadeProfesores, string nombre, string dni, int telefono, int codigoCurso)
        {
            tProfesor nuevoProfesor = new tProfesor(nombre, dni, telefono, codigoCurso);
            listadeProfesores.AñadirProfesor(nuevoProfesor);
        }

        public static void EliminarProfesor(tListadeProfesores listadeProfesores, string nombre)
        {
            for (int i = 0; i < listadeProfesores.NumeroProfesores(); i++)
            {
                if (listadeProfesores.DevolverProfesor(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeProfesores.BorrarProfesor(i);
                }
            }
        }
        public static void MostrarListaProfesores(tListadeProfesores listadeProfesores)
        {
            tProfesor profesor;
            for (int i = 0; i < listadeProfesores.NumeroProfesores(); i++)
            {
                profesor = listadeProfesores.DevolverProfesor(i);
                ImpimirProfesor(profesor);
            }
        }
        public static void OrdenarProfesoresAlfabeticamente(tListadeProfesores listadeProfesores)
        {
            listadeProfesores.OrdernarAlfabeticamente();
        }
        public static void MostrarDatosPorNombre(tListadeProfesores listadeProfesores, string nombre)
        {
            tProfesor profesor;

            for (int i = 0; i < listadeProfesores.NumeroProfesores(); i++)
            {
                if (listadeProfesores.DevolverProfesor(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    profesor = listadeProfesores.DevolverProfesor(i);
                    ImpimirProfesor(profesor);
                }
            }
        }


        public static void AñadirAsignaturaProfesor(tListadeProfesores listadeProfesores, string nombre, string asignatura)
        {
            for (int i = 0; i < listadeProfesores.NumeroProfesores(); i++)
            {
                if (listadeProfesores.DevolverProfesor(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeProfesores.DevolverProfesor(i).AñadirAsignaturas(asignatura);
                }
            }            
        }
        public static void EliminarAsignaturaProfesor(tListadeProfesores listadeProfesores, string nombre)
        {
            for (int i = 0; i < listadeProfesores.NumeroProfesores(); i++)
            {
                if (listadeProfesores.DevolverProfesor(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeProfesores.DevolverProfesor(i).BorrarAsignaturas();
                }
            }
        }
        public static void MostrarProfesoresPorAsignatura(tListadeProfesores listadeProfesores, string nombreAsignatura)
        {
            tProfesor profesor;
            for (int i = 0; i < listadeProfesores.NumeroProfesores(); i++)
            {
                profesor = listadeProfesores.DevolverProfesor(i);
                if (profesor.ContieneAsignatura(nombreAsignatura))
                    ImpimirProfesor(profesor);
            }
        }


        public static void MenuIntroducirProfesor(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce un dni: ");
            string dni = Console.ReadLine();
            Console.Write("Introduce un telefono: ");
            int tlf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un codigo de curso: ");
            int codigoCurso = Convert.ToInt32(Console.ReadLine());
            IntroducirProfesor(listadeProfesores, nombre, dni, tlf, codigoCurso);
            Console.WriteLine("Profesor insertado correctamente");
        }
        public static void MenuEliminarProfesor(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre del profesor que desees eliminar: ");
            string nombre = Console.ReadLine();
            EliminarProfesor(listadeProfesores, nombre);
            Console.WriteLine("Profesor eliminado correctamente");
        }
        public static void MenuMostrarListaProfesores(tListadeProfesores listadeProfesores)
        {
            MostrarListaProfesores(listadeProfesores);
        }
        public static void MenuOrdenarProfesoresAlfabeticamente(tListadeProfesores listadeProfesores)
        {
            OrdenarProfesoresAlfabeticamente(listadeProfesores);
            Console.WriteLine("Profesores ordenados correctamente");
        }
        public static void MenuMostrarDatosProfesoresPorNombre(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre del profesor cuyos datos quieres mostrar: ");
            string nombre = Console.ReadLine();
            MostrarDatosPorNombre(listadeProfesores, nombre);
        }
        public static void MenuAñadirAsignaturasProfesor(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre del profesor al que quieres añadir una asignatura: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce la asignatura que quieres añadirle al profesor: ");
            string asignatura = Console.ReadLine();
            AñadirAsignaturaProfesor(listadeProfesores, nombre, asignatura);
        }
        public static void MenuEliminarAsignaturasProfesor(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre del profesor al que quieres eliminar asignaturas: ");
            string nombre = Console.ReadLine();
            EliminarAsignaturaProfesor(listadeProfesores, nombre);
        }
        public static void MenuMostrarProfesoresPorAsignatura(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre de la asignatura para mostrar a los profesores que la imparten: ");
            string nombreAsignatura = Console.ReadLine();
            MostrarProfesoresPorAsignatura(listadeProfesores, nombreAsignatura);
        }
        public static void MenuPrincipal(tListadeProfesores listadeProfesores)
        {
            string opcion = "";
            bool salir = false;
            do
            {
                Console.WriteLine("-- Gestión de profesores --");
                Console.WriteLine("-- Profesores --");
                Console.WriteLine("1.- Introducir profesor");
                Console.WriteLine("2.- Eliminar profesor");
                Console.WriteLine("3.- Mostrar lista de profesores");
                Console.WriteLine("4.- Ordenar profesores por orden alfabético");
                Console.WriteLine("5.- Mostrar datos de profesor por nombre");                
                Console.WriteLine("-- Asignaturas --");
                Console.WriteLine("6.- Añadir aignatura a profesor");                
                Console.WriteLine("7. Eliminar las asignaturas de un profesor");
                Console.WriteLine("8. Mostrar profesores que imparten una asignatura");
                Console.WriteLine("0.- Salir");
                Console.Write("Elige una opción: ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        MenuIntroducirProfesor(listadeProfesores);
                        break;
                    case "2":
                        Console.Clear();
                        MenuEliminarProfesor(listadeProfesores);
                        break;
                    case "3":
                        Console.Clear();
                        MenuMostrarListaProfesores(listadeProfesores);
                        break;
                    case "4":
                        Console.Clear();
                        MenuOrdenarProfesoresAlfabeticamente(listadeProfesores);
                        break;
                    case "5":
                        Console.Clear();
                        MenuMostrarDatosProfesoresPorNombre(listadeProfesores);
                        break;
                    case "6":
                        Console.Clear();
                        MenuAñadirAsignaturasProfesor(listadeProfesores);
                        break;
                    case "7":
                        Console.Clear();
                        MenuEliminarAsignaturasProfesor(listadeProfesores);
                        break;
                    case "8":
                        Console.Clear();
                        MenuMostrarProfesoresPorAsignatura(listadeProfesores);
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

        public static void EnterParaContinuar()
        {
            Console.Write("Pulsa enter para continuar: ");
            Console.ReadLine();
        }
    }
}
