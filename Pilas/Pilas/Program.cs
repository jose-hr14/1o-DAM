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
        public static Stack<int> CrearPilaNum()
        {
            Console.Write("Introduce el número de elementos que tendrá la pila: ");
            int Count = Convert.ToInt32(Console.ReadLine());
            Stack<int> pila = new Stack<int>();
            for (int i = 0; i < Count; i++)
            {
                Console.Write("Introduce un número para la posición " + (i + 1) + " de la pila: ");
                pila.Push(Convert.ToInt32(Console.ReadLine()));
            }
            return pila;
        }
        public static Queue<string> CrearPilaOperando()
        {
            Console.Write("Introduce el número de elementos que tendrá la cola: ");
            int Count = Convert.ToInt32(Console.ReadLine());
            Queue<string> cola = new Queue<string>();
            for (int i = 0; i < Count; i++)
            {
                Console.Write("Introduce un operando para la posición " + (i + 1) + " de la cola: ");
                cola.Enqueue(Console.ReadLine());
            }
            return cola;
        }
        public static int NotacionPolacaInversa(Stack<int> pila, Queue<string> cola)
        {
            int solucion = 0;
            while (cola.Count > 0)
            {
                string operando = cola.Dequeue();
                if (operando == "+")
                    solucion = pila.Pop() + pila.Pop();
                else if (operando == "-")
                    solucion = pila.Pop() - pila.Pop();
                else if (operando == "*")
                    solucion = pila.Pop() * pila.Pop();
                else if (operando == "/")
                    solucion = pila.Pop() / pila.Pop();
                pila.Push(solucion);
            }
            return pila.Pop();
        }
        static void Main(string[] args)
        {
            //PilaEscaleraAsteriscos(6);
            //CrearPilaNum();
            //CrearPilaOperando();
            NotacionPolacaInversa(CrearPilaNum(), CrearPilaOperando());

        }
    }
}
