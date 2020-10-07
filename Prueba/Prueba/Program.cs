using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios.Ejercicio01();
            //Ejercicios.Ejercicio02(16);
            //Maths.IsPrime(1336);

            //Maths.RestaConteo(5);
            //Ejercicios.Ejercicio04();

            //Ejercicios.Ejercicio05();

            Student s1, s2;
            s1 = new Student();
            s2 = new Student();
            //Importante
            s1.name = "Abel";
            s2.name = "Alex";
            string ss = s1.getNameTwice();
           
        }
    }
}
