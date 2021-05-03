using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    class Empleado
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private int ventas;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public void SetVentas(int ventas)
        {
            this.ventas = ventas;
        }
        
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellidos()
        {
            return this.apellidos;
        }
        public int GetEdad()
        {
            return this.edad;
        }
        public int GetVentas()
        {
            return this.ventas;
        }

        public void cumpleAnyos()
        {
            this.edad += 1;
        }
        public void sumarVenta()
        {
            this.ventas += 1;
        }

        public void AñadirVentas(int ventas)
        {
            this.ventas += ventas;
        }

        public void EliminarVentas()
        {
            this.ventas = 0;
        }

        public void MostrarEmpleado()
        {

            Console.WriteLine(this.GetNombre());
            Console.WriteLine(this.GetApellidos());
            Console.WriteLine(this.GetEdad());
            Console.WriteLine(this.GetVentas());
            Console.WriteLine();

        }
    }
}
