using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Persona
    {
        /*
         crear clase con atributos y metodos: getters, setters, imprimir
         */
        //nombre, edad, teléfono, sexo y si está casado
        private string nombre;
        private int edad;
        private int telefono;
        private string sexo;
        private bool casado;

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public int GetEdad()
        {
            return this.edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int GetTelefono()
        {
            return this.telefono;
        }
        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public string GetSexo()
        {
            return this.nombre;
        }
        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public bool GetCasado()
        {
            return this.casado;
        }
        public void SetCasado(bool casado)
        {
            this.casado = casado;
        }
    }
}
