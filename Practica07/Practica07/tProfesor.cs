using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class tProfesor
    {
        private string nombre;
        private string dni;
        private int telefono;
        private List<string> listaAsignaturas;
        private int codigoCurso;

        public tProfesor(string nombre, string dni, int telefono, int codigoCurso)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            listaAsignaturas = new List<string>();
            this.codigoCurso = codigoCurso;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetDNI(string dni)
        {
            this.dni = dni;
        }
        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public void SetListaAsignaturas(List<string> listaAsignaturas)
        {
            this.listaAsignaturas = listaAsignaturas;
        }
        public void SetCodigoCurso(int codigoCurso)
        {
            this.codigoCurso = codigoCurso;
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
        public int GetCodigoCurso()
        {
            return this.codigoCurso;
        }

        public void AñadirAsignaturas(string asignatura)
        {
            this.listaAsignaturas.Add(asignatura);
        }
        public void BorrarAsignaturas()
        {
            this.listaAsignaturas.Clear();
        }
        public bool ContieneAsignatura(string nombreAsignatura)
        {
            if (this.listaAsignaturas.Contains(nombreAsignatura))
                return true;
            else
                return false;
        }
    }
}
