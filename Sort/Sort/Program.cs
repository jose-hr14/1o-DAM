using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        public static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++) //imprime toda la lista tal cual
            {
                Console.WriteLine(list[i]);
            }
        }
        public static void PrintOrderedList(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++) //for anidado para ordenar la lista
            {
                for (int j = i + 1; j < list.Count; j++) //
                {
                    if (list[j] < list[i]) //intercambiamos las variables para reajustar el orden, y ordenar así la lista
                    {
                        int aux = list[j];
                        list[j] = list[i];
                        list[i] = aux;
                    }
                }
            }
            PrintList(list); //Aqui ya imprimimos la lista ordenada
        }
        static void Main(string[] args)
        {
            //Programa para manejar listas
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(-1);
            list.Add(7);
            list.Add(8);
            list.Add(8);
            list.Add(0);
            list.Add(-5);

            PrintOrderedList(list);
        }
    }
}
