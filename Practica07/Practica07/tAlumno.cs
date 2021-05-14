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
            this.listaNotas = new List<double>();
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetDNI()
        {
            return this.dni;
        }
        public int GetTelefono()
        {
            return this.telefono;
        }
        public List<double> GetListaNotas()
        {
            return this.listaNotas;
        }
        public int GetCodigoCurso()
        {
            return this.codigoCurso;
        }
        public tAlumno GetAlumno()
        {
            return this;
        }
    }
}
