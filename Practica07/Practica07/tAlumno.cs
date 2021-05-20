using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class tAlumno
    {
        private string nombre;
        private string dni;
        private int telefono;
        private List<double> listaNotas;
        private int codigoCurso;

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
        public void SetCodigoCurso(int codigoCurso)
        {
            this.codigoCurso = codigoCurso;
        }
        public void SetListaNotas(List<double> listaNotas)
        {
            this.listaNotas = listaNotas;
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

        public void AñadirNotas(double nota)
        {
            this.listaNotas.Add(nota);
        }

        public double DevolverNotaMedia()
        {
            if (listaNotas.Count == 0)
                return 0;
            double total = 0;
            for (int i = 0; i < this.listaNotas.Count; i++)
            {
                total += listaNotas[i];
            }
            return (total / listaNotas.Count);
        }

        public void BorrarNotas()
        {
            this.listaNotas.Clear();
        }
    }
}
