using System;
using System.Collections.Generic;

namespace POO
{
    class Program
    {
        public static void PrintStudentList(List<Student> list) //list es una variable que hace una referencia a la lista
        {
            for (int i = 0; i < list.Count; i++) //Para msotrar todos los objetos de la lista
            {
                Student alumno = list[i];
                Console.WriteLine("Alumno " + i);
                //Console.WriteLine("Nombre: " + alumno.nombre); 
                //Console.WriteLine("NIA: " + alumno.nia);

                Console.WriteLine("Nombre: " + alumno.GetName()); //Aqui lo mostramos con el metodo de objeto que devuelve la propiedad de ese objeto
                Console.WriteLine("NIA: " + alumno.GetNIA()); //Ahore tenemos metodos
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            //List<Alumno> list = new List<Alumno> (); //Para crear la lista, usamos el using system collections generic, debajo del using system;
            //Borramos porque la lista de alumno la creamos en una clase

            StudentDatabase db = new StudentDatabase(); //inicializamos base de datos 
            //db.InitDatabase(); //Creamos base de datos. Esto es sustituido por el constructor de student base

            /*
            Alumno alu = new Alumno();
            alu.nia = 7;
            alu.nombre = "Óscar";

            Alumno alu2 = alu;
            alu.nia = 8; //Como hacen referencia al mismo objeto, el nia cambia tanto en la variable alu como en la variable alu2

            alu.InvalidateNia(); 

            */

            Student alu = new Student();
            //alu.nia = 7;
            //alu.nombre = "Aitor";
            alu.SetNia(7); //Hemos puesto las propiedades como private, pero aun asi, podemos aisgnar las propiedades con los metodos de objeto de alumno, que si son publicos
            alu.SetNombre("Carlos"); //Esto es porque los métodos de objeto sí pueden hacer a las propiedades de esa clase
            //Alumno lou = new Alumno();

            db.Add(alu); //Estamos añadiento ese alumno a la base de datos

            //list.Add(alu); //list es la variable que referencia a la lista de alumnos            
            //El refcount de ese objeto, sube a dos, porque lo referencia tanto la variable como la lista, si el refcount llega a cero, se borra el objeto

            Student alu2 = new Student();
            alu2.SetNombre("Juanfran Bueno");
            alu2.SetNia(69);
            //list.Add(alu2);
            db.Add(alu2);

            Student alu3 = new Student();
            alu3.SetNombre("Josemi Navarrete");
            alu3.SetNia(44);
            //list.Add(alu3);
            db.Add(alu3);

            //list[0];
            /*
            for (int i = 0; i < list.Count; i++) //Para msotrar todos los objetos de la lista
            {
                Alumno alumno = list[i];
                Console.WriteLine("Alumno " + i);
                //Console.WriteLine("Nombre: " + alumno.nombre); 
                //Console.WriteLine("NIA: " + alumno.nia);

                Console.WriteLine("Nombre: " + alumno.GetName()); //Aqui lo mostramos con el metodo de objeto que devuelve la propiedad de ese objeto
                Console.WriteLine("NIA: " + alumno.GetNIA()); //Ahore tenemos metodos
            }
            */
            //Hacer una funcion que imprima por pantalla una lista de alumnos

            //PrintStudentList(list); //Lo de mas arriba, lo comprimimos en un método y lo invocamos
            db.PrintStudentList();
            bool Constains = db.ContainsStudent("JUANFRAN BUENO");
            bool Constains2 = db.ContainsStudent("Paco");
            //int StudentIndex = db.GetStudentIndex("Juanfran Bueno");
            //db.RemoveStudent("JUANFRAN BUENO");
            //db.RemoveStudent(69);
            db.RemoveAllStudents();

        }
    }
}
