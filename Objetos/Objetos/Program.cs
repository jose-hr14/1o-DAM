using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Objetos
{
    class Program
    {
        // Las lineas de codigo para crear un vector de enteros de 10 elementos, nos tiene que decir si el numero introducido está en el vector o no
        public static void EjProfe()
        {
            int[] Vector = new int[10] { 1, 7, 9, 8, 6, 11, 12, 13, 14, 5 };
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] == num)
                {
                    Console.WriteLine("El número está");
                    break;
                }
                    
                if (i == Vector.Length - 1)
                    Console.WriteLine("El número no está");
            }
        }
        public static void EjProfeSolucion()
        {
            int[] Vector = new int[10] { 1, 7, 9, 8, 6, 11, 12, 13, 14, 5 };
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] == num)
                {
                    Console.WriteLine("El número está");
                    break;
                }
                else if (i == Vector.Length - 1)
                    Console.WriteLine("El número no está");
            }
        }
        public static void ApuntesClases()
        {
            //EjProfe();
            PersonaApuntes.Cliente profe_juanfran = new PersonaApuntes.Cliente();
            profe_juanfran.nombre = "Juan Francisco";
            profe_juanfran.apellidos = "Bueno";
            profe_juanfran.edad = 45;
            profe_juanfran.dni = "123456789";
        }
        public static void Ej01()
        {
            List<Persona> ListaPersonas = new List<Persona>();
            bool salir = false;
            do
            {
                Console.WriteLine("-- Ejercicio 01 --");
                Console.WriteLine("1.- Guardar Persona");
                Console.WriteLine("2.- Mostrar Personas registradas");
                Console.WriteLine("3.- Salir");
                Console.Write("Elige una opción: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        SetPersona(ListaPersonas);
                        Console.Write("Pulse enter para continuar: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        PrintPersona(ListaPersonas);
                        Console.Write("Pulse enter para continuar: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.Write("Opción inválida, pulse enter: ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (salir == false);            
        }
        public static void SetPersona(List<Persona> ListaPersonas)
        {
            Persona NuevaPersona = new Persona();

            Console.Write("Introduce el nombre: ");
            NuevaPersona.SetNombre(Console.ReadLine());
            Console.Write("Introduce la edad: ");
            NuevaPersona.SetEdad(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Introduce el teléfono: ");
            NuevaPersona.SetTelefono(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Introduce el sexo: ");
            NuevaPersona.SetSexo((Console.ReadLine()));
            Console.Write("Introduce el estado civil: ");
            NuevaPersona.SetEstadoCivil((Console.ReadLine()));
            
            ListaPersonas.Add(NuevaPersona);
        }
        public static void PrintPersona(List<Persona> ListaPersonas)
        {
            for (int i = 0; i < ListaPersonas.Count; i++)
            {
                Console.WriteLine("El nombre de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetNombre());
                Console.WriteLine("La edad de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetEdad());
                Console.WriteLine("El teléfono de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetTelefono());
                Console.WriteLine("El sexo de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetSexo());
                Console.WriteLine("El estado civil de la persona " + (i + 1) + " es : " + ListaPersonas[i].GetEstadoCivil());
                Console.WriteLine();
            }            
        }

        //
        //
        public static void PrintFechas(List<Fecha> Lista)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Lista[i].PrintFecha();
            }
        }
        public static void OrderFechaByDia(List<Fecha> Lista)
        {
            Lista.Sort();
        }
        public static void OrderByAño(List<Fecha> Lista)
        {
            //Lista.Sort((x, y) => x.GetAño().CompareTo(y.GetAño()));
            Fecha aux;
            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j =i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i].GetAño() > Lista[j].GetAño())
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
                }
            }
        }
        public static void OrderByMes(List<Fecha> Lista)
        {
            //Lista.Sort((x, y) => x.GetAño().CompareTo(y.GetAño()));
            Fecha aux;
            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i].GetMes() > Lista[j].GetMes() && Lista[i].GetAño() == Lista[j].GetAño())
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
                }
            }
        }
        public static void OrderByDia(List<Fecha> Lista)
        {
            //Lista.Sort((x, y) => x.GetAño().CompareTo(y.GetAño()));
            Fecha aux;
            for (int i = 0; i < Lista.Count; i++)
            {
                for (int j = i + 1; j < Lista.Count; j++)
                {
                    if (Lista[i].GetDia() > Lista[j].GetDia() && Lista[i].GetAño() == Lista[j].GetAño() && Lista[i].GetMes() == Lista[j].GetMes())
                    {
                        aux = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = aux;
                    }
                }
            }
        }
        public static bool ValidateFecha(int dia, int mes, int año)
        {
            if (mes < 0 && mes > 13)
                return false;
            if (dia < 0 && dia > 31)
                return false;
            if ((mes == 4 || mes == 6 || mes == 9 || mes == 1) && dia > 30)
                return false;
            return true;

        }
        public static void Ej03()
        {
            List<Fecha> Lista = new List<Fecha>();
            Fecha fecha01 = new Fecha();
            Fecha fecha02 = new Fecha();
            Fecha fecha03 = new Fecha();
            Fecha fecha04 = new Fecha();

            fecha01.SetAño(1996);
            fecha01.SetMes(06);
            fecha01.SetDia(08);

            fecha02.SetAño(1996);
            fecha02.SetMes(06);
            fecha02.SetDia(01);

            fecha03.SetAño(1996);
            fecha03.SetMes(06);
            fecha03.SetDia(03);

            fecha04.SetAño(1992);
            fecha04.SetMes(02);
            fecha04.SetDia(01);

            Lista.Add(fecha01);
            Lista.Add(fecha02);
            Lista.Add(fecha03);
            Lista.Add(fecha04);

            OrderByAño(Lista);
            OrderByMes(Lista);
            OrderByDia(Lista);

        }
        //4. Realizar un ejercicio con el siguiente formulario (Ejercicio Resuelto):
        /*
        Este ejercicio trabajaremos con una lista de empleados.Tanto el empleado como la lista
        serán clases de Visual C# .NET.
        • En el primer botón se leerá un nuevo empleado.

        Programación Tema 7. Programación Orientada a Objetos
        Página 2
        • El segundo botón mostrará los datos de todos los empleados que tenemos en
        nuestra lista.
        • El botón de Cumpleaños de Empleado pedirá el nombre del empleado y le
        sumarán un año llamando al método cumpleAnyos del objeto.
        • Añadir Venta a Empleado pedirá el nombre del empleado y permitirá introducirle
        ventas. */
        public static int GetEmpleadoIndexByName(List<Empleado> ListaEmpleados, string nombre)
        {
            for (int i = 0; i < ListaEmpleados.Count; i++)
            {
                if (ListaEmpleados[i].GetNombre().ToLower() == nombre.ToLower())
                {
                    ListaEmpleados[i].SetEdad(ListaEmpleados[i].GetEdad() + 1);
                    return i;
                }
            }
            return -1;
        }
        public static void MenuSumarVenta(List<Empleado> ListaEmpleados)
        {
            Console.WriteLine("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            int indice = GetEmpleadoIndexByName(ListaEmpleados, nombre);
            if (indice != -1)
            {
                ListaEmpleados[indice].sumarVenta();
                Console.WriteLine("Empleado encontrado y venta actualizada");
            }
            else
                Console.WriteLine("El cliente no existe, venta no actualizada");
            Console.Write("Pulsa una tecla para continuar ");
            Console.ReadLine();
        }
        public static void MenuCumpleAnyos(List<Empleado> ListaEmpleados)
        {
            Console.WriteLine("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            int indice = GetEmpleadoIndexByName(ListaEmpleados, nombre);
            if (indice != -1)
            {
                ListaEmpleados[indice].cumpleAnyos();
                Console.WriteLine("Empleado encontrado y edad actualizada");
            }
            else
                Console.WriteLine("El cliente no existe, edad no actualizada");
            Console.Write("Pulsa una tecla para continuar ");
            Console.ReadLine();
        }
        public static void ImprimirListaEmpleados(List<Empleado> ListaEmpleados)
        {
            for (int i = 0; i < ListaEmpleados.Count; i++)
            {
                Console.WriteLine("Numero de empleado: " + (i + 1));
                Console.WriteLine("Nombre: " + ListaEmpleados[i].GetNombre());
                Console.WriteLine("Apellidos: " + ListaEmpleados[i].GetApellidos());
                Console.WriteLine("Edad: " + ListaEmpleados[i].GetEdad());
                Console.WriteLine("Ventas: " + ListaEmpleados[i].GetVentas());
                Console.WriteLine();
            }
            Console.Write("Pulsa una tecla para continuar ");
            Console.ReadLine();
        }
        public static Empleado LeerEmpleado(string nombre, string apellidos, int edad, int ventas)
        {
            Empleado empleado = new Empleado();
            empleado.SetNombre(nombre);
            empleado.SetApellidos(apellidos);
            empleado.SetEdad(edad);
            empleado.SetVentas(ventas);

            return empleado;

        }
        public static void MenuLeerEmpleado(List<Empleado> ListaEmpleados)
        {
            Console.Write("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            nombre.Trim();
            Console.Write("Introduce apellidos: ");
            string apellidos = Console.ReadLine();
            apellidos.Trim();
            Console.Write("Introduce edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el número de ventas: ");
            int ventas = Convert.ToInt32(Console.ReadLine());

            Empleado empleado = LeerEmpleado(nombre, apellidos, edad, ventas);
            ListaEmpleados.Add(empleado);

            Console.Write("Pulsa una tecla para continuar ");
            Console.ReadLine();
        }
        public static void ImprimirMenuEj04()
        {
            Console.WriteLine("Elige una opción: ");
            Console.WriteLine("1.- Nuevo empleado.");
            Console.WriteLine("2.- Mostrar lista empleados.");
            Console.WriteLine("3.- Cumpleaños empleado.");
            Console.WriteLine("4.- Añadir venta");
            Console.WriteLine("0.- Salir");
        }
        public static void Ej04()
        {
            List<Empleado> ListaEmpleados = new List<Empleado>();
            string option;
            bool salir = false;
            do
            {
                ImprimirMenuEj04();
                option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {                    
                    case "1":                        
                        MenuLeerEmpleado(ListaEmpleados);
                        break;
                    case "2":
                        ImprimirListaEmpleados(ListaEmpleados);
                        break;
                    case "3":
                        MenuCumpleAnyos(ListaEmpleados);
                        break;
                    case "4":
                        MenuSumarVenta(ListaEmpleados);
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while (salir == false);

        }
        //
        public static void MenuGestionarEmpleados()
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1.- Introducir empleado");
            Console.WriteLine("2.- Eliminar empleado");
            Console.WriteLine("3.- Mostrar lista empleados");
            Console.WriteLine("4.- Ordenar empleados por orden alfabético");
            Console.WriteLine("5.- Mostrar datos empleados");
            Console.WriteLine("0.- Salir");
            string option = Console.ReadLine();
            bool salir = false;
            do
            {
                switch (option)
                {
                    case "1":
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
                    case "4":
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("Pulsa una tecla para continuar ");
                        Console.ReadLine();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opción inválida, vuelta a intentarlo");
                        break;
                }
                Console.Clear();
            } while (salir == false);
        }
        public static void Ej05()
        {
            Console.WriteLine("Elige una opción:");
            Console.WriteLine("1.- Gestionar empleados");
            Console.WriteLine("2.- Gestionar ventas");
            Console.WriteLine("0.- Salir");
            string option = Console.ReadLine();
            bool salir = false;
            do
            {
                switch (option)
                {
                    case "1":
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
                        break;
                    default:
                        Console.WriteLine("Opción inválida, vuelta a intentarlo");
                        break;
                }
                Console.Clear();
            } while (salir == false);

        }
        static void Main(string[] args)
        {


        }
    }
}
