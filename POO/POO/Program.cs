using System;
using System.Collections.Generic;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Alumno> list = new List<Alumno> (); //Para crear la lista, usamos el using system collections generic, debajo del using system;

            /*
            Alumno alu = new Alumno();
            alu.nia = 7;
            alu.nombre = "Óscar";

            Alumno alu2 = alu;
            alu.nia = 8; //Como hacen referencia al mismo objeto, el nia cambia tanto en la variable alu como en la variable alu2

            alu.InvalidateNia(); 

            */

            Alumno alu = new Alumno();
            //alu.nia = 7;
            //alu.nombre = "Aitor";
            alu.SetNia(7); //Hemos puesto las propiedades como private, pero aun asi, podemos aisgnar las propiedades con los metodos de objeto de alumno, que si son publicos
            alu.SetNombre("Aitor Franchute"); //Esto es porque los métodos de objeto sí pueden hacer a las propiedades de esa clase
            //Alumno lou = new Alumno();

            list.Add(alu); //list es la variable que referencia a la lista de alumnos            
                           //El refcount de ese objeto, sube a dos, porque lo referencia tanto la variable como la lista, si el refcount llega a cero, se borra el objeto

            Alumno alu2 = new Alumno();
            alu2.SetNombre("Juanfran Bueno");
            alu2.SetNia(69);
            list.Add(alu2);

            Alumno alu3 = new Alumno();
            alu3.SetNombre("Josemi Navarrete");
            alu3.SetNia(44);
            list.Add(alu3);

            //list[0];
            for (int i = 0; i < list.Count; i++) //Para msotrar todos los objetos de la lista
            {
                Alumno alumno = list[i];
                Console.WriteLine("Alumno " + i);
                Console.WriteLine("Nombre: " + alumno.nombre);
            }


        }
    }
}
