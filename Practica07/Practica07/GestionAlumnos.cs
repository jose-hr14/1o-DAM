using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class GestionAlumnos
    {
        //Alumnos
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
        public static void EliminarAlumno(tListadeAlumnos listadeAlumnos, string nombre)
        {
            for (int i = 0; i < listadeAlumnos.NumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeAlumnos.BorrarAlumno(i);
                }
            }            
        }
        public static void MostrarListaAlumnos(tListadeAlumnos listadeAlumnos)
        {
            tAlumno alumno;
            for (int i = 0; i < listadeAlumnos.NumeroAlumnos(); i++)
            {
                alumno = listadeAlumnos.DevolverAlumno(i);
                ImpimirAlumno(alumno);
            }
        }
        public static void OrdenarAlumnosAlfabeticamente(tListadeAlumnos listadeAlumnos)
        {
            listadeAlumnos.OrdernarAlfabeticamente();
        }

        public static void MostrarDatosPorNombre(tListadeAlumnos listadeAlumnos, string nombre)
        {
            tAlumno alumno;

            for (int i = 0; i < listadeAlumnos.NumeroAlumnos(); i++)
            {                  
                if (listadeAlumnos.DevolverAlumno(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    alumno = listadeAlumnos.DevolverAlumno(i);
                    ImpimirAlumno(alumno);
                }
            }
        }
        
        public static void MostrarAlumnosDeUnCurso(tListadeAlumnos listadeAlumnos, int codigoCurso)
        {
            Gestion_Cursos.MostrarAlumnosDeUnCurso(listadeAlumnos, codigoCurso);
        }

        //Notas
        public static void AñadirNotasAAlumno(tListadeAlumnos listadeAlumnos, string nombre, double nota)
        {
            for (int i = 0; i < listadeAlumnos.NumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeAlumnos.DevolverAlumno(i).AñadirNotas(nota);
                }
            }
            //listadeAlumnos.DevolverAlumno(codigoAlumno).AñadirNotas(nota);
        }

        public static void MostrarAlumnoMediaSuperioACinco(tListadeAlumnos listadeAlumnos)
        {
            tAlumno alumno;
            for (int i = 0; i < listadeAlumnos.NumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).DevolverNotaMedia() >= 5)
                {
                    alumno = listadeAlumnos.DevolverAlumno(i);
                    ImpimirAlumno(alumno);
                }
            }
        }

        public static void EliminarNotasAlumno(tListadeAlumnos listadeAlumnos, string nombre)
        {
            for (int i = 0; i < listadeAlumnos.NumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).GetNombre().Trim().ToLower() == nombre.Trim().ToLower())
                {
                    listadeAlumnos.DevolverAlumno(i).BorrarNotas();
                }
            }
        }

        public static void MostrarAlumnoMediaMenorACinco(tListadeAlumnos listadeAlumnos)
        {
            tAlumno alumno;
            for (int i = 0; i < listadeAlumnos.NumeroAlumnos(); i++)
            {
                if (listadeAlumnos.DevolverAlumno(i).DevolverNotaMedia() < 5)
                {
                    alumno = listadeAlumnos.DevolverAlumno(i);
                    ImpimirAlumno(alumno);
                }
            }
        }

        public static void MenuIntroducirAlumno(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce un dni: ");
            string dni = Console.ReadLine();
            Console.Write("Introduce un telefono: ");
            int tlf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce un codigo de curso: ");
            int codigoCurso = Convert.ToInt32(Console.ReadLine());
            IntroducirAlumno(listadeAlumnos, nombre, dni, tlf, codigoCurso);
            Console.WriteLine("Alumno insertado correctamente");
        }
        public static void MenuEliminarAlumno(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el nombre del alumno que desees eliminar: ");
            string nombre = Console.ReadLine();
            EliminarAlumno(listadeAlumnos, nombre);
            Console.WriteLine("Alumno eliminado correctamente");
        }
        public static void MenuMostrarListaAlumnos(tListadeAlumnos listadeAlumnos)
        {
            MostrarListaAlumnos(listadeAlumnos);
        }
        public static void MenuOrdenarAlumnosAlfabeticamente(tListadeAlumnos listadeAlumnos)
        {
            OrdenarAlumnosAlfabeticamente(listadeAlumnos);
            Console.WriteLine("Alumnos ordenados correctamente");
        }
        public static void MenuMostrarDatosAlumnosPorNombre(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el nombre del alumno cuyos datos quieres mostrar: ");
            string nombre = Console.ReadLine();
            MostrarDatosPorNombre(listadeAlumnos, nombre);            
        }
        public static void MenuMostrarAlumnosPorCurso(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el código del curso cuyos alumnos quieres mostrar: ");
            int codigoCurso = Convert.ToInt32(Console.ReadLine());
            MostrarAlumnosDeUnCurso(listadeAlumnos, codigoCurso);
        }
        public static void MenuAñadirNotasAAlumno(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el nombre del alumno al que quieres añadir una nota: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce la nota que quieres añadirle al alumno: ");
            double nota = Convert.ToDouble(Console.ReadLine());
            AñadirNotasAAlumno(listadeAlumnos, nombre, nota);
        }
        public static void MenuMostrarAlumnoPorMediaSuperiorCinco(tListadeAlumnos listadeAlumnos)
        {
            MostrarAlumnoMediaSuperioACinco(listadeAlumnos);
        }
        public static void MenuEliminarNotasAlumno(tListadeAlumnos listadeAlumnos)
        {
            Console.Write("Introduce el nombre del alumno al que quieres eliminar las notas: ");
            string nombre = Console.ReadLine();
            EliminarNotasAlumno(listadeAlumnos, nombre);
        }
        public static void MenuMostrarAlumnoPorMediaInferiorCinco(tListadeAlumnos listadeAlumnos)
        {
            MostrarAlumnoMediaMenorACinco(listadeAlumnos);
        }
        public static void MenuPrincipal(tListadeCursos listadeCursos, tListadeAlumnos listadeAlumnos)
        {
            string opcion = "";
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
                opcion = Console.ReadLine();
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
