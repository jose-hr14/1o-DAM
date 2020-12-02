using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Alumno
    {
        public int nia; //lo de public es el nivel de visibilidad, si no ponemos, se declaran como private
        public string nombre; //el private solo es visible desde dentro de la misma clase

        public void InvalidateNia() //método de clase o de objeto, asi que no lleva static. Sin static, es un método de objeto, por tanto, necesita un objeto para utilizar dicho metodo.
        {
            nia = -1;
        }

        public void SetNia(int nia)
        {
            this.nia = nia;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        //this es la referencia al objeto con el que estamos realizando una operacion, this es una referencia
    }
}
