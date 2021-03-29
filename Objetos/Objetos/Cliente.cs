using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Cliente
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private string dni;
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public string GetApellidos()
        {
            return apellidos;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetDNI(string dni)
        {
            this.dni = dni;
        }
        public string GetDNI()
        {
            return dni;
        }
    }
}
