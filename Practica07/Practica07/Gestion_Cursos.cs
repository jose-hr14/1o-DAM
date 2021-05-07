using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class Gestion_Cursos
    {
        public void AñadirCurso(tListadeCursos ListaCursos, string nombre)
        {
            tCurso nuevoCurso = new tCurso(nombre, ListaCursos.NumeroCursos());
            ListaCursos.AñadirCurso(nuevoCurso);
        }
        public void EliminarCurso(tListadeCursos ListaCursos, int codigoCurso)
        {
            ListaCursos.EliminarCurso(codigoCurso);
        }
        public void MostrarTodosCursos(tListadeCursos ListaCursos)
        {
            for (int i = 0; i < ListaCursos.NumeroCursos(); i++)
            {
                Console.WriteLine(ListaCursos.DevolverCurso(i).GetNombre());
                Console.WriteLine(ListaCursos.DevolverCurso(i).GetCodigo());
                Console.WriteLine();
            }
        }
        public void MostrarAlumnosDeUnCurso(tListadeAlumnos ListaAlumnos, int codigoCurso)
        {
            for (int i = 0; i < ListaAlumnos.NumeroAlumnos(); i++)
            {

            }
        }


    }
}
