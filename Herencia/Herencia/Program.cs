using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo circulo = new Circulo(4, 5, "verde", 4);
            string mensaje = circulo.quienSoy();
            Console.WriteLine(mensaje);

            Figura figura = circulo;
            mensaje = figura.quienSoy();
            Console.WriteLine(mensaje);

            Figura circulo02 = new Circulo(3, 4, "azul", 8);
            mensaje = circulo02.quienSoy();
            Console.WriteLine(mensaje);

            Console.WriteLine(circulo02.Area());
        }
    }
}
