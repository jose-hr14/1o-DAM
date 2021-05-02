using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class fn_ListaEmpleados
    {
        List<Empleado> Lista = new List<Empleado>();

        public void IntroducirEmpleado (Empleado empleado)
        {
            Lista.Add(empleado);
        }
        public void EliminarEmpleado(int indice)
        {
            Lista.RemoveAt(indice);
        }
        public void MostrarListaEmpleados()
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine(Lista[i].GetNombre());
                Console.WriteLine(Lista[i].GetApellidos());  
                Console.WriteLine(Lista[i].GetEdad());  
                Console.WriteLine(Lista[i].GetVentas());  
            }
        }
        /*
        public static void IntroducirEmpleado02(List<Empleado> Lista, Empleado empleado)
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
            if (Lista[1].GetNombre() != Lista[2].GetNombre())
            {
                Console.WriteLine();
            }
        }
        */
    }
}
