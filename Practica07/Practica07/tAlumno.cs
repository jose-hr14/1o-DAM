using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class tAlumno
    {
        string nombre;
        string dni;
        int telefono;
        List<double> listaNotas;
        int codigoCurso;

        public tAlumno(string nombre, string dni, int telefono, int codigoCurso)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            listaNotas = new List<double>();
            this.codigoCurso = codigoCurso;
        }
        public tAlumno()
        {

        }
        public int DevolverCodigoCurso()
        {
            return this.codigoCurso;
        }
    }
}
