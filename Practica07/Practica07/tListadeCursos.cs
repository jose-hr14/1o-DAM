using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    public class tListadeCursos
    {
        List<tCurso> Lista;

        public tListadeCursos()
        {
            Lista = new List<tCurso>();
        }

        public void AñadirCurso(tCurso Curso)
        {
            this.Lista.Add(Curso);
        }
        public void EliminarCurso(int codigo)
        {
            this.Lista.RemoveAt(codigo);
        }
        public tCurso DevolverCurso(int codigo)
        {
            return this.Lista[codigo];
        }
        public int NumeroCursos()
        {
            return this.Lista.Count;
        }
        public bool ContainsNombre(string nombre)
        {
            for (int i = 0; i < this.Lista.Count; i++)
            {
                if (this.DevolverCurso(i).GetNombre() == nombre)
                    return true;
            }
            return false;
        }
        public bool ContainsCodigo(int codigo)
        {
            for (int i = 0; i < this.Lista.Count; i++)
            {
                if (this.DevolverCurso(i).GetCodigo() == codigo)
                    return true;
            }
            return false;
        }
    }
}
