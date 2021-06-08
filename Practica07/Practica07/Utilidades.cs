using System;
using System.Collections.Generic;
using System.Text;

namespace Practica07
{
    class Utilidades
    {
        public static void PulsaTeclaParaContinuar()
        {
            Console.Write("Pulsa una tecla para continuar: ");
            Console.ReadLine();
        }
        public static int PedirInt(string mensaje)
        {
            bool datoValido;
            string input;
            int entero = 0;
            do
            {
                Console.Write(mensaje);
                input = Console.ReadLine();
                datoValido = int.TryParse(input, out int output);
                if (datoValido)
                    entero = output;
                else
                    Console.WriteLine("El tipo de dato introducido no es válido, vuelva a intentarlo");
            } while (!datoValido);
            
            return entero;                            
        }
        public static double PedirDouble(string mensaje)
        {
            bool datoValido;
            string input;
            double numero = 0;
            do
            {
                Console.Write(mensaje);
                input = Console.ReadLine();
                datoValido = double.TryParse(input, out double output);
                if (datoValido)
                    numero = output;
                else
                    Console.WriteLine("El tipo de dato introducido no es válido, vuelva a intentarlo");
            } while (!datoValido);

            return numero;
        }
    }
}
