using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class Gestion_Cursos
    {
        //Funciones
        public static void AñadirCurso(tListadeCursos ListaCursos, string nombre)
        {
            tCurso nuevoCurso = new tCurso(nombre, ListaCursos.NumeroCursos());
            ListaCursos.AñadirCurso(nuevoCurso);
        }
        public static void EliminarCurso(tListadeCursos ListaCursos, int codigoCurso)
        {
            ListaCursos.EliminarCurso(codigoCurso);
        }
        public static void MostrarTodosCursos(tListadeCursos ListaCursos)
        {
            Console.WriteLine();
            for (int i = 0; i < ListaCursos.NumeroCursos(); i++)
            {
                Console.Write("Nombre del curso:");
                Console.WriteLine(ListaCursos.DevolverCurso(i).GetNombre());
                Console.Write("Codigo del curso: ");
                Console.WriteLine(ListaCursos.DevolverCurso(i).GetCodigo());
                Console.WriteLine();
            }            
        }
        public static bool MostrarAlumnosDeUnCurso(tListadeAlumnos ListaAlumnos, int codigoCurso)
        {
            int count = 0;
            for (int i = 0; i < ListaAlumnos.DevolverNumeroAlumnos(); i++)
            {
                if (ListaAlumnos.DevolverAlumno(i).GetCodigoCurso() == codigoCurso)
                {
                    ImprimirAlumno(ListaAlumnos.DevolverAlumno(i));
                    count++;
                }                    
            }
            if (count == 0)
                return false;
            else
                return true;
        }

        public static void ImprimirAlumno(tAlumno alumno)
        {
            Console.WriteLine("Nombre: " + alumno.GetNombre());
            Console.WriteLine("DNI: " + alumno.GetDNI());
            Console.WriteLine("Teléfono: " + alumno.GetTelefono());
            Console.WriteLine("Código de curso: " + alumno.GetCodigoCurso());
            Console.WriteLine();
        }

        public static void MenuPrincipal(tListadeCursos listadeCursos, tListadeAlumnos listadeAlumnos)
        {
            bool salir = false;
            do
            {
                Console.WriteLine("-- Gestión de cursos --");
                Console.WriteLine("1.- Añadir Curso");
                Console.WriteLine("2.- Eliminar curso");
                Console.WriteLine("3.- Mostrar todos los cursos");
                Console.WriteLine("4.- Mostrar todos los alumnos pertenecientes a un curso");
                Console.WriteLine("0.- Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        MenuAñadirCurso(listadeCursos);
                        break;
                    case "2":
                        Console.Clear();
                        MenuEliminarCurso(listadeCursos);
                        break;
                    case "3":
                        Console.Clear();
                        MostrarTodosCursos(listadeCursos);
                        break;
                    case "4":
                        Console.Clear();
                        MenuMostrarAlumnosCurso(listadeAlumnos);
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

        public static void MenuAñadirCurso(tListadeCursos listadeCursos)
        {            
            string nombreCurso;

            while (true)
            {
                Console.Write("Introduce un nombre para el curso: ");
                nombreCurso = Console.ReadLine();
                if (listadeCursos.ContieneNombre(nombreCurso))
                {
                    Console.WriteLine("El curso ya existe, introduzca otro nombre:");
                    continue;
                }                
                break;                
            }
            AñadirCurso(listadeCursos, nombreCurso);
        }
        public static void MenuEliminarCurso(tListadeCursos listadeCursos)
        {
            int codigoCurso;

            while (true)
            {                
                codigoCurso = Utilidades.PedirInt("Introduce el codigo de curso que quieres eliminar, o escriba - 1 para salir: ");
                if (codigoCurso == -1)
                    return;
                if (!listadeCursos.ContieneCodigo(codigoCurso))
                {
                    Console.WriteLine("El curso que quiere borrar no existe, vuelva a intentarlo: ");
                    continue;
                }
                break;
            }
            EliminarCurso(listadeCursos, codigoCurso);
            Console.WriteLine("Curso eliminado con éxito.");
        }
        public static void MenuMostrarAlumnosCurso(tListadeAlumnos listadeAlumnos)
        {            
            int codigoCurso = Utilidades.PedirInt("Introduce el codigo de curso para imprimir a sus alumnos: ");
            bool existenAlumnos = MostrarAlumnosDeUnCurso(listadeAlumnos, codigoCurso);
            if (!existenAlumnos)
                Console.WriteLine("No hay alumnos asignados a ese codigo de curso");
        }
    }
}
