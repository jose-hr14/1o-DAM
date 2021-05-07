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
            return this.NumeroCursos();
        }
    }
}
