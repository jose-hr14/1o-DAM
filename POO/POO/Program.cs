using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
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
            alu.SetNombre("Aitor"); //Esto es porque los métodos de objeto sí pueden hacer a las propiedades de esa clase
            Alumno lou = new Alumno();
            
        }
    }
}
