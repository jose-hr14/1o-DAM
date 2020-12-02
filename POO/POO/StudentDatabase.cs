using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class StudentDatabase
    {
        List<Alumno> list;

        public void Add(Alumno alu)
        {
            this.list.Add(alu);
        }

        public void InitDatabase()
        {
            this.list = new List<Alumno>();
        }

        public void PrintStudentList() //list es una variable que hace una referencia a la lista
        {
            for (int i = 0; i < list.Count; i++) //Para msotrar todos los objetos de la lista
            {
                Alumno alumno = list[i];
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
