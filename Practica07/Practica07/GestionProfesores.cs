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

        public static bool EliminarProfesor(tListadeProfesores listadeProfesores, string nombre)
        {
            for (int i = 0; i < listadeProfesores.DevolverNumeroProfesores(); i++)
            {
                if (listadeProfesores.DevolverProfesor(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeProfesores.BorrarProfesor(i);
                    return true;
                }
            }
            return false;
        }
        public static void MostrarListaProfesores(tListadeProfesores listadeProfesores)
        {
            tProfesor profesor;
            for (int i = 0; i < listadeProfesores.DevolverNumeroProfesores(); i++)
            {
                profesor = listadeProfesores.DevolverProfesor(i);
                ImpimirProfesor(profesor);
            }
        }
        public static void OrdenarProfesoresAlfabeticamente(tListadeProfesores listadeProfesores)
        {
            listadeProfesores.OrdernarAlfabeticamente();
        }
        public static bool MostrarDatosPorNombre(tListadeProfesores listadeProfesores, string nombre)
        {
            tProfesor profesor;

            for (int i = 0; i < listadeProfesores.DevolverNumeroProfesores(); i++)
            {
                if (listadeProfesores.DevolverProfesor(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    profesor = listadeProfesores.DevolverProfesor(i);
                    ImpimirProfesor(profesor);
                    return true;
                }
            }
            return false;
        }
        public static bool AñadirAsignaturaProfesor(tListadeProfesores listadeProfesores, string nombre, string asignatura)
        {
            for (int i = 0; i < listadeProfesores.DevolverNumeroProfesores(); i++)
            {
                if (listadeProfesores.DevolverProfesor(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeProfesores.DevolverProfesor(i).AñadirAsignaturas(asignatura);
                    return true;
                }
            }            
            return false; 
        }
        public static bool EliminarAsignaturaProfesor(tListadeProfesores listadeProfesores, string nombre)
        {
            for (int i = 0; i < listadeProfesores.DevolverNumeroProfesores(); i++)
            {
                if (listadeProfesores.DevolverProfesor(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeProfesores.DevolverProfesor(i).BorrarAsignaturas();
                    return true;
                }
            }
            return false;
        }
        public static bool MostrarProfesoresPorAsignatura(tListadeProfesores listadeProfesores, string nombreAsignatura)
        {
            tProfesor profesor;
            int count = 0;
            for (int i = 0; i < listadeProfesores.DevolverNumeroProfesores(); i++)
            {
                profesor = listadeProfesores.DevolverProfesor(i);
                if (profesor.ContieneAsignatura(nombreAsignatura))
                {
                    ImpimirProfesor(profesor);
                    count++;
                }                    
            }
            if (count == 0)
                return false;
            else
                return true;
        }
        public static void MenuIntroducirProfesor(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce un dni: ");
            string dni = Console.ReadLine();
            int tlf = Utilidades.PedirInt("Introduce un teléfono: ");
            int codigoCurso = Utilidades.PedirInt("Introduce un código de curso: ");
            IntroducirProfesor(listadeProfesores, nombre, dni, tlf, codigoCurso);
            Console.WriteLine("Profesor insertado correctamente");
        }
        public static void MenuEliminarProfesor(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre del profesor que desees eliminar: ");
            string nombre = Console.ReadLine();
            bool existeProfesor = EliminarProfesor(listadeProfesores, nombre);
            if (existeProfesor)
                Console.WriteLine("Profesor eliminado correctamente");
            else
                Console.WriteLine("Profesor no encontrado");
        }
        public static void MenuMostrarListaProfesores(tListadeProfesores listadeProfesores)
        {
            MostrarListaProfesores(listadeProfesores);
            if (listadeProfesores.DevolverNumeroProfesores() == 0)
                Console.WriteLine("No hay profesores para mostrar");
        }
        public static void MenuOrdenarProfesoresAlfabeticamente(tListadeProfesores listadeProfesores)
        {
            OrdenarProfesoresAlfabeticamente(listadeProfesores);
            if (listadeProfesores.DevolverNumeroProfesores() == 0)
                Console.WriteLine("No hay profesores para ordenar");
            else
                Console.WriteLine("Profesores ordenados correctamente");
        }
        public static void MenuMostrarDatosProfesoresPorNombre(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre del profesor cuyos datos quieres mostrar: ");
            string nombre = Console.ReadLine();
            bool existeProfesor = MostrarDatosPorNombre(listadeProfesores, nombre);
            if (!existeProfesor)
                Console.WriteLine("Profesor no encontrado");
        }
        public static void MenuAñadirAsignaturasProfesor(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre del profesor al que quieres añadir una asignatura: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce la asignatura que quieres añadirle al profesor: ");
            string asignatura = Console.ReadLine();
            bool existeProfesor = AñadirAsignaturaProfesor(listadeProfesores, nombre, asignatura);
            if (existeProfesor)
                Console.WriteLine("Asignatura añadida correctamente");
            else
                Console.WriteLine("Profesor no encontrado");
        }
        public static void MenuEliminarAsignaturasProfesor(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre del profesor al que quieres eliminar asignaturas: ");
            string nombre = Console.ReadLine();
            bool existeProfesor = EliminarAsignaturaProfesor(listadeProfesores, nombre);
            if (existeProfesor)
                Console.WriteLine("Se han eliminado las asignaturas de este profesor");
            else
                Console.WriteLine("Profesor no encontrado");
        }
        public static void MenuMostrarProfesoresPorAsignatura(tListadeProfesores listadeProfesores)
        {
            Console.Write("Introduce el nombre de la asignatura para mostrar a los profesores que la imparten: ");
            string nombreAsignatura = Console.ReadLine();
            bool existenProfesores = MostrarProfesoresPorAsignatura(listadeProfesores, nombreAsignatura);
            if (!existenProfesores)
                Console.WriteLine("No existen profesores que impartan esta asignatura");
        }
        public static void MenuPrincipal(tListadeProfesores listadeProfesores)
        {
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
                string opcion = Console.ReadLine();
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
                        salir = true;
                        Console.WriteLine("Volviendo al menú principal");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Utilidades.PulsaTeclaParaContinuar();
                Console.Clear();
            } while (salir == false);
        }
    }
}
