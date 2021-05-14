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
    }
}
