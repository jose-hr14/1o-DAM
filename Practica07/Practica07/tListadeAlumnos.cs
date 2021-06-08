using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class tListadeAlumnos
    {
        private List<tAlumno> Lista;

        public tListadeAlumnos()
        {
            Lista = new List<tAlumno>();
        }
        public int DevolverNumeroAlumnos()
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
        public void OrdernarAlfabeticamente()
        {
            tAlumno aux;
            for (int i = 0; i < Lista.Count -1; i++)
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
