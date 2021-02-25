using System;
using System.Collections.Generic;
namespace Pilas
{
    class Program
    {
        public static void ImprimirPilaString(Stack<string> Pila)
        { 
            while (Pila.Count > 0)
            {

            }
        }

        public static Stack<string> PilaEscaleraAsteriscos(int CountPila)
        {
            Stack<string> pila = new Stack<string>();
            string cadena = "";

            for (int i = CountPila; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    cadena += "*";
                }
                pila.Push(cadena);
                cadena = "";
            }
            return pila;
        }
        public static void PilaEscaleraAsteriscosSolucion(int CountPila)
        {
            Stack<string> mi_pila = new Stack<string>();
            string mi_cadena = "";
            int numero = 4;
            for (int i = 0; i < numero; i++)
            {
                mi_cadena = "";
                for (int j = i; j < numero; j++)
                {
                    mi_cadena = mi_cadena + "*";
                    mi_pila.Push(mi_cadena);
                }
            }
        }
        static void Main(string[] args)
        {
            PilaEscaleraAsteriscos(6);
        }
    }
}
