using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class GestionAlumnos
    {
        public static void ImpimirAlumno(tAlumno alumno)
        {            
            Console.WriteLine("Nombre: " + alumno.GetNombre());
            Console.WriteLine("DNI: " + alumno.GetDNI());
            Console.WriteLine("Teléfono: " + alumno.GetTelefono());
            Console.WriteLine("Código de curso: " + alumno.GetCodigoCurso());
            Console.WriteLine("Nota media: " + alumno.DevolverNotaMedia());
            Console.WriteLine();
        }
        public static void IntroducirAlumno(tListadeAlumnos listadeAlumnos, string nombre, string dni, int telefono, int codigoCurso)
        {
            tAlumno nuevoAlumno = new tAlumno(nombre, dni, telefono, codigoCurso);
            listadeAlumnos.AñadirAlumno(nuevoAlumno);
        }
        public static bool EliminarAlumno(tListadeAlumnos listadeAlumnos, string nombre)
        {
            for (int i = 0; i < listadeAlumnos.DevolverNumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeAlumnos.BorrarAlumno(i);
                    return true;
                }
            }
            return false;
        }
        public static void MostrarListaAlumnos(tListadeAlumnos listadeAlumnos)
        {
            tAlumno alumno;
            for (int i = 0; i < listadeAlumnos.DevolverNumeroAlumnos(); i++)
            {
                alumno = listadeAlumnos.DevolverAlumno(i);
                ImpimirAlumno(alumno);
            }
        }
        public static void OrdenarAlumnosAlfabeticamente(tListadeAlumnos listadeAlumnos)
        {
            listadeAlumnos.OrdernarAlfabeticamente();
        }

        public static bool MostrarDatosPorNombre(tListadeAlumnos listadeAlumnos, string nombre)
        {
            tAlumno alumno;

            for (int i = 0; i < listadeAlumnos.DevolverNumeroAlumnos(); i++)
            {                  
                if (listadeAlumnos.DevolverAlumno(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    alumno = listadeAlumnos.DevolverAlumno(i);
                    ImpimirAlumno(alumno);
                    return true;
                }
            }
            return false;
        }
        public static bool AñadirNotasAAlumno(tListadeAlumnos listadeAlumnos, string nombre, double nota)
        {
            for (int i = 0; i < listadeAlumnos.DevolverNumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeAlumnos.DevolverAlumno(i).AñadirNotas(nota);
                    return true;
                }
            }
            return false;
        }
        public static bool MostrarAlumnoMediaSuperioACinco(tListadeAlumnos listadeAlumnos)
        {
            tAlumno alumno;
            int count = 0;
            for (int i = 0; i < listadeAlumnos.DevolverNumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).DevolverNotaMedia() >= 5)
                {
                    alumno = listadeAlumnos.DevolverAlumno(i);
                    ImpimirAlumno(alumno);
                    count++;
                }
            }
            if (count > 0)
                return true;
            else
                return false;
        }
        public static bool EliminarNotasAlumno(tListadeAlumnos listadeAlumnos, string nombre)
        {
            for (int i = 0; i < listadeAlumnos.DevolverNumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeAlumnos.DevolverAlumno(i).BorrarNotas();
                    return true;
                }
            }
            return false;
        }
        public static bool MostrarAlumnoMediaMenorACinco(tListadeAlumnos listadeAlumnos)
        {
            tAlumno alumno;
            int count = 0;

            for (int i = 0; i < listadeAlumnos.DevolverNumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).DevolverNotaMedia() < 5)
                {
                    alumno = listadeAlumnos.DevolverAlumno(i);
                    ImpimirAlumno(alumno);
                    count++;
                }
            }
            if (count > 0)
                return true;
            else
                return false;
        }
        public static void MenuIntroducirAlumno(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce un dni: ");
            string dni = Console.ReadLine();
            int tlf = Utilidades.PedirInt("Introduce un telefono: ");
            int codigoCurso = Utilidades.PedirInt("Introduce un codigo de curso: ");
            IntroducirAlumno(listadeAlumnos, nombre, dni, tlf, codigoCurso);
            Console.WriteLine("Alumno insertado correctamente");
        }
        public static void MenuEliminarAlumno(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el nombre del alumno que desees eliminar: ");
            string nombre = Console.ReadLine();
            bool existeAlumno = EliminarAlumno(listadeAlumnos, nombre);
            if (existeAlumno)
                Console.WriteLine("Alumno eliminado correctamente");
            else
                Console.WriteLine("Alumno no encontrado");
        }
        public static void MenuMostrarListaAlumnos(tListadeAlumnos listadeAlumnos)
        {
            MostrarListaAlumnos(listadeAlumnos);            
            if (listadeAlumnos.DevolverNumeroAlumnos() == 0)
                Console.WriteLine("No hay alumnos para mostrar");
        }
        public static void MenuOrdenarAlumnosAlfabeticamente(tListadeAlumnos listadeAlumnos)
        {
            OrdenarAlumnosAlfabeticamente(listadeAlumnos);
            if (listadeAlumnos.DevolverNumeroAlumnos() == 0)
                Console.WriteLine("No hay alumnos para ordenar");
            else
                Console.WriteLine("Alumnos ordenados correctamente");
        }
        public static void MenuMostrarDatosAlumnosPorNombre(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el nombre del alumno cuyos datos quieres mostrar: ");
            string nombre = Console.ReadLine();
            bool existeAlumno = MostrarDatosPorNombre(listadeAlumnos, nombre);
            if (!existeAlumno)
                Console.WriteLine("Alumno no encontrado");
        }
        public static void MenuMostrarAlumnosPorCurso(tListadeAlumnos listadeAlumnos)
        {
            Gestion_Cursos.MenuMostrarAlumnosCurso(listadeAlumnos);
        }
        public static void MenuAñadirNotasAAlumno(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el nombre del alumno al que quieres añadir una nota: ");
            string nombre = Console.ReadLine();            
            double nota = Utilidades.PedirDouble("Introduce la nota que quieres añadirle al alumno: ");
            bool existeAlumno = AñadirNotasAAlumno(listadeAlumnos, nombre, nota);
            if (existeAlumno)
                Console.WriteLine("Nota insertada correctamente");
            else
                Console.WriteLine("Alumno no encontrado");

        }
        public static void MenuMostrarAlumnoPorMediaSuperiorCinco(tListadeAlumnos listadeAlumnos)
        {
            bool existenAlumnos = MostrarAlumnoMediaSuperioACinco(listadeAlumnos);
            if (!existenAlumnos)
                Console.WriteLine("No existen alumnos con una media superior a 5");
        }
        public static void MenuEliminarNotasAlumno(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el nombre del alumno al que quieres eliminar las notas: ");
            string nombre = Console.ReadLine();
            bool existeAlumno = EliminarNotasAlumno(listadeAlumnos, nombre);
            if (existeAlumno)
                Console.WriteLine("Notas borradas correctamente");
            else
                Console.WriteLine("Alumno no encontrado");
        }
        public static void MenuMostrarAlumnoPorMediaInferiorCinco(tListadeAlumnos listadeAlumnos)
        {
            bool existenAlumnos = MostrarAlumnoMediaMenorACinco(listadeAlumnos);
            if (!existenAlumnos)
                Console.WriteLine("No existen alumnos con una media inferior a 5");
        }
        public static void MenuPrincipal(tListadeAlumnos listadeAlumnos)
        {
            bool salir = false;
            do
            {
                Console.WriteLine("-- Gestión de alumnos --");
                Console.WriteLine("-- Alumnos --");
                Console.WriteLine("1.- Introducir alumno");
                Console.WriteLine("2.- Eliminar alumno");
                Console.WriteLine("3.- Mostrar lista de alumnos");
                Console.WriteLine("4.- Ordenar alumnos por orden alfabético");
                Console.WriteLine("5.- Mostrar datos de alumno por nombre");
                Console.WriteLine("6.- Mostrar alumnos pertenecientes a un curso");
                Console.WriteLine("-- Notas --");
                Console.WriteLine("7.- Añadir notas a alumno");
                Console.WriteLine("8. Mostrar alumnos con nota media mayor a 5");
                Console.WriteLine("9. Eliminar las notas de un alumno");
                Console.WriteLine("10. Mostrar alumnos con nota media inferior a 5");
                Console.WriteLine("0.- Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        MenuIntroducirAlumno(listadeAlumnos);
                        break;
                    case "2":
                        Console.Clear();
                        MenuEliminarAlumno(listadeAlumnos);
                        break;
                    case "3":
                        Console.Clear();
                        MenuMostrarListaAlumnos(listadeAlumnos);
                        break;
                    case "4":
                        Console.Clear();
                        MenuOrdenarAlumnosAlfabeticamente(listadeAlumnos);
                        break;
                    case "5":
                        Console.Clear();
                        MenuMostrarDatosAlumnosPorNombre(listadeAlumnos);
                        break;
                    case "6":
                        Console.Clear();
                        MenuMostrarAlumnosPorCurso(listadeAlumnos);
                        break;
                    case "7":
                        Console.Clear();
                        MenuAñadirNotasAAlumno(listadeAlumnos);
                        break;
                    case "8":
                        Console.Clear();
                        MenuMostrarAlumnoPorMediaSuperiorCinco(listadeAlumnos);
                        break;
                    case "9":
                        Console.Clear();
                        MenuEliminarNotasAlumno(listadeAlumnos);
                        break;
                    case "10":
                        Console.Clear();
                        MenuMostrarAlumnoPorMediaInferiorCinco(listadeAlumnos);
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
