using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Ej05
    {
        public static void MenuIntroducirEmpleado(ListaEmpleados Lista)
        {
            Empleado NuevoEmpleado = new Empleado();
            Console.Write("Introduce un nombre: ");
            NuevoEmpleado.SetNombre(Console.ReadLine());
            Console.Write("Introduce apellidos: ");
            NuevoEmpleado.SetApellidos(Console.ReadLine());
            Console.Write("Introduce la edad: ");
            NuevoEmpleado.SetEdad(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Introduce el número de ventas: ");
            NuevoEmpleado.SetVentas(Convert.ToInt32(Console.ReadLine()));
            Lista.IntroducirEmpleado(NuevoEmpleado);
        }
        public static void MenuEliminarEmpleado(ListaEmpleados Lista)
        {
            Console.Write("Introduce el número del empleado que quieres borrar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            Lista.EliminarEmpleado(indice);
        }
        public static void MenuMostrarDatosEmpleado(ListaEmpleados Lista)
        {
            Console.Write("Introduce el número del empleado que quieres mostrar: ");
            int indice = Convert.ToInt32(Console.ReadLine());
            Lista.MostrarDatosEmpleado(indice);
        }
        public static void MenuGestionarEmpleados(ListaEmpleados Lista)
        {
            Console.Clear();
            bool salir = false;
            string option;
            do
            {
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1.- Introducir empleado");
                Console.WriteLine("2.- Eliminar empleado");
                Console.WriteLine("3.- Mostrar lista empleados");
                Console.WriteLine("4.- Ordenar empleados por orden alfabético");
                Console.WriteLine("5.- Mostrar datos empleados");
                Console.WriteLine("0.- Salir");
                option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {
                    case "1":
                        MenuIntroducirEmpleado(Lista);
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "2":
                        MenuEliminarEmpleado(Lista);
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "3":
                        Lista.MostrarListaEmpleados();
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "4":
                        Lista.OrdenarEmpleados();
                        Console.WriteLine("Lista de empleados ordenada por orden alfabético");
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "5":
                        MenuMostrarDatosEmpleado(Lista);
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, vuelta a intentarlo");
                        break;
                }
                Console.Clear();
            } while (salir == false);
        }
        public static void Ejercicio05()
        {
            ListaEmpleados Lista = new ListaEmpleados();
            string option;
            bool salir;
            do
            {
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1.- Gestionar empleados");
                Console.WriteLine("2.- Gestionar ventas");
                Console.WriteLine("0.- Salir");
                option = Console.ReadLine();
                salir = false;
                switch (option)
                {
                    case "1":
                        MenuGestionarEmpleados(Lista);
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, vuelta a intentarlo");
                        break;
                }
                Console.Clear();
            } while (salir == false);

        }
    }
}
