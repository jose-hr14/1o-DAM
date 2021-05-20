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
