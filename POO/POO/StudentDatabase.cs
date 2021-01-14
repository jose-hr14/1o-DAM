using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class StudentDatabase
    {
        private List<Student> list;

        public StudentDatabase()
        {
            this.list = new List<Student>();
        }

        public void Add(Student alu)
        {
            this.list.Add(alu);
        }
        /*
        public void InitDatabase()
        {
            //this.list = new List<Student>();
        }
        */
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

        public bool ContainsStudent(string name) //comprueba si hay un studiante en la lista que tenga el nombre usado como parámetro, recorre todos los estudiantes
        {
            return GetStudentIndex(name) != -1; //devuelve un bool porque no devuelve el int que devuelve la funcion, sino que devuelve la comparacion
        }

        //metodo que devuelva la posicion en la que está un alumno en la lista de datos
        private int GetStudentIndex(string name) //lo cambiamos a privare
        {
            for (int i = 0; i < list.Count; i++)
            {
                Student s = list[i];
                if (s.IsNamed(name))
                    return i;
            }
            return -1;
        }

        private int GetStudentIndexWithNia(int nia)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Student s = list[i];
                if (s.GetNIA() == nia)
                    return i;
            }
            return -1;
        }

        public int GetStudentCount()
        {
            return list.Count;
        }

        public void RemoveStudent(string name) //Para eliminar a un alumno de la lista de la base de datos
        {
            int index = GetStudentIndex(name);
            if (index >= 0)
                list.RemoveAt(index);
        }

        public void RemoveStudent(int nia)
        {
            int index = GetStudentIndexWithNia(nia);
            if (index >= 0)
                this.list.RemoveAt(index);
        }

        public void RemoveAllStudents()
        {
            this.list.Clear();
        }



    }
}
