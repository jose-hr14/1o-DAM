using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    public class tCurso
    {
        string nombre;
        int codigo;
        public tCurso(string nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public int GetCodigo()
        {
            return this.codigo;
        }
    }
}
