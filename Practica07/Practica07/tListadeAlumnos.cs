using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class tListadeAlumnos
    {
        List<tAlumno> Lista;

        public tListadeAlumnos()
        {
            Lista = new List<tAlumno>();
        }
        public int NumeroAlumnos()
        {
            return this.Lista.Count;
        }
        public tAlumno GetAlumno(int codigo)
        {
            return this.Lista[codigo];
        }
    }
}
