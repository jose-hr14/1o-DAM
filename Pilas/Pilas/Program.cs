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
            int a = 0;
            int b = 0;
            while (cola.Count > 0)
            {
                string operando = cola.Dequeue();
                a = pila.Pop();
                b = pila.Pop();
                if (operando == "+")
                    solucion = b + a;
                else if (operando == "-")
                    solucion = b - a;
                else if (operando == "*")
                    solucion = b * a;
                else if (operando == "/")
                    solucion = b / a;
                pila.Push(solucion);
            }
            return pila.Pop();
        }
        public static int NotacionPolacaInversa(Stack<int> pila, Queue<char> cola)
        {
            int solucion = 0;
            int a = 0;
            int b = 0;
            while (cola.Count > 0)
            {
                char operando = cola.Dequeue();
                a = pila.Pop();
                b = pila.Pop();
                if (operando == Convert.ToChar("+"))
                    solucion = b + a;
                else if (operando == Convert.ToChar("-"))
                    solucion = b - a;
                else if (operando == Convert.ToChar("*"))
                    solucion = b * a;
                else if (operando == Convert.ToChar("/"))
                    solucion = b / a;
                pila.Push(solucion);
            }
            return pila.Pop();
        }
        public static void EjClase01() //Introduce y mete valores hasta que pulses enter
        {
            Stack<int> Pila = new Stack<int>();
            Queue<char> Cola = new Queue<char>();            
            string no_enter;            
            do
            {
                Console.WriteLine("Introduce un número: ");
                //Pila.Push(Convert.ToInt32(Console.ReadLine()));
                no_enter = Console.ReadLine();
                if (no_enter != "")
                {                    
                    Pila.Push(Convert.ToInt32(no_enter));
                }
                    
            } while (no_enter !=  "");
        }
        public static void EjClase02() //Introduce y mete valores hasta que pulses enter. Pero que la pila monte un mínimo de dos números
        {
            Stack<int> Pila = new Stack<int>();
            Queue<char> Cola = new Queue<char>();
            string no_enter;
            do
            {
                intentar:
                Console.Write("Introduce un número: ");
                //Pila.Push(Convert.ToInt32(Console.ReadLine()));
                no_enter = Console.ReadLine();
                if (no_enter != "")
                {
                    //Pila.Push(Convert.ToInt32(no_enter));
                    int i = 0;
                    if (Int32.TryParse(no_enter, out i))
                    {
                        Pila.Push(i);
                    }
                    else
                    {
                        Console.WriteLine("El valor introducido es incorrecto.");
                        goto intentar;
                    }
                }
                else if (Pila.Count <= 1)
                {
                    Console.WriteLine("Son necesarios mínimo dos números, pulse enter.");
                    Console.ReadLine();
                    goto intentar;
                }

            } while (no_enter != "");
        }
        public static Stack<int> EjClase02_Return() //Igual que el anterior, pero devuelve la pila.
        {
            Stack<int> Pila = new Stack<int>();
            Queue<char> Cola = new Queue<char>();
            string no_enter;
            do
            {
            intentar:
                Console.Write("Introduce un número: ");
                //Pila.Push(Convert.ToInt32(Console.ReadLine()));
                no_enter = Console.ReadLine();
                if (no_enter != "")
                {
                    //Pila.Push(Convert.ToInt32(no_enter));
                    int i = 0;
                    if (Int32.TryParse(no_enter, out i))
                    {
                        Pila.Push(i);
                    }
                    else
                    {
                        Console.WriteLine("El valor introducido es incorrecto.");
                        goto intentar;
                    }
                }
                else if (Pila.Count <= 1)
                {
                    Console.WriteLine("Son necesarios mínimo dos números, pulse enter.");
                    Console.ReadLine();
                    goto intentar;
                }

            } while (no_enter != "");
            return Pila;
        }
        public static void EjClase03(Stack<int> Pila) //Funcion que mete operandos en una cola, cuya cantidad sea igual a la cantidad de numeros de la pila menos una
        {
            Console.WriteLine("Introduce un operando");
            string no_character;
            Queue<char> Cola = new Queue<char>();
            
            do
            {
                Console.Write("Introduce operando: ");
                no_character = Console.ReadLine();
                if (no_character == "+" || no_character == "-" || no_character == "*" || no_character == "/")
                {
                    Cola.Enqueue(Convert.ToChar(no_character));
                }
                else
                {
                    Console.WriteLine("El valor introducido no es un operando.");
                }
            } while (Cola.Count < Pila.Count - 1);
        }
        public static Queue<char> EjClase03_Return(Stack<int> Pila) //Igual que la anterior, pero devuelve la pila
        {
            Console.WriteLine("Introduce un operando");
            string no_character;
            Queue<char> Cola = new Queue<char>();

            do
            {
                Console.Write("Introduce operando: ");
                no_character = Console.ReadLine();
                if (no_character == "+" || no_character == "-" || no_character == "*" || no_character == "/")
                {
                    Cola.Enqueue(Convert.ToChar(no_character));
                }
                else
                {
                    Console.WriteLine("El valor introducido no es un operando.");
                }
            } while (Cola.Count < Pila.Count - 1);
            return Cola;
        }
        static void Main(string[] args)
        {
            //PilaEscaleraAsteriscos(6);
            //CrearPilaNum();
            //CrearPilaOperando();
            //int a = NotacionPolacaInversa(CrearPilaNum(), CrearPilaOperando());
            //EjClase02();
            //EjClase03(EjClase02_Return());
            Stack<int> Pila = EjClase02_Return();
            Queue<char> Cola = EjClase03_Return(Pila);
            NotacionPolacaInversa(Pila, Cola);

        }
    }
}
