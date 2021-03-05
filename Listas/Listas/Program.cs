using System;
using System.Collections;

namespace Listas
{
    class Program
    {
        public static void ImprimirLista(ArrayList Lista)
        {
            for (int i = 0; i < Lista.Count; i++) //Recorrer el Array para imprimir
            {
                Console.WriteLine(Lista[i]);
            }
        }
        static void Main(string[] args)
        {
            ArrayList Lista = new ArrayList();
            
            Console.WriteLine("El número de elementos es " + Lista.Count);
            Lista.Add(2); //Metemos elementos en la lista
            Console.WriteLine("El número de elementos es " + Lista.Count);
            Lista.Add(7); //Metemos elementos en la lista
            Lista.Add(2); //Metemos elementos en la lista
            Console.WriteLine("El número de elementos es " + Lista.Count);
            Console.WriteLine(Lista[2]); //Mostrando un elemento de la lsita indicando su índice
            //Console.WriteLine(Lista[7]); //Intentando aaceder a un valor con un índice que se sale de su rango, hemos puesto un valor superior al count
            Console.WriteLine();
            //Foreach permite recorrer todo el arraylist
            //Foreach tipo_dato nom_variable in nom_array
            //Sort ordena los datos. Lista.Sort();
            Lista.Add(5);
            Lista.Add(6);
            Lista.Add(7);
            Lista.Add(8);
            for (int i = 0; i < Lista.Count; i++) //Recorrer el Array para imprimir
            {
                Console.WriteLine(Lista[i]);
            }
            Console.WriteLine("Los elementos  ordenador son: ");
            Lista.Sort(); //Con este metodo ordenamos la lista, y volvemos a imprimir la lista ordenada. 
            //Si no todos los datos son del mismo tipo, son dará error porque comparamos valores con un tipo de dato distinto
            for (int i = 0; i < Lista.Count; i++) //Recorrer el Array para imprimir
            {
                Console.WriteLine(Lista[i]);
            }

            //Lista.Insert(i, dato);
            //Con este métodos, metemos un elementos en la posición que indiquemos
            //Lista.Insert(2, 20);

            //Lista.Remove(dato); Elimina de la lista el que le pasamos como parametro
            Lista.Remove(2);
            Console.WriteLine();
            ImprimirLista(Lista);

            //Lista.RemoveAt(posicion); Elimina un elemento de una posición concreta
            ArrayList Lista02 = new ArrayList();
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(2);
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(3);
            Lista02.Add(3);
            //for (int i = 0; i < Lista.Count; i++) //No podriamos borrar todos los 3 de la lista si la lista solo tiene 3
                //Lista02.Remove(3);
            Console.WriteLine();

            int Count = Lista02.Count;
            for (int i = 0; i < Count; i++) //Ahora sí daría, porque el count es constante
            {
                Lista02.Remove(3);
            }

            Lista02.IndexOf(2); //Devuelve el índice del primer elemento coincidente que encuentra
        }
    }
}
