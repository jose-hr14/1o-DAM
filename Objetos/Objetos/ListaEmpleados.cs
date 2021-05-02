using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Objetos
{
    class ListaEmpleados
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
                Console.WriteLine();
            }
        }
        public void OrdenarEmpleados()
        {            
            Lista.Sort((p, q) => string.Compare(p.GetNombre(), q.GetNombre())); //Ordena alfabéticamente por nombre la lista genérica lista
        }
        public void MostrarDatosEmpleado(int indice)
        {

            Console.WriteLine(Lista[indice].GetNombre());
            Console.WriteLine(Lista[indice].GetApellidos());
            Console.WriteLine(Lista[indice].GetEdad());
            Console.WriteLine(Lista[indice].GetVentas());
            Console.WriteLine();

        }
        public Empleado MostrarEmpleadosConMasVentas()
        {
            //Lista.Sort((p, q) => string.Compare(p.GetNombre(), q.GetNombre())); //Ordena alfabéticamente por nombre la lista genérica lista
            //Lista.Sort((x, y) => x.GetVentas().CompareTo(y.GetVentas()));
            Empleado aux;
            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i].GetVentas() > Lista[j].GetVentas())
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
                }
            }
            return Lista[0];
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
