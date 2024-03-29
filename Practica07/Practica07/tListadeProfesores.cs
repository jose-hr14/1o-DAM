﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class tListadeProfesores
    {
        private List<tProfesor> Lista;
        public tListadeProfesores()
        {
            Lista = new List<tProfesor>();
        }
        public void AñadirProfesor(tProfesor nuevoProfesor)
        {
            this.Lista.Add(nuevoProfesor);
        }
        public int DevolverNumeroProfesores()
        {
            return this.Lista.Count;
        }
        public tProfesor DevolverProfesor(int codigo)
        {
            return this.Lista[codigo];
        }
        public void BorrarProfesor(int indice)
        {
            this.Lista.RemoveAt(indice);
        }
        public void OrdernarAlfabeticamente()
        {
            tProfesor aux;
            for (int i = 0; i < Lista.Count - 1; i++)
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
