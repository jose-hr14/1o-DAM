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
        public tAlumno DevolverAlumno(int codigo)
        {
            return this.Lista[codigo];
        }
        public void AñadirAlumno(tAlumno nuevoAlumno)
        {
            this.Lista.Add(nuevoAlumno);
        }
        public void BorrarAlumno(int indice)
        {
            this.Lista.RemoveAt(indice);
        }
        public void AñadirAlumnoEnIndice(int indice, tAlumno alumno)
        {
            this.Lista[indice] = alumno;
        }
        public bool CotieneAlumno(tAlumno alumno)
        {
            if (this.Lista.Contains(alumno))
                return true;
            else
                return false;
        }

        public void OrdernarAlfabeticamente()
        {
            tAlumno aux;
            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i].GetNombre().CompareTo(Lista[j].GetNombre()) == 1)
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
                }
            }
        }
    }
}
