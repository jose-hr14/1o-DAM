using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class Gestion_Cursos
    {
        public void Añadir_Curso(tListadeCursos Lista, string nombre)
        {
            tCurso nuevoCurso = new tCurso(nombre, Lista.NumeroCursos());
            Lista.AñadirCurso(nuevoCurso);
        }

    }
}
