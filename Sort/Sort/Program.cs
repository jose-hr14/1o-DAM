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
        public static void OrderList(List<int> list)
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
        }

        public static void PrintOrderedList(List<int> list)
        {
            OrderList(list);
            PrintList(list);
        }
        //funcion que le pases una lista y un numero, y devuelve si ese numero esta en la lista
        public static bool ContainsNumber(List<int> list, int number)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                if (list[i] == number)
                    return true;
            }
            return false;
        }

        public static bool ContrainsNumber2(List<int> list, int number)
        {
            int min = 0;
            int max = list.Count -1;
            int mid;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (list[mid] == number)
                    return true;
                if (number < list[mid])                
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return false;
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

            //PrintList(list);
            OrderList(list);
            bool contains = ContrainsNumber2(list, 1);
        }
    }
}