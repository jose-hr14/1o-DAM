using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class tProfesor
    {
        string nombre;
        string dni;
        int telefono;
        List<string> listaAsignaturas;
        int codigoCurso;

        public tProfesor(string nombre, string dni, int telefono, int codigoCurso)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            listaAsignaturas = new List<string>();
            this.codigoCurso = codigoCurso;
        }
    }
}
