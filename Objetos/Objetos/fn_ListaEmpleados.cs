using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class fn_ListaEmpleados
    {
        public static void IntroducirEmpleado(List<Empleado> Lista, Empleado empleado)
        {
            Lista.Add(empleado);
        }
        public static void EliminarEmpleado(List<Empleado> Lista, int indice)
        {
            Lista.RemoveAt(indice);
        }
        public static void MostrarListaEmpleados(List<Empleado> Lista)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine(Lista[i]);
            }
        }
        public static void OrdenarEmpleadosOrdenAlfabetico(List<Empleado> Lista)
        {
            if (Lista[1].GetNombre() < Lista[2].GetNombre())
            {
                Console.WriteLine();
            }
        }
    }
}
