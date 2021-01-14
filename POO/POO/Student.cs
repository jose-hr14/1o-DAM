using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Student
    {
        private int nia; //lo de public es el nivel de visibilidad, si no ponemos, se declaran como private
        private string name; //el private solo es visible desde dentro de la misma clase

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
            this.name = nombre;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetNIA()
        {
            return this.nia;
        }
        //this es la referencia al objeto con el que estamos realizando una operacion, this es una referencia

        public bool IsNamed(string name) //string no es un tipo nativo, asi que puede ser null, un string es un objeto, asi que no puede ser null
        {
            if (name == null || this.name == null )
                return name == null && this.name == null;
            else
                return this.name.ToLower() == name.ToLower();
        }



    }
}
