using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class StudentDatabase
    {
        List<Student> list;

        public void Add(Student alu)
        {
            this.list.Add(alu);
        }

        public void InitDatabase()
        {
            this.list = new List<Student>();
        }

        public void PrintStudentList() //convertimos este metodo que teniamos en el main, en un metodo de objeto de la base de datos
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
    }
}
