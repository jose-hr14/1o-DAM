using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class GestionAlumnos
    {
        public static void IntroducirAlumno(tListadeAlumnos listadeAlumnos, string nombre, string dni, int telefono, int codigoCurso)
        {
            tAlumno nuevoAlumno = new tAlumno(nombre, dni, telefono, codigoCurso);
            listadeAlumnos.AñadirAlumno(nuevoAlumno);
        }
        public static void EliminarAlumno(tListadeAlumnos listadeAlumnos, int indice)
        {
            listadeAlumnos.BorrarAlumno(indice);
        }
        public static void MostrarListaAlumnos(tListadeAlumnos listadeAlumnos)
        {
            tAlumno alumno;
            for (int i = 0; i < listadeAlumnos.NumeroAlumnos(); i++)
            {
                alumno = listadeAlumnos.GetAlumno(i);
                Console.WriteLine(alumno.GetNombre());
                Console.WriteLine(alumno.GetDNI());
                Console.WriteLine(alumno.GetTelefono());
                Console.WriteLine(alumno.GetCodigoCurso());
                Console.WriteLine();
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
                if (listadeAlumnos.GetAlumno(i).GetNombre() == nombre)
                {
                    alumno = listadeAlumnos.GetAlumno(i);
                    Console.WriteLine(alumno.GetNombre());
                    Console.WriteLine(alumno.GetDNI());
                    Console.WriteLine(alumno.GetTelefono());
                    Console.WriteLine(alumno.GetCodigoCurso());
                    Console.WriteLine();
                }
            }
        }
        
        public static void MostrarAlumnosDeUnCurso(tListadeAlumnos listadeAlumnos, int codigoCurso)
        {
            Gestion_Cursos.MostrarAlumnosDeUnCurso(listadeAlumnos, codigoCurso);
        }
    }
}
